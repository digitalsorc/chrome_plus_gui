using System.Linq;
using System.Text.Json;
using ChromePlusGUI.Models;

namespace ChromePlusGUI.Services;

public class SettingsPersistence
{
    private readonly ExecutableDetector _detector;
    private readonly JsonSerializerOptions _serializerOptions = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public SettingsPersistence(ExecutableDetector detector)
    {
        _detector = detector;
    }

    private string SettingsDirectory =>
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ChromePlusGUI");

    private string SettingsFilePath => Path.Combine(SettingsDirectory, "settings.json");

    public string GetSettingsFilePath() => SettingsFilePath;

    public AppSettings Load()
    {
        try
        {
            Directory.CreateDirectory(SettingsDirectory);
            if (!File.Exists(SettingsFilePath))
            {
                var defaults = AppSettings.CreateDefault();
                var detected = _detector.Detect().FirstOrDefault();
                if (detected != null)
                {
                    defaults.ExecutablePath = detected.Path;
                    defaults.TargetExecutable = detected.Name;
                }
                Save(defaults);
                return defaults;
            }

            var json = File.ReadAllText(SettingsFilePath);
            var settings = JsonSerializer.Deserialize<AppSettings>(json, _serializerOptions);
            if (settings is null)
            {
                throw new InvalidOperationException("Settings file is empty or invalid.");
            }

            return settings;
        }
        catch (Exception ex)
        {
            AppLogger.Error("Failed to load settings, using defaults.", ex);
            BackupCorruptFile();
            var defaults = AppSettings.CreateDefault();
            Save(defaults);
            return defaults;
        }
    }

    public bool Save(AppSettings settings)
    {
        if (!Validate(settings, out var errors))
        {
            AppLogger.Info($"Settings not saved: {string.Join("; ", errors)}");
            return false;
        }

        settings.LastModified = DateTimeOffset.UtcNow;
        Directory.CreateDirectory(SettingsDirectory);
        var tempPath = Path.Combine(SettingsDirectory, $"settings_{Guid.NewGuid():N}.tmp");
        var json = JsonSerializer.Serialize(settings, _serializerOptions);

        File.WriteAllText(tempPath, json);
        File.Move(tempPath, SettingsFilePath, true);
        AppLogger.Info($"Settings saved to {SettingsFilePath}");
        return true;
    }

    public bool Validate(AppSettings settings, out List<string> errors)
    {
        errors = new List<string>();
        if (string.IsNullOrWhiteSpace(settings.TargetExecutable))
        {
            errors.Add("Target executable is required.");
        }

        if (!_detector.IsExecutableValid(settings.ExecutablePath))
        {
            errors.Add("Executable path is invalid or missing.");
        }

        if (settings.Settings.PortabilityMode.Enabled)
        {
            if (string.IsNullOrWhiteSpace(settings.Settings.PortabilityMode.TempDirectory))
            {
                errors.Add("Temp directory is required when portability mode is enabled.");
            }

            if (string.IsNullOrWhiteSpace(settings.Settings.PortabilityMode.DataLocation))
            {
                errors.Add("Data location is required when portability mode is enabled.");
            }
        }

        if (settings.Settings.Performance.MemoryLimitMb < 0)
        {
            errors.Add("Memory limit must be zero or positive.");
        }

        return errors.Count == 0;
    }

    private void BackupCorruptFile()
    {
        try
        {
            if (!File.Exists(SettingsFilePath))
            {
                return;
            }

            var backupName = $"settings_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
            var backupPath = Path.Combine(SettingsDirectory, backupName);
            File.Copy(SettingsFilePath, backupPath, true);
            AppLogger.Info($"Backed up invalid settings to {backupPath}");
        }
        catch (Exception ex)
        {
            AppLogger.Error("Failed to backup invalid settings file.", ex);
        }
    }
}
