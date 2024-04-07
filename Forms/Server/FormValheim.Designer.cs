namespace Game_Server_Manager.Forms;

partial class FormValheim
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panelTopBar = new Panel();
        lblServerPathInfo = new Label();
        panelServerUsage = new Panel();
        progressBarRAM = new ProgressBar();
        lblRAMUsageInfo = new Label();
        lblRAMUsage = new Label();
        lblCPUUsageInfo = new Label();
        lblCPUUsage = new Label();
        lblServerPath = new Label();
        lblServerRunning = new Label();
        lblServerRunningInfo = new Label();
        lblServerInstalledInfo = new Label();
        lblServerInstalled = new Label();
        btnInstallServer = new FontAwesome.Sharp.IconButton();
        btnStartServer = new FontAwesome.Sharp.IconButton();
        btnStopServer = new FontAwesome.Sharp.IconButton();
        btnOpenLogFile = new FontAwesome.Sharp.IconButton();
        btnOpenServerDir = new FontAwesome.Sharp.IconButton();
        btnUninstallServer = new FontAwesome.Sharp.IconButton();
        panelServerSettings = new Panel();
        lblPresetHammer = new Label();
        lblPresetImmersive = new Label();
        lblPresetHardcore = new Label();
        lblPresetHard = new Label();
        lblPresetNormal = new Label();
        lblPresetEasy = new Label();
        lblPresetCasual = new Label();
        trackBarPreset = new TrackBar();
        cbLogFile = new CheckBox();
        cbPublic = new CheckBox();
        cbCrossplay = new CheckBox();
        lblPreset = new Label();
        tbBackupLongInfo = new TextBox();
        label2 = new Label();
        tbBackupShortInfo = new TextBox();
        blblBackupShort = new Label();
        tbServerSaveIntervalInfo = new TextBox();
        lblServerSaveInterval = new Label();
        tbServerSaveDirInfo = new TextBox();
        lblServerSaveDir = new Label();
        tbServerBackupsInfo = new TextBox();
        lblServerBackups = new Label();
        tbServerWorldInfo = new TextBox();
        lblServerWorld = new Label();
        tbServerPortInfo = new TextBox();
        tbServerIPInfo = new TextBox();
        tbServerPasswordInfo = new TextBox();
        tbServerNameInfo = new TextBox();
        lblServerPort = new Label();
        lblServerIP = new Label();
        lblServerPassword = new Label();
        lblServerName = new Label();
        panelServerSettingsTop = new Panel();
        label3 = new Label();
        label1 = new Label();
        panelTopBar.SuspendLayout();
        panelServerUsage.SuspendLayout();
        panelServerSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)trackBarPreset).BeginInit();
        panelServerSettingsTop.SuspendLayout();
        SuspendLayout();
        // 
        // panelTopBar
        // 
        panelTopBar.Controls.Add(lblServerPathInfo);
        panelTopBar.Controls.Add(panelServerUsage);
        panelTopBar.Controls.Add(lblServerPath);
        panelTopBar.Controls.Add(lblServerRunning);
        panelTopBar.Controls.Add(lblServerRunningInfo);
        panelTopBar.Controls.Add(lblServerInstalledInfo);
        panelTopBar.Controls.Add(lblServerInstalled);
        panelTopBar.Dock = DockStyle.Top;
        panelTopBar.Location = new Point(0, 0);
        panelTopBar.Name = "panelTopBar";
        panelTopBar.Size = new Size(880, 84);
        panelTopBar.TabIndex = 0;
        // 
        // lblServerPathInfo
        // 
        lblServerPathInfo.AutoSize = true;
        lblServerPathInfo.BackColor = Color.Transparent;
        lblServerPathInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPathInfo.ForeColor = Color.White;
        lblServerPathInfo.Location = new Point(94, 51);
        lblServerPathInfo.Name = "lblServerPathInfo";
        lblServerPathInfo.Size = new Size(38, 17);
        lblServerPathInfo.TabIndex = 5;
        lblServerPathInfo.Text = "C:\\...";
        // 
        // panelServerUsage
        // 
        panelServerUsage.Controls.Add(progressBarRAM);
        panelServerUsage.Controls.Add(lblRAMUsageInfo);
        panelServerUsage.Controls.Add(lblRAMUsage);
        panelServerUsage.Controls.Add(lblCPUUsageInfo);
        panelServerUsage.Controls.Add(lblCPUUsage);
        panelServerUsage.Location = new Point(479, 9);
        panelServerUsage.Name = "panelServerUsage";
        panelServerUsage.Size = new Size(373, 55);
        panelServerUsage.TabIndex = 7;
        // 
        // progressBarRAM
        // 
        progressBarRAM.ForeColor = Color.Firebrick;
        progressBarRAM.Location = new Point(222, 32);
        progressBarRAM.Name = "progressBarRAM";
        progressBarRAM.Size = new Size(142, 15);
        progressBarRAM.Step = 1;
        progressBarRAM.TabIndex = 17;
        // 
        // lblRAMUsageInfo
        // 
        lblRAMUsageInfo.AutoSize = true;
        lblRAMUsageInfo.BackColor = Color.Transparent;
        lblRAMUsageInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsageInfo.ForeColor = Color.White;
        lblRAMUsageInfo.Location = new Point(87, 32);
        lblRAMUsageInfo.Name = "lblRAMUsageInfo";
        lblRAMUsageInfo.Size = new Size(84, 17);
        lblRAMUsageInfo.TabIndex = 16;
        lblRAMUsageInfo.Text = "0 MB / 0 MB";
        // 
        // lblRAMUsage
        // 
        lblRAMUsage.AutoSize = true;
        lblRAMUsage.BackColor = Color.Transparent;
        lblRAMUsage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsage.ForeColor = Color.White;
        lblRAMUsage.Location = new Point(3, 32);
        lblRAMUsage.Name = "lblRAMUsage";
        lblRAMUsage.Size = new Size(86, 17);
        lblRAMUsage.TabIndex = 15;
        lblRAMUsage.Text = "RAM Usage: ";
        // 
        // lblCPUUsageInfo
        // 
        lblCPUUsageInfo.AutoSize = true;
        lblCPUUsageInfo.BackColor = Color.Transparent;
        lblCPUUsageInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblCPUUsageInfo.ForeColor = Color.White;
        lblCPUUsageInfo.Location = new Point(87, 7);
        lblCPUUsageInfo.Name = "lblCPUUsageInfo";
        lblCPUUsageInfo.Size = new Size(44, 17);
        lblCPUUsageInfo.TabIndex = 14;
        lblCPUUsageInfo.Text = "0.00%";
        lblCPUUsageInfo.Visible = false;
        // 
        // lblCPUUsage
        // 
        lblCPUUsage.AutoSize = true;
        lblCPUUsage.BackColor = Color.Transparent;
        lblCPUUsage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblCPUUsage.ForeColor = Color.White;
        lblCPUUsage.Location = new Point(7, 7);
        lblCPUUsage.Name = "lblCPUUsage";
        lblCPUUsage.Size = new Size(82, 17);
        lblCPUUsage.TabIndex = 13;
        lblCPUUsage.Text = "CPU Usage: ";
        lblCPUUsage.Visible = false;
        // 
        // lblServerPath
        // 
        lblServerPath.AutoSize = true;
        lblServerPath.BackColor = Color.Transparent;
        lblServerPath.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPath.ForeColor = Color.White;
        lblServerPath.Location = new Point(12, 51);
        lblServerPath.Name = "lblServerPath";
        lblServerPath.Size = new Size(83, 17);
        lblServerPath.TabIndex = 4;
        lblServerPath.Text = "Server Path:";
        // 
        // lblServerRunning
        // 
        lblServerRunning.AutoSize = true;
        lblServerRunning.BackColor = Color.Transparent;
        lblServerRunning.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerRunning.ForeColor = Color.White;
        lblServerRunning.Location = new Point(28, 30);
        lblServerRunning.Name = "lblServerRunning";
        lblServerRunning.Size = new Size(64, 17);
        lblServerRunning.TabIndex = 3;
        lblServerRunning.Text = "Running:";
        // 
        // lblServerRunningInfo
        // 
        lblServerRunningInfo.AutoSize = true;
        lblServerRunningInfo.BackColor = Color.Transparent;
        lblServerRunningInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerRunningInfo.ForeColor = Color.White;
        lblServerRunningInfo.Location = new Point(94, 30);
        lblServerRunningInfo.Name = "lblServerRunningInfo";
        lblServerRunningInfo.Size = new Size(51, 17);
        lblServerRunningInfo.TabIndex = 2;
        lblServerRunningInfo.Text = "Offline";
        // 
        // lblServerInstalledInfo
        // 
        lblServerInstalledInfo.AutoSize = true;
        lblServerInstalledInfo.BackColor = Color.Transparent;
        lblServerInstalledInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerInstalledInfo.ForeColor = Color.White;
        lblServerInstalledInfo.Location = new Point(94, 9);
        lblServerInstalledInfo.Name = "lblServerInstalledInfo";
        lblServerInstalledInfo.Size = new Size(26, 17);
        lblServerInstalledInfo.TabIndex = 1;
        lblServerInstalledInfo.Text = "No";
        // 
        // lblServerInstalled
        // 
        lblServerInstalled.AutoSize = true;
        lblServerInstalled.BackColor = Color.Transparent;
        lblServerInstalled.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerInstalled.ForeColor = Color.White;
        lblServerInstalled.Location = new Point(26, 9);
        lblServerInstalled.Name = "lblServerInstalled";
        lblServerInstalled.Size = new Size(65, 17);
        lblServerInstalled.TabIndex = 0;
        lblServerInstalled.Text = "Installed:";
        // 
        // btnInstallServer
        // 
        btnInstallServer.BackColor = Color.Transparent;
        btnInstallServer.FlatAppearance.BorderSize = 0;
        btnInstallServer.FlatStyle = FlatStyle.Flat;
        btnInstallServer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnInstallServer.ForeColor = Color.White;
        btnInstallServer.IconChar = FontAwesome.Sharp.IconChar.Download;
        btnInstallServer.IconColor = Color.White;
        btnInstallServer.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnInstallServer.IconSize = 30;
        btnInstallServer.ImageAlign = ContentAlignment.MiddleLeft;
        btnInstallServer.Location = new Point(13, 433);
        btnInstallServer.Name = "btnInstallServer";
        btnInstallServer.Size = new Size(160, 40);
        btnInstallServer.TabIndex = 1;
        btnInstallServer.Text = "Install   ";
        btnInstallServer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnInstallServer.UseVisualStyleBackColor = false;
        btnInstallServer.Click += btnInstallServer_Click;
        // 
        // btnStartServer
        // 
        btnStartServer.BackColor = Color.Transparent;
        btnStartServer.FlatAppearance.BorderSize = 0;
        btnStartServer.FlatStyle = FlatStyle.Flat;
        btnStartServer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnStartServer.ForeColor = Color.White;
        btnStartServer.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
        btnStartServer.IconColor = Color.White;
        btnStartServer.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnStartServer.IconSize = 30;
        btnStartServer.Location = new Point(179, 433);
        btnStartServer.Name = "btnStartServer";
        btnStartServer.Size = new Size(160, 40);
        btnStartServer.TabIndex = 2;
        btnStartServer.Text = "Start Server";
        btnStartServer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnStartServer.UseVisualStyleBackColor = false;
        btnStartServer.Click += btnStartServer_Click;
        // 
        // btnStopServer
        // 
        btnStopServer.BackColor = Color.Transparent;
        btnStopServer.FlatAppearance.BorderSize = 0;
        btnStopServer.FlatStyle = FlatStyle.Flat;
        btnStopServer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnStopServer.ForeColor = Color.White;
        btnStopServer.IconChar = FontAwesome.Sharp.IconChar.CircleStop;
        btnStopServer.IconColor = Color.White;
        btnStopServer.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnStopServer.IconSize = 30;
        btnStopServer.Location = new Point(179, 476);
        btnStopServer.Name = "btnStopServer";
        btnStopServer.Size = new Size(160, 40);
        btnStopServer.TabIndex = 3;
        btnStopServer.Text = "Stop Server";
        btnStopServer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnStopServer.UseVisualStyleBackColor = false;
        btnStopServer.Click += btnStopServer_Click;
        // 
        // btnOpenLogFile
        // 
        btnOpenLogFile.BackColor = Color.Transparent;
        btnOpenLogFile.FlatAppearance.BorderSize = 0;
        btnOpenLogFile.FlatStyle = FlatStyle.Flat;
        btnOpenLogFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnOpenLogFile.ForeColor = Color.White;
        btnOpenLogFile.IconChar = FontAwesome.Sharp.IconChar.BarChart;
        btnOpenLogFile.IconColor = Color.White;
        btnOpenLogFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnOpenLogFile.IconSize = 30;
        btnOpenLogFile.ImageAlign = ContentAlignment.MiddleLeft;
        btnOpenLogFile.Location = new Point(345, 433);
        btnOpenLogFile.Name = "btnOpenLogFile";
        btnOpenLogFile.Size = new Size(160, 40);
        btnOpenLogFile.TabIndex = 4;
        btnOpenLogFile.Text = "Open Log";
        btnOpenLogFile.UseVisualStyleBackColor = false;
        btnOpenLogFile.Click += btnOpenLogFile_Click;
        // 
        // btnOpenServerDir
        // 
        btnOpenServerDir.BackColor = Color.Transparent;
        btnOpenServerDir.FlatAppearance.BorderSize = 0;
        btnOpenServerDir.FlatStyle = FlatStyle.Flat;
        btnOpenServerDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnOpenServerDir.ForeColor = Color.White;
        btnOpenServerDir.IconChar = FontAwesome.Sharp.IconChar.FolderTree;
        btnOpenServerDir.IconColor = Color.White;
        btnOpenServerDir.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnOpenServerDir.IconSize = 30;
        btnOpenServerDir.ImageAlign = ContentAlignment.MiddleLeft;
        btnOpenServerDir.Location = new Point(345, 476);
        btnOpenServerDir.Name = "btnOpenServerDir";
        btnOpenServerDir.Size = new Size(160, 40);
        btnOpenServerDir.TabIndex = 5;
        btnOpenServerDir.Text = "Server Dir";
        btnOpenServerDir.UseVisualStyleBackColor = false;
        btnOpenServerDir.Click += btnOpenServerDir_Click;
        // 
        // btnUninstallServer
        // 
        btnUninstallServer.BackColor = Color.Transparent;
        btnUninstallServer.FlatAppearance.BorderSize = 0;
        btnUninstallServer.FlatStyle = FlatStyle.Flat;
        btnUninstallServer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnUninstallServer.ForeColor = Color.White;
        btnUninstallServer.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
        btnUninstallServer.IconColor = Color.White;
        btnUninstallServer.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnUninstallServer.IconSize = 30;
        btnUninstallServer.ImageAlign = ContentAlignment.MiddleLeft;
        btnUninstallServer.Location = new Point(13, 476);
        btnUninstallServer.Name = "btnUninstallServer";
        btnUninstallServer.Size = new Size(160, 40);
        btnUninstallServer.TabIndex = 6;
        btnUninstallServer.Text = "Uninstall ";
        btnUninstallServer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnUninstallServer.UseVisualStyleBackColor = false;
        btnUninstallServer.Click += btnUninstallServer_Click;
        // 
        // panelServerSettings
        // 
        panelServerSettings.Controls.Add(lblPresetHammer);
        panelServerSettings.Controls.Add(lblPresetImmersive);
        panelServerSettings.Controls.Add(lblPresetHardcore);
        panelServerSettings.Controls.Add(lblPresetHard);
        panelServerSettings.Controls.Add(lblPresetNormal);
        panelServerSettings.Controls.Add(lblPresetEasy);
        panelServerSettings.Controls.Add(lblPresetCasual);
        panelServerSettings.Controls.Add(trackBarPreset);
        panelServerSettings.Controls.Add(cbLogFile);
        panelServerSettings.Controls.Add(cbPublic);
        panelServerSettings.Controls.Add(cbCrossplay);
        panelServerSettings.Controls.Add(lblPreset);
        panelServerSettings.Controls.Add(tbBackupLongInfo);
        panelServerSettings.Controls.Add(label2);
        panelServerSettings.Controls.Add(tbBackupShortInfo);
        panelServerSettings.Controls.Add(blblBackupShort);
        panelServerSettings.Controls.Add(tbServerSaveIntervalInfo);
        panelServerSettings.Controls.Add(lblServerSaveInterval);
        panelServerSettings.Controls.Add(tbServerSaveDirInfo);
        panelServerSettings.Controls.Add(lblServerSaveDir);
        panelServerSettings.Controls.Add(tbServerBackupsInfo);
        panelServerSettings.Controls.Add(lblServerBackups);
        panelServerSettings.Controls.Add(tbServerWorldInfo);
        panelServerSettings.Controls.Add(lblServerWorld);
        panelServerSettings.Controls.Add(tbServerPortInfo);
        panelServerSettings.Controls.Add(tbServerIPInfo);
        panelServerSettings.Controls.Add(tbServerPasswordInfo);
        panelServerSettings.Controls.Add(tbServerNameInfo);
        panelServerSettings.Controls.Add(lblServerPort);
        panelServerSettings.Controls.Add(lblServerIP);
        panelServerSettings.Controls.Add(lblServerPassword);
        panelServerSettings.Controls.Add(lblServerName);
        panelServerSettings.Controls.Add(panelServerSettingsTop);
        panelServerSettings.Dock = DockStyle.Top;
        panelServerSettings.Location = new Point(0, 84);
        panelServerSettings.Name = "panelServerSettings";
        panelServerSettings.Size = new Size(880, 307);
        panelServerSettings.TabIndex = 8;
        // 
        // lblPresetHammer
        // 
        lblPresetHammer.BackColor = Color.Transparent;
        lblPresetHammer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetHammer.ForeColor = Color.White;
        lblPresetHammer.Location = new Point(756, 64);
        lblPresetHammer.Name = "lblPresetHammer";
        lblPresetHammer.Size = new Size(70, 23);
        lblPresetHammer.TabIndex = 50;
        lblPresetHammer.Text = "Hammer";
        lblPresetHammer.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetImmersive
        // 
        lblPresetImmersive.BackColor = Color.Transparent;
        lblPresetImmersive.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetImmersive.ForeColor = Color.White;
        lblPresetImmersive.Location = new Point(756, 97);
        lblPresetImmersive.Name = "lblPresetImmersive";
        lblPresetImmersive.Size = new Size(90, 23);
        lblPresetImmersive.TabIndex = 49;
        lblPresetImmersive.Text = "Immersive";
        lblPresetImmersive.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetHardcore
        // 
        lblPresetHardcore.BackColor = Color.Transparent;
        lblPresetHardcore.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetHardcore.ForeColor = Color.White;
        lblPresetHardcore.Location = new Point(756, 130);
        lblPresetHardcore.Name = "lblPresetHardcore";
        lblPresetHardcore.Size = new Size(70, 23);
        lblPresetHardcore.TabIndex = 48;
        lblPresetHardcore.Text = "Hardcore";
        lblPresetHardcore.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetHard
        // 
        lblPresetHard.BackColor = Color.Transparent;
        lblPresetHard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetHard.ForeColor = Color.White;
        lblPresetHard.Location = new Point(756, 163);
        lblPresetHard.Name = "lblPresetHard";
        lblPresetHard.Size = new Size(52, 23);
        lblPresetHard.TabIndex = 47;
        lblPresetHard.Text = "Hard";
        lblPresetHard.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetNormal
        // 
        lblPresetNormal.BackColor = Color.Transparent;
        lblPresetNormal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetNormal.ForeColor = Color.White;
        lblPresetNormal.Location = new Point(756, 195);
        lblPresetNormal.Name = "lblPresetNormal";
        lblPresetNormal.Size = new Size(70, 23);
        lblPresetNormal.TabIndex = 46;
        lblPresetNormal.Text = "Normal";
        lblPresetNormal.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetEasy
        // 
        lblPresetEasy.BackColor = Color.Transparent;
        lblPresetEasy.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetEasy.ForeColor = Color.White;
        lblPresetEasy.Location = new Point(756, 228);
        lblPresetEasy.Name = "lblPresetEasy";
        lblPresetEasy.Size = new Size(52, 23);
        lblPresetEasy.TabIndex = 45;
        lblPresetEasy.Text = "Easy";
        lblPresetEasy.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetCasual
        // 
        lblPresetCasual.BackColor = Color.Transparent;
        lblPresetCasual.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetCasual.ForeColor = Color.White;
        lblPresetCasual.Location = new Point(756, 261);
        lblPresetCasual.Name = "lblPresetCasual";
        lblPresetCasual.Size = new Size(52, 23);
        lblPresetCasual.TabIndex = 44;
        lblPresetCasual.Text = "Casual";
        lblPresetCasual.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // trackBarPreset
        // 
        trackBarPreset.LargeChange = 1;
        trackBarPreset.Location = new Point(727, 62);
        trackBarPreset.Maximum = 7;
        trackBarPreset.Minimum = 1;
        trackBarPreset.Name = "trackBarPreset";
        trackBarPreset.Orientation = Orientation.Vertical;
        trackBarPreset.Size = new Size(45, 224);
        trackBarPreset.TabIndex = 43;
        trackBarPreset.Value = 4;
        trackBarPreset.Scroll += trackBarPreset_Scroll;
        // 
        // cbLogFile
        // 
        cbLogFile.AutoSize = true;
        cbLogFile.BackColor = Color.Transparent;
        cbLogFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        cbLogFile.ForeColor = Color.White;
        cbLogFile.Location = new Point(580, 107);
        cbLogFile.Name = "cbLogFile";
        cbLogFile.Size = new Size(76, 21);
        cbLogFile.TabIndex = 36;
        cbLogFile.Text = "Log FIle";
        cbLogFile.UseVisualStyleBackColor = false;
        cbLogFile.CheckedChanged += cbLogFile_CheckedChanged;
        // 
        // cbPublic
        // 
        cbPublic.AutoSize = true;
        cbPublic.BackColor = Color.Transparent;
        cbPublic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        cbPublic.ForeColor = Color.White;
        cbPublic.Location = new Point(580, 82);
        cbPublic.Name = "cbPublic";
        cbPublic.Size = new Size(65, 21);
        cbPublic.TabIndex = 35;
        cbPublic.Text = "Public";
        cbPublic.UseVisualStyleBackColor = false;
        cbPublic.CheckedChanged += cbPublic_CheckedChanged;
        // 
        // cbCrossplay
        // 
        cbCrossplay.AutoSize = true;
        cbCrossplay.BackColor = Color.Transparent;
        cbCrossplay.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        cbCrossplay.ForeColor = Color.White;
        cbCrossplay.Location = new Point(580, 57);
        cbCrossplay.Name = "cbCrossplay";
        cbCrossplay.Size = new Size(86, 21);
        cbCrossplay.TabIndex = 34;
        cbCrossplay.Text = "Crossplay";
        cbCrossplay.UseVisualStyleBackColor = false;
        cbCrossplay.CheckedChanged += cbCrossplay_CheckedChanged;
        // 
        // lblPreset
        // 
        lblPreset.BackColor = Color.Transparent;
        lblPreset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPreset.ForeColor = Color.White;
        lblPreset.Location = new Point(727, 30);
        lblPreset.Name = "lblPreset";
        lblPreset.Size = new Size(92, 23);
        lblPreset.TabIndex = 35;
        lblPreset.Text = "Preset";
        lblPreset.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbBackupLongInfo
        // 
        tbBackupLongInfo.Location = new Point(381, 178);
        tbBackupLongInfo.Name = "tbBackupLongInfo";
        tbBackupLongInfo.PlaceholderText = "43200";
        tbBackupLongInfo.Size = new Size(147, 23);
        tbBackupLongInfo.TabIndex = 34;
        tbBackupLongInfo.TextChanged += tbBackupLonfInfo_TextChanged;
        // 
        // label2
        // 
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        label2.ForeColor = Color.White;
        label2.Location = new Point(267, 178);
        label2.Name = "label2";
        label2.Size = new Size(108, 23);
        label2.TabIndex = 33;
        label2.Text = "Backup Long:";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbBackupShortInfo
        // 
        tbBackupShortInfo.Location = new Point(381, 153);
        tbBackupShortInfo.Name = "tbBackupShortInfo";
        tbBackupShortInfo.PlaceholderText = "7200";
        tbBackupShortInfo.Size = new Size(147, 23);
        tbBackupShortInfo.TabIndex = 32;
        tbBackupShortInfo.TextChanged += tbBackupShortInfo_TextChanged;
        // 
        // blblBackupShort
        // 
        blblBackupShort.BackColor = Color.Transparent;
        blblBackupShort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        blblBackupShort.ForeColor = Color.White;
        blblBackupShort.Location = new Point(267, 153);
        blblBackupShort.Name = "blblBackupShort";
        blblBackupShort.Size = new Size(108, 23);
        blblBackupShort.TabIndex = 31;
        blblBackupShort.Text = "Backup Short:";
        blblBackupShort.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerSaveIntervalInfo
        // 
        tbServerSaveIntervalInfo.Location = new Point(381, 128);
        tbServerSaveIntervalInfo.Name = "tbServerSaveIntervalInfo";
        tbServerSaveIntervalInfo.PlaceholderText = "1800";
        tbServerSaveIntervalInfo.Size = new Size(147, 23);
        tbServerSaveIntervalInfo.TabIndex = 26;
        tbServerSaveIntervalInfo.TextChanged += tbServerSaveIntervalInfo_TextChanged;
        // 
        // lblServerSaveInterval
        // 
        lblServerSaveInterval.BackColor = Color.Transparent;
        lblServerSaveInterval.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerSaveInterval.ForeColor = Color.White;
        lblServerSaveInterval.Location = new Point(267, 128);
        lblServerSaveInterval.Name = "lblServerSaveInterval";
        lblServerSaveInterval.Size = new Size(108, 23);
        lblServerSaveInterval.TabIndex = 25;
        lblServerSaveInterval.Text = "Save Time:";
        lblServerSaveInterval.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerSaveDirInfo
        // 
        tbServerSaveDirInfo.Location = new Point(381, 103);
        tbServerSaveDirInfo.Name = "tbServerSaveDirInfo";
        tbServerSaveDirInfo.PlaceholderText = "save_game";
        tbServerSaveDirInfo.Size = new Size(147, 23);
        tbServerSaveDirInfo.TabIndex = 24;
        tbServerSaveDirInfo.TextChanged += tbServerSaveDirInfo_TextChanged;
        // 
        // lblServerSaveDir
        // 
        lblServerSaveDir.BackColor = Color.Transparent;
        lblServerSaveDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerSaveDir.ForeColor = Color.White;
        lblServerSaveDir.Location = new Point(267, 103);
        lblServerSaveDir.Name = "lblServerSaveDir";
        lblServerSaveDir.Size = new Size(108, 23);
        lblServerSaveDir.TabIndex = 23;
        lblServerSaveDir.Text = "Save Dir.:";
        lblServerSaveDir.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerBackupsInfo
        // 
        tbServerBackupsInfo.Location = new Point(381, 78);
        tbServerBackupsInfo.Name = "tbServerBackupsInfo";
        tbServerBackupsInfo.PlaceholderText = "4";
        tbServerBackupsInfo.Size = new Size(147, 23);
        tbServerBackupsInfo.TabIndex = 22;
        tbServerBackupsInfo.TextChanged += tbServerBackupsInfo_TextChanged;
        // 
        // lblServerBackups
        // 
        lblServerBackups.BackColor = Color.Transparent;
        lblServerBackups.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerBackups.ForeColor = Color.White;
        lblServerBackups.Location = new Point(267, 78);
        lblServerBackups.Name = "lblServerBackups";
        lblServerBackups.Size = new Size(108, 23);
        lblServerBackups.TabIndex = 21;
        lblServerBackups.Text = "Backups:";
        lblServerBackups.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerWorldInfo
        // 
        tbServerWorldInfo.Location = new Point(381, 53);
        tbServerWorldInfo.Name = "tbServerWorldInfo";
        tbServerWorldInfo.PlaceholderText = "Default";
        tbServerWorldInfo.Size = new Size(147, 23);
        tbServerWorldInfo.TabIndex = 20;
        tbServerWorldInfo.TextChanged += tbServerWorldInfo_TextChanged;
        // 
        // lblServerWorld
        // 
        lblServerWorld.BackColor = Color.Transparent;
        lblServerWorld.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerWorld.ForeColor = Color.White;
        lblServerWorld.Location = new Point(267, 53);
        lblServerWorld.Name = "lblServerWorld";
        lblServerWorld.Size = new Size(108, 23);
        lblServerWorld.TabIndex = 19;
        lblServerWorld.Text = "Server World:";
        lblServerWorld.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerPortInfo
        // 
        tbServerPortInfo.Location = new Point(98, 128);
        tbServerPortInfo.Name = "tbServerPortInfo";
        tbServerPortInfo.PlaceholderText = "12345";
        tbServerPortInfo.Size = new Size(147, 23);
        tbServerPortInfo.TabIndex = 18;
        tbServerPortInfo.TextChanged += tbServerPortInfo_TextChanged;
        // 
        // tbServerIPInfo
        // 
        tbServerIPInfo.Enabled = false;
        tbServerIPInfo.Location = new Point(98, 103);
        tbServerIPInfo.Name = "tbServerIPInfo";
        tbServerIPInfo.PlaceholderText = "127.0.0.1";
        tbServerIPInfo.ReadOnly = true;
        tbServerIPInfo.Size = new Size(147, 23);
        tbServerIPInfo.TabIndex = 17;
        // 
        // tbServerPasswordInfo
        // 
        tbServerPasswordInfo.Location = new Point(98, 78);
        tbServerPasswordInfo.Name = "tbServerPasswordInfo";
        tbServerPasswordInfo.PlaceholderText = "Secret";
        tbServerPasswordInfo.Size = new Size(147, 23);
        tbServerPasswordInfo.TabIndex = 16;
        tbServerPasswordInfo.TextChanged += tbServerPasswordInfo_TextChanged;
        // 
        // tbServerNameInfo
        // 
        tbServerNameInfo.Location = new Point(98, 53);
        tbServerNameInfo.Name = "tbServerNameInfo";
        tbServerNameInfo.PlaceholderText = "HeftiKuss";
        tbServerNameInfo.Size = new Size(147, 23);
        tbServerNameInfo.TabIndex = 15;
        tbServerNameInfo.TextChanged += tbServerNameInfo_TextChanged;
        // 
        // lblServerPort
        // 
        lblServerPort.BackColor = Color.Transparent;
        lblServerPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPort.ForeColor = Color.White;
        lblServerPort.Location = new Point(13, 128);
        lblServerPort.Name = "lblServerPort";
        lblServerPort.Size = new Size(78, 23);
        lblServerPort.TabIndex = 13;
        lblServerPort.Text = "Port:";
        lblServerPort.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblServerIP
        // 
        lblServerIP.BackColor = Color.Transparent;
        lblServerIP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerIP.ForeColor = Color.White;
        lblServerIP.Location = new Point(14, 103);
        lblServerIP.Name = "lblServerIP";
        lblServerIP.Size = new Size(78, 23);
        lblServerIP.TabIndex = 11;
        lblServerIP.Text = " IP:";
        lblServerIP.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblServerPassword
        // 
        lblServerPassword.BackColor = Color.Transparent;
        lblServerPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPassword.ForeColor = Color.White;
        lblServerPassword.Location = new Point(14, 78);
        lblServerPassword.Name = "lblServerPassword";
        lblServerPassword.Size = new Size(78, 23);
        lblServerPassword.TabIndex = 8;
        lblServerPassword.Text = "Password:";
        lblServerPassword.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblServerName
        // 
        lblServerName.BackColor = Color.Transparent;
        lblServerName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerName.ForeColor = Color.White;
        lblServerName.Location = new Point(14, 53);
        lblServerName.Name = "lblServerName";
        lblServerName.Size = new Size(78, 23);
        lblServerName.TabIndex = 6;
        lblServerName.Text = "Name:";
        lblServerName.TextAlign = ContentAlignment.MiddleRight;
        // 
        // panelServerSettingsTop
        // 
        panelServerSettingsTop.Controls.Add(label3);
        panelServerSettingsTop.Controls.Add(label1);
        panelServerSettingsTop.Dock = DockStyle.Top;
        panelServerSettingsTop.Location = new Point(0, 0);
        panelServerSettingsTop.Name = "panelServerSettingsTop";
        panelServerSettingsTop.Size = new Size(880, 30);
        panelServerSettingsTop.TabIndex = 10;
        // 
        // label3
        // 
        label3.BackColor = Color.Transparent;
        label3.Dock = DockStyle.Fill;
        label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.ForeColor = Color.White;
        label3.Location = new Point(0, 0);
        label3.Name = "label3";
        label3.Size = new Size(880, 30);
        label3.TabIndex = 0;
        label3.Text = "Server Settings";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        label1.ForeColor = Color.White;
        label1.Location = new Point(701, 7);
        label1.Name = "label1";
        label1.Size = new Size(92, 23);
        label1.TabIndex = 43;
        label1.Text = "Preset";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FormValheim
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(880, 530);
        Controls.Add(panelServerSettings);
        Controls.Add(btnUninstallServer);
        Controls.Add(btnOpenServerDir);
        Controls.Add(btnOpenLogFile);
        Controls.Add(btnStopServer);
        Controls.Add(btnStartServer);
        Controls.Add(btnInstallServer);
        Controls.Add(panelTopBar);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormValheim";
        ShowInTaskbar = false;
        Text = "Valheim Server";
        panelTopBar.ResumeLayout(false);
        panelTopBar.PerformLayout();
        panelServerUsage.ResumeLayout(false);
        panelServerUsage.PerformLayout();
        panelServerSettings.ResumeLayout(false);
        panelServerSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)trackBarPreset).EndInit();
        panelServerSettingsTop.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelTopBar;
    private Label lblServerInstalledInfo;
    private Label lblServerInstalled;
    private Label lblServerRunning;
    private Label lblServerRunningInfo;
    private FontAwesome.Sharp.IconButton btnInstallServer;
    private Label lblServerPathInfo;
    private Label lblServerPath;
    private FontAwesome.Sharp.IconButton btnStartServer;
    private FontAwesome.Sharp.IconButton btnStopServer;
    private FontAwesome.Sharp.IconButton btnOpenLogFile;
    private FontAwesome.Sharp.IconButton btnOpenServerDir;
    private FontAwesome.Sharp.IconButton btnUninstallServer;
    private Panel panelServerUsage;
    private ProgressBar progressBarRAM;
    private Label lblRAMUsageInfo;
    private Label lblRAMUsage;
    private Label lblCPUUsageInfo;
    private Label lblCPUUsage;
    private Panel panelServerSettings;
    private Label lblServerName;
    private Label lblServerPassword;
    private Panel panelServerSettingsTop;
    private Label label3;
    private Label lblServerIP;
    private Label lblServerPort;
    private TextBox tbServerNameInfo;
    private TextBox tbServerPasswordInfo;
    private TextBox tbServerIPInfo;
    private TextBox tbServerPortInfo;
    private Label lblServerWorld;
    private TextBox tbServerWorldInfo;
    private TextBox tbServerBackupsInfo;
    private Label lblServerBackups;
    private Label lblServerSaveDir;
    private TextBox tbServerSaveDirInfo;
    private TextBox tbServerSaveIntervalInfo;
    private Label lblServerSaveInterval;
    private TextBox tbBackupShortInfo;
    private Label blblBackupShort;
    private TextBox tbBackupLongInfo;
    private Label label2;
    private Label lblPreset;
    private Label label1;
    private CheckBox cbLogFile;
    private CheckBox cbPublic;
    private CheckBox cbCrossplay;
    private TrackBar trackBarPreset;
    private Label lblPresetCasual;
    private Label lblPresetHammer;
    private Label lblPresetImmersive;
    private Label lblPresetHardcore;
    private Label lblPresetHard;
    private Label lblPresetNormal;
    private Label lblPresetEasy;
}