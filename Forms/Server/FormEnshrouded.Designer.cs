namespace Game_Server_Manager.Forms;

partial class FormEnshrouded
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
        btnUninstallServer = new FontAwesome.Sharp.IconButton();
        btnOpenServerDir = new FontAwesome.Sharp.IconButton();
        btnOpenLogFolder = new FontAwesome.Sharp.IconButton();
        btnStopServer = new FontAwesome.Sharp.IconButton();
        btnStartServer = new FontAwesome.Sharp.IconButton();
        btnInstallServer = new FontAwesome.Sharp.IconButton();
        tbServerPortInfo = new TextBox();
        tbServerIPInfo = new TextBox();
        tbServerPasswordInfo = new TextBox();
        tbServerNameInfo = new TextBox();
        lblServerPort = new Label();
        lblServerIP = new Label();
        lblServerPassword = new Label();
        lblServerName = new Label();
        tbServerQueryPortInfo = new TextBox();
        lblServerQueryPort = new Label();
        label3 = new Label();
        tbServerSaveDirInfo = new TextBox();
        lblServerSaveDir = new Label();
        tbServerLogDirInfo = new TextBox();
        lblLogDir = new Label();
        tbServerSlotsInfo = new TextBox();
        lblSLots = new Label();
        panelTopBar.SuspendLayout();
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
        panelTopBar.TabIndex = 1;
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
        btnUninstallServer.TabIndex = 12;
        btnUninstallServer.Text = "Uninstall ";
        btnUninstallServer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnUninstallServer.UseVisualStyleBackColor = false;
        btnUninstallServer.Click += btnUninstallServer_Click;
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
        btnOpenServerDir.TabIndex = 11;
        btnOpenServerDir.Text = "Server Dir";
        btnOpenServerDir.UseVisualStyleBackColor = false;
        btnOpenServerDir.Click += btnOpenServerDir_Click;
        // 
        // btnOpenLogFolder
        // 
        btnOpenLogFolder.BackColor = Color.Transparent;
        btnOpenLogFolder.FlatAppearance.BorderSize = 0;
        btnOpenLogFolder.FlatStyle = FlatStyle.Flat;
        btnOpenLogFolder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnOpenLogFolder.ForeColor = Color.White;
        btnOpenLogFolder.IconChar = FontAwesome.Sharp.IconChar.BarChart;
        btnOpenLogFolder.IconColor = Color.White;
        btnOpenLogFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnOpenLogFolder.IconSize = 30;
        btnOpenLogFolder.ImageAlign = ContentAlignment.MiddleLeft;
        btnOpenLogFolder.Location = new Point(344, 435);
        btnOpenLogFolder.Name = "btnOpenLogFolder";
        btnOpenLogFolder.Size = new Size(160, 40);
        btnOpenLogFolder.TabIndex = 10;
        btnOpenLogFolder.Text = "Log Folder";
        btnOpenLogFolder.UseVisualStyleBackColor = false;
        btnOpenLogFolder.Click += btnOpenLogDir_Click;
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
        btnStopServer.TabIndex = 9;
        btnStopServer.Text = "Stop Server";
        btnStopServer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnStopServer.UseVisualStyleBackColor = false;
        btnStopServer.Click += btnStopServer_Click;
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
        btnStartServer.TabIndex = 8;
        btnStartServer.Text = "Start Server";
        btnStartServer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnStartServer.UseVisualStyleBackColor = false;
        btnStartServer.Click += btnStartServer_Click;
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
        btnInstallServer.TabIndex = 7;
        btnInstallServer.Text = "Install   ";
        btnInstallServer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnInstallServer.UseVisualStyleBackColor = false;
        btnInstallServer.Click += btnInstallServer_Click;
        // 
        // tbServerPortInfo
        // 
        tbServerPortInfo.Location = new Point(121, 215);
        tbServerPortInfo.Name = "tbServerPortInfo";
        tbServerPortInfo.PlaceholderText = "12345";
        tbServerPortInfo.Size = new Size(150, 23);
        tbServerPortInfo.TabIndex = 26;
        tbServerPortInfo.TextChanged += tbServerPortInfo_TextChanged;
        // 
        // tbServerIPInfo
        // 
        tbServerIPInfo.Enabled = false;
        tbServerIPInfo.Location = new Point(121, 190);
        tbServerIPInfo.Name = "tbServerIPInfo";
        tbServerIPInfo.PlaceholderText = "127.0.0.1";
        tbServerIPInfo.ReadOnly = true;
        tbServerIPInfo.Size = new Size(150, 23);
        tbServerIPInfo.TabIndex = 25;
        // 
        // tbServerPasswordInfo
        // 
        tbServerPasswordInfo.Location = new Point(121, 165);
        tbServerPasswordInfo.Name = "tbServerPasswordInfo";
        tbServerPasswordInfo.PlaceholderText = "Secret";
        tbServerPasswordInfo.Size = new Size(150, 23);
        tbServerPasswordInfo.TabIndex = 24;
        tbServerPasswordInfo.TextChanged += tbServerPasswordInfo_TextChanged;
        // 
        // tbServerNameInfo
        // 
        tbServerNameInfo.Location = new Point(121, 140);
        tbServerNameInfo.Name = "tbServerNameInfo";
        tbServerNameInfo.PlaceholderText = "HeftiKuss";
        tbServerNameInfo.Size = new Size(150, 23);
        tbServerNameInfo.TabIndex = 23;
        tbServerNameInfo.TextChanged += tbServerNameInfo_TextChanged;
        // 
        // lblServerPort
        // 
        lblServerPort.BackColor = Color.Transparent;
        lblServerPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPort.ForeColor = Color.White;
        lblServerPort.Location = new Point(15, 215);
        lblServerPort.Name = "lblServerPort";
        lblServerPort.Size = new Size(100, 23);
        lblServerPort.TabIndex = 22;
        lblServerPort.Text = "Port:";
        lblServerPort.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblServerIP
        // 
        lblServerIP.BackColor = Color.Transparent;
        lblServerIP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerIP.ForeColor = Color.White;
        lblServerIP.Location = new Point(15, 190);
        lblServerIP.Name = "lblServerIP";
        lblServerIP.Size = new Size(100, 23);
        lblServerIP.TabIndex = 21;
        lblServerIP.Text = " IP:";
        lblServerIP.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblServerPassword
        // 
        lblServerPassword.BackColor = Color.Transparent;
        lblServerPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPassword.ForeColor = Color.White;
        lblServerPassword.Location = new Point(15, 165);
        lblServerPassword.Name = "lblServerPassword";
        lblServerPassword.Size = new Size(100, 23);
        lblServerPassword.TabIndex = 20;
        lblServerPassword.Text = "Password:";
        lblServerPassword.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lblServerName
        // 
        lblServerName.BackColor = Color.Transparent;
        lblServerName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerName.ForeColor = Color.White;
        lblServerName.Location = new Point(15, 140);
        lblServerName.Name = "lblServerName";
        lblServerName.Size = new Size(100, 23);
        lblServerName.TabIndex = 19;
        lblServerName.Text = "Name:";
        lblServerName.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerQueryPortInfo
        // 
        tbServerQueryPortInfo.Location = new Point(121, 240);
        tbServerQueryPortInfo.Name = "tbServerQueryPortInfo";
        tbServerQueryPortInfo.PlaceholderText = "12345";
        tbServerQueryPortInfo.Size = new Size(150, 23);
        tbServerQueryPortInfo.TabIndex = 28;
        tbServerQueryPortInfo.TextChanged += tbServerQuaryPortInfo_TextChanged;
        // 
        // lblServerQueryPort
        // 
        lblServerQueryPort.BackColor = Color.Transparent;
        lblServerQueryPort.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerQueryPort.ForeColor = Color.White;
        lblServerQueryPort.Location = new Point(15, 240);
        lblServerQueryPort.Name = "lblServerQueryPort";
        lblServerQueryPort.Size = new Size(100, 23);
        lblServerQueryPort.TabIndex = 27;
        lblServerQueryPort.Text = "Query Port:";
        lblServerQueryPort.TextAlign = ContentAlignment.MiddleRight;
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
        label3.TabIndex = 29;
        label3.Text = "Server Settings";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tbServerSaveDirInfo
        // 
        tbServerSaveDirInfo.Location = new Point(389, 140);
        tbServerSaveDirInfo.Name = "tbServerSaveDirInfo";
        tbServerSaveDirInfo.PlaceholderText = "save_game";
        tbServerSaveDirInfo.Size = new Size(150, 23);
        tbServerSaveDirInfo.TabIndex = 31;
        tbServerSaveDirInfo.TextChanged += tbServerSaveDirInfo_TextChanged;
        // 
        // lblServerSaveDir
        // 
        lblServerSaveDir.BackColor = Color.Transparent;
        lblServerSaveDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerSaveDir.ForeColor = Color.White;
        lblServerSaveDir.Location = new Point(283, 140);
        lblServerSaveDir.Name = "lblServerSaveDir";
        lblServerSaveDir.Size = new Size(100, 23);
        lblServerSaveDir.TabIndex = 30;
        lblServerSaveDir.Text = "Save Dir.:";
        lblServerSaveDir.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerLogDirInfo
        // 
        tbServerLogDirInfo.Location = new Point(389, 165);
        tbServerLogDirInfo.Name = "tbServerLogDirInfo";
        tbServerLogDirInfo.PlaceholderText = "log_dir";
        tbServerLogDirInfo.Size = new Size(150, 23);
        tbServerLogDirInfo.TabIndex = 33;
        tbServerLogDirInfo.TextChanged += tbServerLogDirInfo_TextChanged;
        // 
        // lblLogDir
        // 
        lblLogDir.BackColor = Color.Transparent;
        lblLogDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblLogDir.ForeColor = Color.White;
        lblLogDir.Location = new Point(283, 165);
        lblLogDir.Name = "lblLogDir";
        lblLogDir.Size = new Size(100, 23);
        lblLogDir.TabIndex = 32;
        lblLogDir.Text = "Log Dir.:";
        lblLogDir.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tbServerSlotsInfo
        // 
        tbServerSlotsInfo.Location = new Point(389, 190);
        tbServerSlotsInfo.Name = "tbServerSlotsInfo";
        tbServerSlotsInfo.PlaceholderText = "16";
        tbServerSlotsInfo.Size = new Size(150, 23);
        tbServerSlotsInfo.TabIndex = 35;
        tbServerSlotsInfo.TextChanged += tbServerSlotsInfo_TextChanged;
        // 
        // lblSLots
        // 
        lblSLots.BackColor = Color.Transparent;
        lblSLots.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblSLots.ForeColor = Color.White;
        lblSLots.Location = new Point(283, 188);
        lblSLots.Name = "lblSLots";
        lblSLots.Size = new Size(100, 23);
        lblSLots.TabIndex = 34;
        lblSLots.Text = "Slots:";
        lblSLots.TextAlign = ContentAlignment.MiddleRight;
        // 
        // FormEnshrouded
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(880, 530);
        Controls.Add(tbServerSlotsInfo);
        Controls.Add(lblSLots);
        Controls.Add(tbServerLogDirInfo);
        Controls.Add(lblLogDir);
        Controls.Add(tbServerSaveDirInfo);
        Controls.Add(lblServerSaveDir);
        Controls.Add(label3);
        Controls.Add(tbServerQueryPortInfo);
        Controls.Add(lblServerQueryPort);
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
        Controls.Add(btnOpenLogFolder);
        Controls.Add(btnStopServer);
        Controls.Add(btnStartServer);
        Controls.Add(btnInstallServer);
        Controls.Add(panelTopBar);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormEnshrouded";
        Text = "Enshrouded Server";
        panelTopBar.ResumeLayout(false);
        panelTopBar.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panelTopBar;
    private Label lblServerPathInfo;
    private Label lblServerPath;
    private Label lblServerRunning;
    private Label lblServerRunningInfo;
    private Label lblServerInstalledInfo;
    private Label lblServerInstalled;
    private FontAwesome.Sharp.IconButton btnUninstallServer;
    private FontAwesome.Sharp.IconButton btnOpenServerDir;
    private FontAwesome.Sharp.IconButton btnOpenLogFolder;
    private FontAwesome.Sharp.IconButton btnStopServer;
    private FontAwesome.Sharp.IconButton btnStartServer;
    private FontAwesome.Sharp.IconButton btnInstallServer;
    private TextBox tbServerPortInfo;
    private TextBox tbServerIPInfo;
    private TextBox tbServerPasswordInfo;
    private TextBox tbServerNameInfo;
    private Label lblServerPort;
    private Label lblServerIP;
    private Label lblServerPassword;
    private Label lblServerName;
    private TextBox tbServerQueryPortInfo;
    private Label lblServerQueryPort;
    private Label label3;
    private TextBox tbServerSaveDirInfo;
    private Label lblServerSaveDir;
    private TextBox tbServerLogDirInfo;
    private Label lblLogDir;
    private TextBox tbServerSlotsInfo;
    private Label lblSLots;
    private ProgressBar progressBarRAM;
    private Label lblRAMUsageInfo;
    private Label lblRAMUsage;
    private Label lblLastUpdateInfo;
    private Label lblLastUpdate;
}