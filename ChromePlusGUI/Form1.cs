using System.Diagnostics;
using System.Linq;
using ChromePlusGUI.Models;
using ChromePlusGUI.Services;

namespace ChromePlusGUI;

public partial class Form1 : Form
{
    private readonly ExecutableDetector _detector = new();
    private readonly SettingsPersistence _persistence;
    private AppSettings _currentSettings = AppSettings.CreateDefault();

    public Form1()
    {
        InitializeComponent();
        _persistence = new SettingsPersistence(_detector);
        AppLogger.EntryAdded += AppendLog;
        AppLogger.Info("Chrome Plus GUI Manager started.");
        LoadSettings();
        PopulateDetectedExecutables(_currentSettings.ExecutablePath);
    }

    private void LoadSettings()
    {
        _currentSettings = _persistence.Load();
        BindSettingsToUi(_currentSettings);
        statusLabel.Text = $"Loaded: {_currentSettings.LastModified:u}";
        AppLogger.Info($"Loaded settings from {_persistence.GetSettingsFilePath()}");
    }

    private void PopulateDetectedExecutables(string? preferredPath)
    {
        var detected = _detector.Detect(preferredPath);
        AppLogger.Info($"Detected {detected.Count} executable candidate(s).");
        executableComboBox.Items.Clear();
        foreach (var info in detected)
        {
            executableComboBox.Items.Add(info);
        }

        if (!string.IsNullOrWhiteSpace(preferredPath))
        {
            executableComboBox.Text = preferredPath;
        }
        else if (detected.Count > 0)
        {
            executableComboBox.SelectedIndex = 0;
        }

        UpdateExecutablePreview();
    }

    private void BindSettingsToUi(AppSettings settings)
    {
        executableComboBox.Text = settings.ExecutablePath;
        portabilityCheckBox.Checked = settings.Settings.PortabilityMode.Enabled;
        tempDirectoryTextBox.Text = settings.Settings.PortabilityMode.TempDirectory;
        dataLocationTextBox.Text = settings.Settings.PortabilityMode.DataLocation;

        customTabColorsCheckBox.Checked = settings.Settings.TabEnhancements.CustomTabColors;
        tabGroupingCheckBox.Checked = settings.Settings.TabEnhancements.TabGrouping;
        sessionRestoreCheckBox.Checked = settings.Settings.TabEnhancements.SessionRestore;
        wheelSwitchingCheckBox.Checked = settings.Settings.TabEnhancements.WheelSwitching;

        flagOverridesTextBox.Lines = settings.Settings.ChromeFlags.Flags.ToArray();

        memoryLimitNumeric.Value = Math.Min(memoryLimitNumeric.Maximum,
            Math.Max(memoryLimitNumeric.Minimum, settings.Settings.Performance.MemoryLimitMb));
        disableCacheCheckBox.Checked = settings.Settings.Performance.DisableCache;
        disableExtensionsCheckBox.Checked = settings.Settings.Performance.DisableExtensions;

        adBlockingCheckBox.Checked = settings.Settings.Security.AdBlocking;
        trackingPreventionCheckBox.Checked = settings.Settings.Security.TrackingPrevention;
        scriptSandboxingCheckBox.Checked = settings.Settings.Security.ScriptSandboxing;
    }

    private AppSettings ReadSettingsFromUi()
    {
        var settings = new AppSettings
        {
            ExecutablePath = executableComboBox.Text.Trim(),
            TargetExecutable = Path.GetFileName(executableComboBox.Text.Trim()),
            Settings = new SettingsPayload
            {
                PortabilityMode = new PortabilitySettings
                {
                    Enabled = portabilityCheckBox.Checked,
                    TempDirectory = tempDirectoryTextBox.Text.Trim(),
                    DataLocation = dataLocationTextBox.Text.Trim()
                },
                TabEnhancements = new TabEnhancementsSettings
                {
                    CustomTabColors = customTabColorsCheckBox.Checked,
                    TabGrouping = tabGroupingCheckBox.Checked,
                    SessionRestore = sessionRestoreCheckBox.Checked,
                    WheelSwitching = wheelSwitchingCheckBox.Checked
                },
                ChromeFlags = new ChromeFlagsSettings
                {
                    Flags = flagOverridesTextBox.Lines
                        .Select(l => l.Trim())
                        .Where(l => !string.IsNullOrWhiteSpace(l))
                        .ToList()
                },
                Performance = new PerformanceSettings
                {
                    MemoryLimitMb = (int)memoryLimitNumeric.Value,
                    DisableCache = disableCacheCheckBox.Checked,
                    DisableExtensions = disableExtensionsCheckBox.Checked
                },
                Security = new SecuritySettings
                {
                    AdBlocking = adBlockingCheckBox.Checked,
                    TrackingPrevention = trackingPreventionCheckBox.Checked,
                    ScriptSandboxing = scriptSandboxingCheckBox.Checked
                }
            }
        };

        return settings;
    }

    private void SaveButton_Click(object? sender, EventArgs e)
    {
        SaveSettings();
    }

    private void ApplyButton_Click(object? sender, EventArgs e)
    {
        SaveSettings();
    }

    private void CancelButton_Click(object? sender, EventArgs e)
    {
        LoadSettings();
        AppLogger.Info("Cancelled changes and reloaded settings.");
    }

    private void ResetButton_Click(object? sender, EventArgs e)
    {
        var defaults = AppSettings.CreateDefault();
        defaults.ExecutablePath = executableComboBox.Text.Trim();
        BindSettingsToUi(defaults);
        AppLogger.Info("Reset settings to defaults (unsaved).");
    }

    private void DetectButton_Click(object? sender, EventArgs e)
    {
        PopulateDetectedExecutables(executableComboBox.Text);
        AppLogger.Info("Ran executable detection.");
    }

    private void BrowseButton_Click(object? sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "Executable|*.exe",
            Title = "Select Chrome or Comet executable"
        };
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            executableComboBox.Text = dialog.FileName;
            UpdateExecutablePreview();
            AppLogger.Info($"User selected executable: {dialog.FileName}");
        }
    }

    private void SaveSettings()
    {
        var settings = ReadSettingsFromUi();
        if (!ValidateSettings(settings, out var errors))
        {
            var message = string.Join(Environment.NewLine, errors);
            MessageBox.Show(this, message, "Validation failed", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            AppLogger.Info($"Validation failed: {message}");
            return;
        }

        _currentSettings = settings;
        var saved = _persistence.Save(_currentSettings);
        if (saved)
        {
            statusLabel.Text = $"Saved: {_currentSettings.LastModified:u}";
            AppLogger.Info("Settings saved successfully.");
        }
    }

    private bool ValidateSettings(AppSettings settings, out List<string> errors)
    {
        errorProvider.Clear();
        var valid = _persistence.Validate(settings, out errors);

        if (!_detector.IsExecutableValid(settings.ExecutablePath))
        {
            errorProvider.SetError(executableComboBox, "Select a valid chrome.exe or comet.exe");
        }

        if (settings.Settings.PortabilityMode.Enabled)
        {
            if (string.IsNullOrWhiteSpace(settings.Settings.PortabilityMode.TempDirectory))
            {
                errorProvider.SetError(tempDirectoryTextBox, "Temp directory is required");
            }

            if (string.IsNullOrWhiteSpace(settings.Settings.PortabilityMode.DataLocation))
            {
                errorProvider.SetError(dataLocationTextBox, "Data location is required");
            }
        }

        if (settings.Settings.Performance.MemoryLimitMb < 0)
        {
            errorProvider.SetError(memoryLimitNumeric, "Memory limit must be >= 0");
        }

        return valid;
    }

    private void ExecutableComboBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (executableComboBox.SelectedItem is ExecutableInfo info)
        {
            executableComboBox.Text = info.Path;
        }

        UpdateExecutablePreview();
    }

    private void UpdateExecutablePreview()
    {
        var selectedPath = executableComboBox.Text;
        if (_detector.IsExecutableValid(selectedPath))
        {
            var version = FileVersionInfo.GetVersionInfo(selectedPath).FileVersion ?? "Unknown";
            executablePreviewLabel.Text = $"{selectedPath} (v{version})";
        }
        else
        {
            executablePreviewLabel.Text = "No valid executable selected.";
        }
    }

    private void AppendLog(string message)
    {
        if (InvokeRequired)
        {
            BeginInvoke(new Action<string>(AppendLog), message);
            return;
        }

        logTextBox.AppendText(message + Environment.NewLine);
    }

    private void ToggleLogButton_Click(object? sender, EventArgs e)
    {
        logPanel.Visible = !logPanel.Visible;
        toggleLogButton.Text = logPanel.Visible ? "Hide Log" : "Show Log";
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        AppLogger.Info("Chrome Plus GUI Manager closed.");
        AppLogger.EntryAdded -= AppendLog;
    }
}
