using System.Text.Json.Serialization;

namespace ChromePlusGUI.Models;

public class AppSettings
{
    public string TargetExecutable { get; set; } = "chrome.exe";
    public string ExecutablePath { get; set; } = string.Empty;
    public SettingsPayload Settings { get; set; } = new();
    public DateTimeOffset LastModified { get; set; } = DateTimeOffset.UtcNow;
    public string Version { get; set; } = "1.0";

    public static AppSettings CreateDefault()
    {
        return new AppSettings
        {
            Settings = new SettingsPayload
            {
                PortabilityMode = new PortabilitySettings
                {
                    Enabled = false,
                    TempDirectory = "%APPDATA%\\ChromePlusGUI\\Temp",
                    DataLocation = "%APPDATA%\\ChromePlusGUI\\Data"
                },
                TabEnhancements = new TabEnhancementsSettings
                {
                    CustomTabColors = false,
                    TabGrouping = true,
                    SessionRestore = true,
                    WheelSwitching = true
                },
                ChromeFlags = new ChromeFlagsSettings
                {
                    Flags = new List<string>()
                },
                Performance = new PerformanceSettings
                {
                    MemoryLimitMb = 0,
                    DisableCache = false,
                    DisableExtensions = false
                },
                Security = new SecuritySettings
                {
                    AdBlocking = false,
                    TrackingPrevention = false,
                    ScriptSandboxing = true
                }
            }
        };
    }
}

public class SettingsPayload
{
    public PortabilitySettings PortabilityMode { get; set; } = new();
    public TabEnhancementsSettings TabEnhancements { get; set; } = new();
    public ChromeFlagsSettings ChromeFlags { get; set; } = new();
    public PerformanceSettings Performance { get; set; } = new();
    public SecuritySettings Security { get; set; } = new();
}

public class PortabilitySettings
{
    public bool Enabled { get; set; }
    public string TempDirectory { get; set; } = string.Empty;
    public string DataLocation { get; set; } = string.Empty;
}

public class TabEnhancementsSettings
{
    public bool CustomTabColors { get; set; }
    public bool TabGrouping { get; set; }
    public bool SessionRestore { get; set; }
    public bool WheelSwitching { get; set; }
}

public class ChromeFlagsSettings
{
    public List<string> Flags { get; set; } = new();
}

public class PerformanceSettings
{
    public int MemoryLimitMb { get; set; }
    public bool DisableCache { get; set; }
    public bool DisableExtensions { get; set; }
}

public class SecuritySettings
{
    public bool AdBlocking { get; set; }
    public bool TrackingPrevention { get; set; }
    public bool ScriptSandboxing { get; set; }
}
