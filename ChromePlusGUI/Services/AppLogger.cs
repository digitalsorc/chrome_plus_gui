using System.Diagnostics;
using System.IO;

namespace ChromePlusGUI.Services;

public static class AppLogger
{
    private static readonly object SyncRoot = new();
    private static readonly string LogDirectory =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ChromePlusGUI", "logs");
    private static readonly string LogFile = Path.Combine(LogDirectory, "config_gui.log");

    public static event Action<string>? EntryAdded;

    public static void Info(string message) => Write("INFO", message);

    public static void Error(string message, Exception? ex = null) =>
        Write("ERROR", ex is null ? message : $"{message} | {ex}");

    private static void Write(string level, string message)
    {
        var line = $"{DateTimeOffset.Now:u} [{level}] {message}";
        try
        {
            Directory.CreateDirectory(LogDirectory);
            lock (SyncRoot)
            {
                File.AppendAllText(LogFile, line + Environment.NewLine);
            }
        }
        catch (Exception logEx)
        {
            Debug.WriteLine($"Failed to write log: {logEx}");
        }

        EntryAdded?.Invoke(line);
    }

    public static string GetLogFilePath() => LogFile;
}
