using System.Diagnostics;
using ChromePlusGUI.Models;

namespace ChromePlusGUI.Services;

public class ExecutableDetector
{
    private static readonly string[] TargetExecutables = { "chrome.exe", "comet.exe" };

    public IReadOnlyList<ExecutableInfo> Detect(string? preferredPath = null)
    {
        var results = new List<ExecutableInfo>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        AddCandidate(preferredPath, "Saved setting", results, seen);

        foreach (var path in EnumerateCommonExecutablePaths())
        {
            AddCandidate(path, "Common path", results, seen);
        }

        foreach (var path in EnumerateLocalExecutablePaths())
        {
            AddCandidate(path, "Adjacent to GUI", results, seen);
        }

        foreach (var path in EnumeratePathExecutablePaths())
        {
            AddCandidate(path, "PATH", results, seen);
        }

        return results;
    }

    public bool IsExecutableValid(string? path)
    {
        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
        {
            return false;
        }

        try
        {
            using var stream = File.OpenRead(path);
            Span<byte> header = stackalloc byte[2];
            var read = stream.Read(header);
            return read == 2 && header[0] == (byte)'M' && header[1] == (byte)'Z';
        }
        catch
        {
            return false;
        }
    }

    private void AddCandidate(string? path, string source, List<ExecutableInfo> results,
        HashSet<string> seen)
    {
        if (!IsExecutableValid(path))
        {
            return;
        }

        if (!seen.Add(path!))
        {
            return;
        }

        var fileInfo = FileVersionInfo.GetVersionInfo(path!);
        results.Add(new ExecutableInfo
        {
            Name = Path.GetFileName(path!) ?? string.Empty,
            Path = path!,
            Source = source,
            Version = fileInfo.FileVersion ?? string.Empty
        });
    }

    private IEnumerable<string> EnumerateCommonExecutablePaths()
    {
        var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        var programFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        var commonRoots = new[]
        {
            Path.Combine(programFiles, "Google", "Chrome", "Application"),
            Path.Combine(programFilesX86, "Google", "Chrome", "Application"),
            Path.Combine(localAppData, "Google", "Chrome", "Application"),
            Path.Combine(programFiles, "Comet"),
            Path.Combine(programFilesX86, "Comet"),
            Path.Combine(localAppData, "Comet"),
        };

        foreach (var root in commonRoots)
        {
            foreach (var exe in TargetExecutables)
            {
                yield return Path.Combine(root, exe);
            }
        }
    }

    private IEnumerable<string> EnumerateLocalExecutablePaths()
    {
        var baseDir = AppContext.BaseDirectory;
        foreach (var exe in TargetExecutables)
        {
            yield return Path.Combine(baseDir, exe);
        }
    }

    private IEnumerable<string> EnumeratePathExecutablePaths()
    {
        var path = Environment.GetEnvironmentVariable("PATH") ?? string.Empty;
        var segments = path.Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries);
        foreach (var segment in segments)
        {
            foreach (var exe in TargetExecutables)
            {
                yield return Path.Combine(segment.Trim(), exe);
            }
        }
    }
}
