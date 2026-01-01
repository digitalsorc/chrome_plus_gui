namespace ChromePlusGUI;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null!;

    private System.Windows.Forms.TableLayoutPanel mainLayout;
    private System.Windows.Forms.TableLayoutPanel executablePanel;
    private System.Windows.Forms.Label executableLabel;
    private System.Windows.Forms.ComboBox executableComboBox;
    private System.Windows.Forms.Button browseButton;
    private System.Windows.Forms.Button detectButton;
    private System.Windows.Forms.Label executablePreviewLabel;
    private System.Windows.Forms.TabControl settingsTabControl;
    private System.Windows.Forms.TabPage portabilityTab;
    private System.Windows.Forms.TabPage tabEnhancementsTab;
    private System.Windows.Forms.TabPage chromeFlagsTab;
    private System.Windows.Forms.TabPage performanceTab;
    private System.Windows.Forms.TabPage securityTab;
    private System.Windows.Forms.CheckBox portabilityCheckBox;
    private System.Windows.Forms.Label memoryLimitLabel;
    private System.Windows.Forms.TextBox tempDirectoryTextBox;
    private System.Windows.Forms.TextBox dataLocationTextBox;
    private System.Windows.Forms.Label tempDirLabel;
    private System.Windows.Forms.Label dataLocationLabel;
    private System.Windows.Forms.CheckBox customTabColorsCheckBox;
    private System.Windows.Forms.CheckBox tabGroupingCheckBox;
    private System.Windows.Forms.CheckBox sessionRestoreCheckBox;
    private System.Windows.Forms.CheckBox wheelSwitchingCheckBox;
    private System.Windows.Forms.TextBox flagOverridesTextBox;
    private System.Windows.Forms.NumericUpDown memoryLimitNumeric;
    private System.Windows.Forms.CheckBox disableCacheCheckBox;
    private System.Windows.Forms.CheckBox disableExtensionsCheckBox;
    private System.Windows.Forms.CheckBox adBlockingCheckBox;
    private System.Windows.Forms.CheckBox trackingPreventionCheckBox;
    private System.Windows.Forms.CheckBox scriptSandboxingCheckBox;
    private System.Windows.Forms.FlowLayoutPanel buttonPanel;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button applyButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.Button toggleLogButton;
    private System.Windows.Forms.Panel logPanel;
    private System.Windows.Forms.TextBox logTextBox;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    private System.Windows.Forms.ErrorProvider errorProvider;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        mainLayout = new System.Windows.Forms.TableLayoutPanel();
        executablePanel = new System.Windows.Forms.TableLayoutPanel();
        executableLabel = new System.Windows.Forms.Label();
        executableComboBox = new System.Windows.Forms.ComboBox();
        browseButton = new System.Windows.Forms.Button();
        detectButton = new System.Windows.Forms.Button();
        executablePreviewLabel = new System.Windows.Forms.Label();
        settingsTabControl = new System.Windows.Forms.TabControl();
        portabilityTab = new System.Windows.Forms.TabPage();
        tempDirLabel = new System.Windows.Forms.Label();
        dataLocationLabel = new System.Windows.Forms.Label();
        tempDirectoryTextBox = new System.Windows.Forms.TextBox();
        dataLocationTextBox = new System.Windows.Forms.TextBox();
        portabilityCheckBox = new System.Windows.Forms.CheckBox();
        tabEnhancementsTab = new System.Windows.Forms.TabPage();
        customTabColorsCheckBox = new System.Windows.Forms.CheckBox();
        tabGroupingCheckBox = new System.Windows.Forms.CheckBox();
        sessionRestoreCheckBox = new System.Windows.Forms.CheckBox();
        wheelSwitchingCheckBox = new System.Windows.Forms.CheckBox();
        chromeFlagsTab = new System.Windows.Forms.TabPage();
        flagOverridesTextBox = new System.Windows.Forms.TextBox();
        performanceTab = new System.Windows.Forms.TabPage();
        memoryLimitLabel = new System.Windows.Forms.Label();
        memoryLimitNumeric = new System.Windows.Forms.NumericUpDown();
        disableCacheCheckBox = new System.Windows.Forms.CheckBox();
        disableExtensionsCheckBox = new System.Windows.Forms.CheckBox();
        securityTab = new System.Windows.Forms.TabPage();
        adBlockingCheckBox = new System.Windows.Forms.CheckBox();
        trackingPreventionCheckBox = new System.Windows.Forms.CheckBox();
        scriptSandboxingCheckBox = new System.Windows.Forms.CheckBox();
        buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
        saveButton = new System.Windows.Forms.Button();
        applyButton = new System.Windows.Forms.Button();
        cancelButton = new System.Windows.Forms.Button();
        resetButton = new System.Windows.Forms.Button();
        toggleLogButton = new System.Windows.Forms.Button();
        logPanel = new System.Windows.Forms.Panel();
        logTextBox = new System.Windows.Forms.TextBox();
        statusStrip = new System.Windows.Forms.StatusStrip();
        statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        errorProvider = new System.Windows.Forms.ErrorProvider(components);
        mainLayout.SuspendLayout();
        executablePanel.SuspendLayout();
        settingsTabControl.SuspendLayout();
        portabilityTab.SuspendLayout();
        tabEnhancementsTab.SuspendLayout();
        chromeFlagsTab.SuspendLayout();
        performanceTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)memoryLimitNumeric).BeginInit();
        securityTab.SuspendLayout();
        buttonPanel.SuspendLayout();
        logPanel.SuspendLayout();
        statusStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        // 
        // mainLayout
        // 
        mainLayout.ColumnCount = 1;
        mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        mainLayout.Controls.Add(executablePanel, 0, 0);
        mainLayout.Controls.Add(settingsTabControl, 0, 1);
        mainLayout.Controls.Add(buttonPanel, 0, 2);
        mainLayout.Controls.Add(logPanel, 0, 3);
        mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
        mainLayout.Location = new System.Drawing.Point(0, 0);
        mainLayout.Name = "mainLayout";
        mainLayout.RowCount = 4;
        mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
        mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
        mainLayout.Size = new System.Drawing.Size(900, 620);
        mainLayout.TabIndex = 0;
        // 
        // executablePanel
        // 
        executablePanel.ColumnCount = 4;
        executablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
        executablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        executablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        executablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        executablePanel.Controls.Add(executableLabel, 0, 0);
        executablePanel.Controls.Add(executablePreviewLabel, 0, 1);
        executablePanel.Controls.Add(executableComboBox, 1, 0);
        executablePanel.Controls.Add(browseButton, 2, 0);
        executablePanel.Controls.Add(detectButton, 3, 0);
        executablePanel.Dock = System.Windows.Forms.DockStyle.Top;
        executablePanel.Location = new System.Drawing.Point(3, 3);
        executablePanel.Name = "executablePanel";
        executablePanel.RowCount = 2;
        executablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        executablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        executablePanel.Size = new System.Drawing.Size(894, 66);
        executablePanel.TabIndex = 0;
        // 
        // executableLabel
        // 
        executableLabel.AutoSize = true;
        executableLabel.Location = new System.Drawing.Point(3, 0);
        executableLabel.Name = "executableLabel";
        executableLabel.Size = new System.Drawing.Size(115, 20);
        executableLabel.TabIndex = 4;
        executableLabel.Text = "Target exe path";
        executableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // executableComboBox
        // 
        executableComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        executableComboBox.FormattingEnabled = true;
        executableComboBox.Location = new System.Drawing.Point(123, 3);
        executableComboBox.Name = "executableComboBox";
        executableComboBox.Size = new System.Drawing.Size(568, 28);
        executableComboBox.TabIndex = 0;
        executableComboBox.SelectedIndexChanged += ExecutableComboBox_SelectedIndexChanged;
        // 
        // browseButton
        // 
        browseButton.Location = new System.Drawing.Point(697, 3);
        browseButton.Name = "browseButton";
        browseButton.Size = new System.Drawing.Size(94, 29);
        browseButton.TabIndex = 1;
        browseButton.Text = "Browse...";
        browseButton.UseVisualStyleBackColor = true;
        browseButton.Click += BrowseButton_Click;
        // 
        // detectButton
        // 
        detectButton.Location = new System.Drawing.Point(797, 3);
        detectButton.Name = "detectButton";
        detectButton.Size = new System.Drawing.Size(94, 29);
        detectButton.TabIndex = 2;
        detectButton.Text = "Detect again";
        detectButton.UseVisualStyleBackColor = true;
        detectButton.Click += DetectButton_Click;
        // 
        // executablePreviewLabel
        // 
        executablePreviewLabel.AutoSize = true;
        executablePanel.SetColumnSpan(executablePreviewLabel, 4);
        executablePreviewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        executablePreviewLabel.Location = new System.Drawing.Point(3, 35);
        executablePreviewLabel.Name = "executablePreviewLabel";
        executablePreviewLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
        executablePreviewLabel.Size = new System.Drawing.Size(888, 31);
        executablePreviewLabel.TabIndex = 3;
        executablePreviewLabel.Text = "No executable selected";
        // 
        // settingsTabControl
        // 
        settingsTabControl.Controls.Add(portabilityTab);
        settingsTabControl.Controls.Add(tabEnhancementsTab);
        settingsTabControl.Controls.Add(chromeFlagsTab);
        settingsTabControl.Controls.Add(performanceTab);
        settingsTabControl.Controls.Add(securityTab);
        settingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        settingsTabControl.Location = new System.Drawing.Point(3, 75);
        settingsTabControl.Name = "settingsTabControl";
        settingsTabControl.SelectedIndex = 0;
        settingsTabControl.Size = new System.Drawing.Size(894, 324);
        settingsTabControl.TabIndex = 1;
        // 
        // portabilityTab
        // 
        portabilityTab.Controls.Add(dataLocationTextBox);
        portabilityTab.Controls.Add(tempDirectoryTextBox);
        portabilityTab.Controls.Add(dataLocationLabel);
        portabilityTab.Controls.Add(tempDirLabel);
        portabilityTab.Controls.Add(portabilityCheckBox);
        portabilityTab.Location = new System.Drawing.Point(4, 29);
        portabilityTab.Name = "portabilityTab";
        portabilityTab.Padding = new System.Windows.Forms.Padding(10);
        portabilityTab.Size = new System.Drawing.Size(886, 291);
        portabilityTab.TabIndex = 0;
        portabilityTab.Text = "Portability";
        portabilityTab.UseVisualStyleBackColor = true;
        // 
        // tempDirLabel
        // 
        tempDirLabel.AutoSize = true;
        tempDirLabel.Location = new System.Drawing.Point(14, 53);
        tempDirLabel.Name = "tempDirLabel";
        tempDirLabel.Size = new System.Drawing.Size(105, 20);
        tempDirLabel.TabIndex = 1;
        tempDirLabel.Text = "Temp directory";
        // 
        // dataLocationLabel
        // 
        dataLocationLabel.AutoSize = true;
        dataLocationLabel.Location = new System.Drawing.Point(14, 97);
        dataLocationLabel.Name = "dataLocationLabel";
        dataLocationLabel.Size = new System.Drawing.Size(98, 20);
        dataLocationLabel.TabIndex = 2;
        dataLocationLabel.Text = "Data location";
        // 
        // tempDirectoryTextBox
        // 
        tempDirectoryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tempDirectoryTextBox.Location = new System.Drawing.Point(147, 50);
        tempDirectoryTextBox.Name = "tempDirectoryTextBox";
        tempDirectoryTextBox.Size = new System.Drawing.Size(716, 27);
        tempDirectoryTextBox.TabIndex = 3;
        // 
        // dataLocationTextBox
        // 
        dataLocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dataLocationTextBox.Location = new System.Drawing.Point(147, 94);
        dataLocationTextBox.Name = "dataLocationTextBox";
        dataLocationTextBox.Size = new System.Drawing.Size(716, 27);
        dataLocationTextBox.TabIndex = 4;
        // 
        // portabilityCheckBox
        // 
        portabilityCheckBox.AutoSize = true;
        portabilityCheckBox.Location = new System.Drawing.Point(14, 15);
        portabilityCheckBox.Name = "portabilityCheckBox";
        portabilityCheckBox.Size = new System.Drawing.Size(164, 24);
        portabilityCheckBox.TabIndex = 0;
        portabilityCheckBox.Text = "Enable portability";
        portabilityCheckBox.UseVisualStyleBackColor = true;
        // 
        // tabEnhancementsTab
        // 
        tabEnhancementsTab.Controls.Add(wheelSwitchingCheckBox);
        tabEnhancementsTab.Controls.Add(sessionRestoreCheckBox);
        tabEnhancementsTab.Controls.Add(tabGroupingCheckBox);
        tabEnhancementsTab.Controls.Add(customTabColorsCheckBox);
        tabEnhancementsTab.Location = new System.Drawing.Point(4, 29);
        tabEnhancementsTab.Name = "tabEnhancementsTab";
        tabEnhancementsTab.Padding = new System.Windows.Forms.Padding(10);
        tabEnhancementsTab.Size = new System.Drawing.Size(886, 291);
        tabEnhancementsTab.TabIndex = 1;
        tabEnhancementsTab.Text = "Tab Enhancements";
        tabEnhancementsTab.UseVisualStyleBackColor = true;
        // 
        // customTabColorsCheckBox
        // 
        customTabColorsCheckBox.AutoSize = true;
        customTabColorsCheckBox.Location = new System.Drawing.Point(13, 15);
        customTabColorsCheckBox.Name = "customTabColorsCheckBox";
        customTabColorsCheckBox.Size = new System.Drawing.Size(163, 24);
        customTabColorsCheckBox.TabIndex = 0;
        customTabColorsCheckBox.Text = "Custom tab colors";
        customTabColorsCheckBox.UseVisualStyleBackColor = true;
        // 
        // tabGroupingCheckBox
        // 
        tabGroupingCheckBox.AutoSize = true;
        tabGroupingCheckBox.Location = new System.Drawing.Point(13, 45);
        tabGroupingCheckBox.Name = "tabGroupingCheckBox";
        tabGroupingCheckBox.Size = new System.Drawing.Size(121, 24);
        tabGroupingCheckBox.TabIndex = 1;
        tabGroupingCheckBox.Text = "Tab grouping";
        tabGroupingCheckBox.UseVisualStyleBackColor = true;
        // 
        // sessionRestoreCheckBox
        // 
        sessionRestoreCheckBox.AutoSize = true;
        sessionRestoreCheckBox.Location = new System.Drawing.Point(13, 75);
        sessionRestoreCheckBox.Name = "sessionRestoreCheckBox";
        sessionRestoreCheckBox.Size = new System.Drawing.Size(185, 24);
        sessionRestoreCheckBox.TabIndex = 2;
        sessionRestoreCheckBox.Text = "Restore previous tabs";
        sessionRestoreCheckBox.UseVisualStyleBackColor = true;
        // 
        // wheelSwitchingCheckBox
        // 
        wheelSwitchingCheckBox.AutoSize = true;
        wheelSwitchingCheckBox.Location = new System.Drawing.Point(13, 105);
        wheelSwitchingCheckBox.Name = "wheelSwitchingCheckBox";
        wheelSwitchingCheckBox.Size = new System.Drawing.Size(237, 24);
        wheelSwitchingCheckBox.TabIndex = 3;
        wheelSwitchingCheckBox.Text = "Mouse wheel tab switching";
        wheelSwitchingCheckBox.UseVisualStyleBackColor = true;
        // 
        // chromeFlagsTab
        // 
        chromeFlagsTab.Controls.Add(flagOverridesTextBox);
        chromeFlagsTab.Location = new System.Drawing.Point(4, 29);
        chromeFlagsTab.Name = "chromeFlagsTab";
        chromeFlagsTab.Padding = new System.Windows.Forms.Padding(10);
        chromeFlagsTab.Size = new System.Drawing.Size(886, 291);
        chromeFlagsTab.TabIndex = 2;
        chromeFlagsTab.Text = "Chrome Flags";
        chromeFlagsTab.UseVisualStyleBackColor = true;
        // 
        // flagOverridesTextBox
        // 
        flagOverridesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        flagOverridesTextBox.Location = new System.Drawing.Point(10, 10);
        flagOverridesTextBox.Multiline = true;
        flagOverridesTextBox.Name = "flagOverridesTextBox";
        flagOverridesTextBox.PlaceholderText = "--enable-features=TabGroups";
        flagOverridesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        flagOverridesTextBox.Size = new System.Drawing.Size(866, 271);
        flagOverridesTextBox.TabIndex = 0;
        // 
        // performanceTab
        // 
        performanceTab.Controls.Add(memoryLimitLabel);
        performanceTab.Controls.Add(disableExtensionsCheckBox);
        performanceTab.Controls.Add(disableCacheCheckBox);
        performanceTab.Controls.Add(memoryLimitNumeric);
        performanceTab.Location = new System.Drawing.Point(4, 29);
        performanceTab.Name = "performanceTab";
        performanceTab.Padding = new System.Windows.Forms.Padding(10);
        performanceTab.Size = new System.Drawing.Size(886, 291);
        performanceTab.TabIndex = 3;
        performanceTab.Text = "Performance";
        performanceTab.UseVisualStyleBackColor = true;
        // 
        // memoryLimitLabel
        // 
        memoryLimitLabel.AutoSize = true;
        memoryLimitLabel.Location = new System.Drawing.Point(13, 0);
        memoryLimitLabel.Name = "memoryLimitLabel";
        memoryLimitLabel.Size = new System.Drawing.Size(235, 20);
        memoryLimitLabel.TabIndex = 3;
        memoryLimitLabel.Text = "Memory limit (MB, 0 = unlimited)";
        // 
        // memoryLimitNumeric
        // 
        memoryLimitNumeric.Location = new System.Drawing.Point(13, 18);
        memoryLimitNumeric.Maximum = new decimal(new int[] { 40960, 0, 0, 0 });
        memoryLimitNumeric.Name = "memoryLimitNumeric";
        memoryLimitNumeric.Size = new System.Drawing.Size(180, 27);
        memoryLimitNumeric.TabIndex = 0;
        memoryLimitNumeric.ThousandsSeparator = true;
        // 
        // disableCacheCheckBox
        // 
        disableCacheCheckBox.AutoSize = true;
        disableCacheCheckBox.Location = new System.Drawing.Point(13, 58);
        disableCacheCheckBox.Name = "disableCacheCheckBox";
        disableCacheCheckBox.Size = new System.Drawing.Size(132, 24);
        disableCacheCheckBox.TabIndex = 1;
        disableCacheCheckBox.Text = "Disable cache";
        disableCacheCheckBox.UseVisualStyleBackColor = true;
        // 
        // disableExtensionsCheckBox
        // 
        disableExtensionsCheckBox.AutoSize = true;
        disableExtensionsCheckBox.Location = new System.Drawing.Point(13, 88);
        disableExtensionsCheckBox.Name = "disableExtensionsCheckBox";
        disableExtensionsCheckBox.Size = new System.Drawing.Size(152, 24);
        disableExtensionsCheckBox.TabIndex = 2;
        disableExtensionsCheckBox.Text = "Disable extensions";
        disableExtensionsCheckBox.UseVisualStyleBackColor = true;
        // 
        // securityTab
        // 
        securityTab.Controls.Add(scriptSandboxingCheckBox);
        securityTab.Controls.Add(trackingPreventionCheckBox);
        securityTab.Controls.Add(adBlockingCheckBox);
        securityTab.Location = new System.Drawing.Point(4, 29);
        securityTab.Name = "securityTab";
        securityTab.Padding = new System.Windows.Forms.Padding(10);
        securityTab.Size = new System.Drawing.Size(886, 291);
        securityTab.TabIndex = 4;
        securityTab.Text = "Security";
        securityTab.UseVisualStyleBackColor = true;
        // 
        // adBlockingCheckBox
        // 
        adBlockingCheckBox.AutoSize = true;
        adBlockingCheckBox.Location = new System.Drawing.Point(13, 15);
        adBlockingCheckBox.Name = "adBlockingCheckBox";
        adBlockingCheckBox.Size = new System.Drawing.Size(166, 24);
        adBlockingCheckBox.TabIndex = 0;
        adBlockingCheckBox.Text = "Enable ad blocking";
        adBlockingCheckBox.UseVisualStyleBackColor = true;
        // 
        // trackingPreventionCheckBox
        // 
        trackingPreventionCheckBox.AutoSize = true;
        trackingPreventionCheckBox.Location = new System.Drawing.Point(13, 45);
        trackingPreventionCheckBox.Name = "trackingPreventionCheckBox";
        trackingPreventionCheckBox.Size = new System.Drawing.Size(170, 24);
        trackingPreventionCheckBox.TabIndex = 1;
        trackingPreventionCheckBox.Text = "Tracking prevention";
        trackingPreventionCheckBox.UseVisualStyleBackColor = true;
        // 
        // scriptSandboxingCheckBox
        // 
        scriptSandboxingCheckBox.AutoSize = true;
        scriptSandboxingCheckBox.Location = new System.Drawing.Point(13, 75);
        scriptSandboxingCheckBox.Name = "scriptSandboxingCheckBox";
        scriptSandboxingCheckBox.Size = new System.Drawing.Size(145, 24);
        scriptSandboxingCheckBox.TabIndex = 2;
        scriptSandboxingCheckBox.Text = "Script sandboxing";
        scriptSandboxingCheckBox.UseVisualStyleBackColor = true;
        // 
        // buttonPanel
        // 
        buttonPanel.AutoSize = true;
        buttonPanel.Controls.Add(saveButton);
        buttonPanel.Controls.Add(applyButton);
        buttonPanel.Controls.Add(cancelButton);
        buttonPanel.Controls.Add(resetButton);
        buttonPanel.Controls.Add(toggleLogButton);
        buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
        buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        buttonPanel.Location = new System.Drawing.Point(3, 405);
        buttonPanel.Name = "buttonPanel";
        buttonPanel.Size = new System.Drawing.Size(894, 37);
        buttonPanel.TabIndex = 2;
        // 
        // saveButton
        // 
        saveButton.Location = new System.Drawing.Point(774, 3);
        saveButton.Name = "saveButton";
        saveButton.Size = new System.Drawing.Size(117, 29);
        saveButton.TabIndex = 0;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += SaveButton_Click;
        // 
        // applyButton
        // 
        applyButton.Location = new System.Drawing.Point(651, 3);
        applyButton.Name = "applyButton";
        applyButton.Size = new System.Drawing.Size(117, 29);
        applyButton.TabIndex = 1;
        applyButton.Text = "Apply";
        applyButton.UseVisualStyleBackColor = true;
        applyButton.Click += ApplyButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Location = new System.Drawing.Point(528, 3);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new System.Drawing.Size(117, 29);
        cancelButton.TabIndex = 2;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += CancelButton_Click;
        // 
        // resetButton
        // 
        resetButton.Location = new System.Drawing.Point(405, 3);
        resetButton.Name = "resetButton";
        resetButton.Size = new System.Drawing.Size(117, 29);
        resetButton.TabIndex = 3;
        resetButton.Text = "Reset to defaults";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += ResetButton_Click;
        // 
        // toggleLogButton
        // 
        toggleLogButton.Location = new System.Drawing.Point(282, 3);
        toggleLogButton.Name = "toggleLogButton";
        toggleLogButton.Size = new System.Drawing.Size(117, 29);
        toggleLogButton.TabIndex = 4;
        toggleLogButton.Text = "Show Log";
        toggleLogButton.UseVisualStyleBackColor = true;
        toggleLogButton.Click += ToggleLogButton_Click;
        // 
        // logPanel
        // 
        logPanel.Controls.Add(logTextBox);
        logPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        logPanel.Location = new System.Drawing.Point(3, 448);
        logPanel.Name = "logPanel";
        logPanel.Size = new System.Drawing.Size(894, 169);
        logPanel.TabIndex = 3;
        logPanel.Visible = false;
        // 
        // logTextBox
        // 
        logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        logTextBox.Location = new System.Drawing.Point(0, 0);
        logTextBox.Multiline = true;
        logTextBox.Name = "logTextBox";
        logTextBox.ReadOnly = true;
        logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        logTextBox.Size = new System.Drawing.Size(894, 169);
        logTextBox.TabIndex = 0;
        // 
        // statusStrip
        // 
        statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
        statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel });
        statusStrip.Location = new System.Drawing.Point(0, 620);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new System.Drawing.Size(900, 26);
        statusStrip.TabIndex = 1;
        statusStrip.Text = "statusStrip1";
        // 
        // statusLabel
        // 
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new System.Drawing.Size(132, 20);
        statusLabel.Text = "No settings loaded";
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(900, 646);
        Controls.Add(mainLayout);
        Controls.Add(statusStrip);
        MinimumSize = new System.Drawing.Size(720, 500);
        Name = "Form1";
        Text = "Chrome Plus GUI Config Manager";
        mainLayout.ResumeLayout(false);
        mainLayout.PerformLayout();
        executablePanel.ResumeLayout(false);
        executablePanel.PerformLayout();
        settingsTabControl.ResumeLayout(false);
        portabilityTab.ResumeLayout(false);
        portabilityTab.PerformLayout();
        tabEnhancementsTab.ResumeLayout(false);
        tabEnhancementsTab.PerformLayout();
        chromeFlagsTab.ResumeLayout(false);
        chromeFlagsTab.PerformLayout();
        performanceTab.ResumeLayout(false);
        performanceTab.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)memoryLimitNumeric).EndInit();
        securityTab.ResumeLayout(false);
        securityTab.PerformLayout();
        buttonPanel.ResumeLayout(false);
        logPanel.ResumeLayout(false);
        logPanel.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
