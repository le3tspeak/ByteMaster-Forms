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
        lblLastUpdateInfo = new Label();
        lblLastUpdate = new Label();
        progressBarRAM = new ProgressBar();
        lblRAMUsageInfo = new Label();
        lblRAMUsage = new Label();
        lblServerPathInfo = new Label();
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
        label3 = new Label();
        panelTopBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)trackBarPreset).BeginInit();
        SuspendLayout();
        // 
        // panelTopBar
        // 
        panelTopBar.Controls.Add(lblLastUpdateInfo);
        panelTopBar.Controls.Add(lblLastUpdate);
        panelTopBar.Controls.Add(progressBarRAM);
        panelTopBar.Controls.Add(lblRAMUsageInfo);
        panelTopBar.Controls.Add(lblRAMUsage);
        panelTopBar.Controls.Add(lblServerPathInfo);
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
        // lblLastUpdateInfo
        // 
        lblLastUpdateInfo.AutoSize = true;
        lblLastUpdateInfo.BackColor = Color.Transparent;
        lblLastUpdateInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblLastUpdateInfo.ForeColor = Color.White;
        lblLastUpdateInfo.ImeMode = ImeMode.NoControl;
        lblLastUpdateInfo.Location = new Point(711, 9);
        lblLastUpdateInfo.Name = "lblLastUpdateInfo";
        lblLastUpdateInfo.Size = new Size(72, 17);
        lblLastUpdateInfo.TabIndex = 22;
        lblLastUpdateInfo.Text = "01.01.2000";
        // 
        // lblLastUpdate
        // 
        lblLastUpdate.AutoSize = true;
        lblLastUpdate.BackColor = Color.Transparent;
        lblLastUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblLastUpdate.ForeColor = Color.White;
        lblLastUpdate.ImeMode = ImeMode.NoControl;
        lblLastUpdate.Location = new Point(626, 9);
        lblLastUpdate.Name = "lblLastUpdate";
        lblLastUpdate.Size = new Size(85, 17);
        lblLastUpdate.TabIndex = 23;
        lblLastUpdate.Text = "Last Update:";
        // 
        // progressBarRAM
        // 
        progressBarRAM.ForeColor = Color.Firebrick;
        progressBarRAM.Location = new Point(398, 29);
        progressBarRAM.Name = "progressBarRAM";
        progressBarRAM.Size = new Size(142, 10);
        progressBarRAM.Step = 1;
        progressBarRAM.TabIndex = 20;
        // 
        // lblRAMUsageInfo
        // 
        lblRAMUsageInfo.AutoSize = true;
        lblRAMUsageInfo.BackColor = Color.Transparent;
        lblRAMUsageInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsageInfo.ForeColor = Color.White;
        lblRAMUsageInfo.Location = new Point(398, 9);
        lblRAMUsageInfo.Name = "lblRAMUsageInfo";
        lblRAMUsageInfo.Size = new Size(84, 17);
        lblRAMUsageInfo.TabIndex = 19;
        lblRAMUsageInfo.Text = "0 MB / 0 MB";
        // 
        // lblRAMUsage
        // 
        lblRAMUsage.AutoSize = true;
        lblRAMUsage.BackColor = Color.Transparent;
        lblRAMUsage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsage.ForeColor = Color.White;
        lblRAMUsage.Location = new Point(314, 9);
        lblRAMUsage.Name = "lblRAMUsage";
        lblRAMUsage.Size = new Size(86, 17);
        lblRAMUsage.TabIndex = 18;
        lblRAMUsage.Text = "RAM Usage: ";
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
        btnInstallServer.Location = new Point(12, 435);
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
        btnStartServer.Location = new Point(178, 435);
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
        btnStopServer.Location = new Point(178, 478);
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
        btnOpenLogFile.Location = new Point(344, 435);
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
        btnOpenServerDir.Location = new Point(344, 478);
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
        btnUninstallServer.Location = new Point(12, 478);
        btnUninstallServer.Name = "btnUninstallServer";
        btnUninstallServer.Size = new Size(160, 40);
        btnUninstallServer.TabIndex = 6;
        btnUninstallServer.Text = "Uninstall ";
        btnUninstallServer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnUninstallServer.UseVisualStyleBackColor = false;
        btnUninstallServer.Click += btnUninstallServer_Click;
        // 
        // lblPresetHammer
        // 
        lblPresetHammer.BackColor = Color.Transparent;
        lblPresetHammer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetHammer.ForeColor = Color.White;
        lblPresetHammer.Location = new Point(767, 173);
        lblPresetHammer.Name = "lblPresetHammer";
        lblPresetHammer.Size = new Size(70, 23);
        lblPresetHammer.TabIndex = 82;
        lblPresetHammer.Text = "Hammer";
        lblPresetHammer.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetImmersive
        // 
        lblPresetImmersive.BackColor = Color.Transparent;
        lblPresetImmersive.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetImmersive.ForeColor = Color.White;
        lblPresetImmersive.Location = new Point(767, 206);
        lblPresetImmersive.Name = "lblPresetImmersive";
        lblPresetImmersive.Size = new Size(90, 23);
        lblPresetImmersive.TabIndex = 81;
        lblPresetImmersive.Text = "Immersive";
        lblPresetImmersive.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetHardcore
        // 
        lblPresetHardcore.BackColor = Color.Transparent;
        lblPresetHardcore.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetHardcore.ForeColor = Color.White;
        lblPresetHardcore.Location = new Point(767, 239);
        lblPresetHardcore.Name = "lblPresetHardcore";
        lblPresetHardcore.Size = new Size(70, 23);
        lblPresetHardcore.TabIndex = 80;
        lblPresetHardcore.Text = "Hardcore";
        lblPresetHardcore.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetHard
        // 
        lblPresetHard.BackColor = Color.Transparent;
        lblPresetHard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetHard.ForeColor = Color.White;
        lblPresetHard.Location = new Point(767, 272);
        lblPresetHard.Name = "lblPresetHard";
        lblPresetHard.Size = new Size(52, 23);
        lblPresetHard.TabIndex = 79;
        lblPresetHard.Text = "Hard";
        lblPresetHard.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetNormal
        // 
        lblPresetNormal.BackColor = Color.Transparent;
        lblPresetNormal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetNormal.ForeColor = Color.White;
        lblPresetNormal.Location = new Point(767, 304);
        lblPresetNormal.Name = "lblPresetNormal";
        lblPresetNormal.Size = new Size(70, 23);
        lblPresetNormal.TabIndex = 78;
        lblPresetNormal.Text = "Normal";
        lblPresetNormal.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetEasy
        // 
        lblPresetEasy.BackColor = Color.Transparent;
        lblPresetEasy.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetEasy.ForeColor = Color.White;
        lblPresetEasy.Location = new Point(767, 337);
        lblPresetEasy.Name = "lblPresetEasy";
        lblPresetEasy.Size = new Size(52, 23);
        lblPresetEasy.TabIndex = 77;
        lblPresetEasy.Text = "Easy";
        lblPresetEasy.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblPresetCasual
        // 
        lblPresetCasual.BackColor = Color.Transparent;
        lblPresetCasual.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPresetCasual.ForeColor = Color.White;
        lblPresetCasual.Location = new Point(767, 370);
        lblPresetCasual.Name = "lblPresetCasual";
        lblPresetCasual.Size = new Size(52, 23);
        lblPresetCasual.TabIndex = 76;
        lblPresetCasual.Text = "Casual";
        lblPresetCasual.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // trackBarPreset
        // 
        trackBarPreset.LargeChange = 1;
        trackBarPreset.Location = new Point(738, 171);
        trackBarPreset.Maximum = 7;
        trackBarPreset.Minimum = 1;
        trackBarPreset.Name = "trackBarPreset";
        trackBarPreset.Orientation = Orientation.Vertical;
        trackBarPreset.Size = new Size(45, 224);
        trackBarPreset.TabIndex = 75;
        trackBarPreset.Value = 1;
        trackBarPreset.Scroll += trackBarPreset_Scroll;
        // 
        // cbLogFile
        // 
        cbLogFile.AutoSize = true;
        cbLogFile.BackColor = Color.Transparent;
        cbLogFile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        cbLogFile.ForeColor = Color.White;
        cbLogFile.Location = new Point(591, 196);
        cbLogFile.Name = "cbLogFile";
        cbLogFile.Size = new Size(76, 21);
        cbLogFile.TabIndex = 74;
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
        cbPublic.Location = new Point(591, 171);
        cbPublic.Name = "cbPublic";
        cbPublic.Size = new Size(65, 21);
        cbPublic.TabIndex = 73;
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
        cbCrossplay.Location = new Point(591, 146);
        cbCrossplay.Name = "cbCrossplay";
        cbCrossplay.Size = new Size(86, 21);
        cbCrossplay.TabIndex = 71;
        cbCrossplay.Text = "Crossplay";
        cbCrossplay.UseVisualStyleBackColor = false;
        cbCrossplay.CheckedChanged += cbCrossplay_CheckedChanged;
        // 
        // lblPreset
        // 
        lblPreset.BackColor = Color.Transparent;
        lblPreset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblPreset.ForeColor = Color.White;
        lblPreset.Location = new Point(738, 139);
        lblPreset.Name = "lblPreset";
        lblPreset.Size = new Size(92, 23);
        lblPreset.TabIndex = 72;
        lblPreset.Text = "Preset";
        lblPreset.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbBackupLongInfo
        // 
        tbBackupLongInfo.Location = new Point(392, 267);
        tbBackupLongInfo.Name = "tbBackupLongInfo";
        tbBackupLongInfo.Size = new Size(147, 23);
        tbBackupLongInfo.TabIndex = 70;
        tbBackupLongInfo.TextChanged += tbBackupLonfInfo_TextChanged;
        // 
        // label2
        // 
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        label2.ForeColor = Color.White;
        label2.Location = new Point(278, 267);
        label2.Name = "label2";
        label2.Size = new Size(108, 23);
        label2.TabIndex = 69;
        label2.Text = "Backup Long:";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbBackupShortInfo
        // 
        tbBackupShortInfo.Location = new Point(392, 242);
        tbBackupShortInfo.Name = "tbBackupShortInfo";
        tbBackupShortInfo.Size = new Size(147, 23);
        tbBackupShortInfo.TabIndex = 68;
        tbBackupShortInfo.TextChanged += tbBackupShortInfo_TextChanged;
        // 
        // blblBackupShort
        // 
        blblBackupShort.BackColor = Color.Transparent;
        blblBackupShort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        blblBackupShort.ForeColor = Color.White;
        blblBackupShort.Location = new Point(278, 242);
        blblBackupShort.Name = "blblBackupShort";
        blblBackupShort.Size = new Size(108, 23);
        blblBackupShort.TabIndex = 67;
        blblBackupShort.Text = "Backup Short:";
        blblBackupShort.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerSaveIntervalInfo
        // 
        tbServerSaveIntervalInfo.Location = new Point(392, 217);
        tbServerSaveIntervalInfo.Name = "tbServerSaveIntervalInfo";
        tbServerSaveIntervalInfo.PlaceholderText = "1800";
        tbServerSaveIntervalInfo.Size = new Size(147, 23);
        tbServerSaveIntervalInfo.TabIndex = 66;
        tbServerSaveIntervalInfo.TextChanged += tbServerSaveIntervalInfo_TextChanged;
        // 
        // lblServerSaveInterval
        // 
        lblServerSaveInterval.BackColor = Color.Transparent;
        lblServerSaveInterval.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerSaveInterval.ForeColor = Color.White;
        lblServerSaveInterval.Location = new Point(278, 217);
        lblServerSaveInterval.Name = "lblServerSaveInterval";
        lblServerSaveInterval.Size = new Size(108, 23);
        lblServerSaveInterval.TabIndex = 65;
        lblServerSaveInterval.Text = "Save Time:";
        lblServerSaveInterval.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerSaveDirInfo
        // 
        tbServerSaveDirInfo.Location = new Point(392, 192);
        tbServerSaveDirInfo.Name = "tbServerSaveDirInfo";
        tbServerSaveDirInfo.PlaceholderText = "save_game";
        tbServerSaveDirInfo.Size = new Size(147, 23);
        tbServerSaveDirInfo.TabIndex = 64;
        tbServerSaveDirInfo.TextChanged += tbServerSaveDirInfo_TextChanged;
        // 
        // lblServerSaveDir
        // 
        lblServerSaveDir.BackColor = Color.Transparent;
        lblServerSaveDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerSaveDir.ForeColor = Color.White;
        lblServerSaveDir.Location = new Point(278, 192);
        lblServerSaveDir.Name = "lblServerSaveDir";
        lblServerSaveDir.Size = new Size(108, 23);
        lblServerSaveDir.TabIndex = 63;
        lblServerSaveDir.Text = "Save Dir.:";
        lblServerSaveDir.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerBackupsInfo
        // 
        tbServerBackupsInfo.Location = new Point(392, 167);
        tbServerBackupsInfo.Name = "tbServerBackupsInfo";
        tbServerBackupsInfo.PlaceholderText = "4";
        tbServerBackupsInfo.Size = new Size(147, 23);
        tbServerBackupsInfo.TabIndex = 62;
        tbServerBackupsInfo.TextChanged += tbServerBackupsInfo_TextChanged;
        // 
        // lblServerBackups
        // 
        lblServerBackups.BackColor = Color.Transparent;
        lblServerBackups.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerBackups.ForeColor = Color.White;
        lblServerBackups.Location = new Point(278, 167);
        lblServerBackups.Name = "lblServerBackups";
        lblServerBackups.Size = new Size(108, 23);
        lblServerBackups.TabIndex = 61;
        lblServerBackups.Text = "Backups:";
        lblServerBackups.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerWorldInfo
        // 
        tbServerWorldInfo.Location = new Point(392, 142);
        tbServerWorldInfo.Name = "tbServerWorldInfo";
        tbServerWorldInfo.PlaceholderText = "Default";
        tbServerWorldInfo.Size = new Size(147, 23);
        tbServerWorldInfo.TabIndex = 60;
        tbServerWorldInfo.TextChanged += tbServerWorldInfo_TextChanged;
        // 
        // lblServerWorld
        // 
        lblServerWorld.BackColor = Color.Transparent;
        lblServerWorld.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerWorld.ForeColor = Color.White;
        lblServerWorld.Location = new Point(278, 142);
        lblServerWorld.Name = "lblServerWorld";
        lblServerWorld.Size = new Size(108, 23);
        lblServerWorld.TabIndex = 59;
        lblServerWorld.Text = "Server World:";
        lblServerWorld.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerPortInfo
        // 
        tbServerPortInfo.Location = new Point(109, 217);
        tbServerPortInfo.Name = "tbServerPortInfo";
        tbServerPortInfo.PlaceholderText = "12345";
        tbServerPortInfo.Size = new Size(147, 23);
        tbServerPortInfo.TabIndex = 58;
        tbServerPortInfo.TextChanged += tbServerPortInfo_TextChanged;
        // 
        // tbServerIPInfo
        // 
        tbServerIPInfo.Enabled = false;
        tbServerIPInfo.Location = new Point(109, 192);
        tbServerIPInfo.Name = "tbServerIPInfo";
        tbServerIPInfo.PlaceholderText = "127.0.0.1";
        tbServerIPInfo.ReadOnly = true;
        tbServerIPInfo.Size = new Size(147, 23);
        tbServerIPInfo.TabIndex = 57;
        // 
        // tbServerPasswordInfo
        // 
        tbServerPasswordInfo.Location = new Point(109, 167);
        tbServerPasswordInfo.Name = "tbServerPasswordInfo";
        tbServerPasswordInfo.PlaceholderText = "Secret";
        tbServerPasswordInfo.Size = new Size(147, 23);
        tbServerPasswordInfo.TabIndex = 56;
        tbServerPasswordInfo.TextChanged += tbServerPasswordInfo_TextChanged;
        // 
        // tbServerNameInfo
        // 
        tbServerNameInfo.Location = new Point(109, 142);
        tbServerNameInfo.Name = "tbServerNameInfo";
        tbServerNameInfo.PlaceholderText = "HeftiKuss";
        tbServerNameInfo.Size = new Size(147, 23);
        tbServerNameInfo.TabIndex = 55;
        tbServerNameInfo.TextChanged += tbServerNameInfo_TextChanged;
        // 
        // lblServerPort
        // 
        lblServerPort.BackColor = Color.Transparent;
        lblServerPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPort.ForeColor = Color.White;
        lblServerPort.Location = new Point(25, 217);
        lblServerPort.Name = "lblServerPort";
        lblServerPort.Size = new Size(78, 23);
        lblServerPort.TabIndex = 54;
        lblServerPort.Text = "Port:";
        lblServerPort.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblServerIP
        // 
        lblServerIP.BackColor = Color.Transparent;
        lblServerIP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerIP.ForeColor = Color.White;
        lblServerIP.Location = new Point(28, 192);
        lblServerIP.Name = "lblServerIP";
        lblServerIP.Size = new Size(78, 23);
        lblServerIP.TabIndex = 53;
        lblServerIP.Text = " IP:";
        lblServerIP.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblServerPassword
        // 
        lblServerPassword.BackColor = Color.Transparent;
        lblServerPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPassword.ForeColor = Color.White;
        lblServerPassword.Location = new Point(28, 167);
        lblServerPassword.Name = "lblServerPassword";
        lblServerPassword.Size = new Size(78, 23);
        lblServerPassword.TabIndex = 52;
        lblServerPassword.Text = "Password:";
        lblServerPassword.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblServerName
        // 
        lblServerName.BackColor = Color.Transparent;
        lblServerName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerName.ForeColor = Color.White;
        lblServerName.Location = new Point(25, 140);
        lblServerName.Name = "lblServerName";
        lblServerName.Size = new Size(78, 23);
        lblServerName.TabIndex = 51;
        lblServerName.Text = "Name:";
        lblServerName.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        label3.BackColor = Color.Transparent;
        label3.Dock = DockStyle.Top;
        label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.ForeColor = Color.White;
        label3.Location = new Point(0, 84);
        label3.Name = "label3";
        label3.Size = new Size(880, 30);
        label3.TabIndex = 83;
        label3.Text = "Server Settings";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FormValheim
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(880, 530);
        Controls.Add(label3);
        Controls.Add(lblPresetHammer);
        Controls.Add(lblPresetImmersive);
        Controls.Add(lblPresetHardcore);
        Controls.Add(lblPresetHard);
        Controls.Add(lblPresetNormal);
        Controls.Add(lblPresetEasy);
        Controls.Add(lblPresetCasual);
        Controls.Add(trackBarPreset);
        Controls.Add(cbLogFile);
        Controls.Add(cbPublic);
        Controls.Add(cbCrossplay);
        Controls.Add(lblPreset);
        Controls.Add(tbBackupLongInfo);
        Controls.Add(label2);
        Controls.Add(tbBackupShortInfo);
        Controls.Add(blblBackupShort);
        Controls.Add(tbServerSaveIntervalInfo);
        Controls.Add(lblServerSaveInterval);
        Controls.Add(tbServerSaveDirInfo);
        Controls.Add(lblServerSaveDir);
        Controls.Add(tbServerBackupsInfo);
        Controls.Add(lblServerBackups);
        Controls.Add(tbServerWorldInfo);
        Controls.Add(lblServerWorld);
        Controls.Add(tbServerPortInfo);
        Controls.Add(tbServerIPInfo);
        Controls.Add(tbServerPasswordInfo);
        Controls.Add(tbServerNameInfo);
        Controls.Add(lblServerPort);
        Controls.Add(lblServerIP);
        Controls.Add(lblServerPassword);
        Controls.Add(lblServerName);
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
        ((System.ComponentModel.ISupportInitialize)trackBarPreset).EndInit();
        ResumeLayout(false);
        PerformLayout();
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
    private Label lblPresetHammer;
    private Label lblPresetImmersive;
    private Label lblPresetHardcore;
    private Label lblPresetHard;
    private Label lblPresetNormal;
    private Label lblPresetEasy;
    private Label lblPresetCasual;
    private TrackBar trackBarPreset;
    private CheckBox cbLogFile;
    private CheckBox cbPublic;
    private CheckBox cbCrossplay;
    private Label lblPreset;
    private TextBox tbBackupLongInfo;
    private Label label2;
    private TextBox tbBackupShortInfo;
    private Label blblBackupShort;
    private TextBox tbServerSaveIntervalInfo;
    private Label lblServerSaveInterval;
    private TextBox tbServerSaveDirInfo;
    private Label lblServerSaveDir;
    private TextBox tbServerBackupsInfo;
    private Label lblServerBackups;
    private TextBox tbServerWorldInfo;
    private Label lblServerWorld;
    private TextBox tbServerPortInfo;
    private TextBox tbServerIPInfo;
    private TextBox tbServerPasswordInfo;
    private TextBox tbServerNameInfo;
    private Label lblServerPort;
    private Label lblServerIP;
    private Label lblServerPassword;
    private Label lblServerName;
    private Label label3;
    private ProgressBar progressBarRAM;
    private Label lblRAMUsageInfo;
    private Label lblRAMUsage;
    private Label lblLastUpdateInfo;
    private Label lblLastUpdate;
}