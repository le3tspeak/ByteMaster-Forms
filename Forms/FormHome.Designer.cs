namespace Game_Server_Manager.Forms;

partial class FormHome
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
        lblSteamCMDInstalledINfo = new Label();
        label4 = new Label();
        label3 = new Label();
        lblCpuNumberOfCoresInfo = new Label();
        label2 = new Label();
        lblCpuNameInfo = new Label();
        lblRamUsageSystemInfo = new Label();
        lblRamUsageSystem = new Label();
        label1 = new Label();
        panelValheimBar = new Panel();
        lblServerValheimPathInfo = new Label();
        lblServerPath = new Label();
        lblServerRunning = new Label();
        lblServerValheimRunningInfo = new Label();
        lblServerValheimInstalledInfo = new Label();
        lblServerInstalledValheim = new Label();
        panelServerUsage = new Panel();
        progressBarRAMValheim = new ProgressBar();
        lblRAMUsageInfoValheim = new Label();
        lblRAMUsageValheim = new Label();
        lblCPUUsageInfo = new Label();
        lblCPUUsage = new Label();
        panelTopBar.SuspendLayout();
        panelValheimBar.SuspendLayout();
        panelServerUsage.SuspendLayout();
        SuspendLayout();
        // 
        // panelTopBar
        // 
        panelTopBar.Controls.Add(lblSteamCMDInstalledINfo);
        panelTopBar.Controls.Add(label4);
        panelTopBar.Controls.Add(label3);
        panelTopBar.Controls.Add(lblCpuNumberOfCoresInfo);
        panelTopBar.Controls.Add(label2);
        panelTopBar.Controls.Add(lblCpuNameInfo);
        panelTopBar.Controls.Add(lblRamUsageSystemInfo);
        panelTopBar.Controls.Add(lblRamUsageSystem);
        panelTopBar.Dock = DockStyle.Top;
        panelTopBar.Location = new Point(0, 0);
        panelTopBar.Name = "panelTopBar";
        panelTopBar.Size = new Size(864, 83);
        panelTopBar.TabIndex = 0;
        // 
        // lblSteamCMDInstalledINfo
        // 
        lblSteamCMDInstalledINfo.AutoSize = true;
        lblSteamCMDInstalledINfo.BackColor = Color.Transparent;
        lblSteamCMDInstalledINfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblSteamCMDInstalledINfo.ForeColor = Color.White;
        lblSteamCMDInstalledINfo.Location = new Point(563, 0);
        lblSteamCMDInstalledINfo.Name = "lblSteamCMDInstalledINfo";
        lblSteamCMDInstalledINfo.Size = new Size(88, 17);
        lblSteamCMDInstalledINfo.TabIndex = 9;
        lblSteamCMDInstalledINfo.Text = "Not Installed";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        label4.ForeColor = Color.White;
        label4.Location = new Point(477, 0);
        label4.Name = "label4";
        label4.Size = new Size(80, 17);
        label4.TabIndex = 8;
        label4.Text = "SteamCMD:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        label3.ForeColor = Color.White;
        label3.Location = new Point(5, 21);
        label3.Name = "label3";
        label3.Size = new Size(46, 17);
        label3.TabIndex = 7;
        label3.Text = "Cores:";
        // 
        // lblCpuNumberOfCoresInfo
        // 
        lblCpuNumberOfCoresInfo.AutoSize = true;
        lblCpuNumberOfCoresInfo.BackColor = Color.Transparent;
        lblCpuNumberOfCoresInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblCpuNumberOfCoresInfo.ForeColor = Color.White;
        lblCpuNumberOfCoresInfo.Location = new Point(57, 21);
        lblCpuNumberOfCoresInfo.Name = "lblCpuNumberOfCoresInfo";
        lblCpuNumberOfCoresInfo.Size = new Size(0, 17);
        lblCpuNumberOfCoresInfo.TabIndex = 6;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        label2.ForeColor = Color.White;
        label2.Location = new Point(14, 0);
        label2.Name = "label2";
        label2.Size = new Size(37, 17);
        label2.TabIndex = 5;
        label2.Text = "CPU:";
        // 
        // lblCpuNameInfo
        // 
        lblCpuNameInfo.AutoSize = true;
        lblCpuNameInfo.BackColor = Color.Transparent;
        lblCpuNameInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblCpuNameInfo.ForeColor = Color.White;
        lblCpuNameInfo.Location = new Point(57, 0);
        lblCpuNameInfo.Name = "lblCpuNameInfo";
        lblCpuNameInfo.Size = new Size(0, 17);
        lblCpuNameInfo.TabIndex = 4;
        // 
        // lblRamUsageSystemInfo
        // 
        lblRamUsageSystemInfo.AutoSize = true;
        lblRamUsageSystemInfo.BackColor = Color.Transparent;
        lblRamUsageSystemInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRamUsageSystemInfo.ForeColor = Color.White;
        lblRamUsageSystemInfo.Location = new Point(57, 44);
        lblRamUsageSystemInfo.Name = "lblRamUsageSystemInfo";
        lblRamUsageSystemInfo.Size = new Size(84, 17);
        lblRamUsageSystemInfo.TabIndex = 3;
        lblRamUsageSystemInfo.Text = "0 MB / 1 MB";
        // 
        // lblRamUsageSystem
        // 
        lblRamUsageSystem.AutoSize = true;
        lblRamUsageSystem.BackColor = Color.Transparent;
        lblRamUsageSystem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRamUsageSystem.ForeColor = Color.White;
        lblRamUsageSystem.Location = new Point(10, 44);
        lblRamUsageSystem.Name = "lblRamUsageSystem";
        lblRamUsageSystem.Size = new Size(41, 17);
        lblRamUsageSystem.TabIndex = 2;
        lblRamUsageSystem.Text = "RAM:";
        // 
        // label1
        // 
        label1.Dock = DockStyle.Top;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
        label1.ForeColor = Color.White;
        label1.ImeMode = ImeMode.NoControl;
        label1.Location = new Point(0, 0);
        label1.Margin = new Padding(20, 0, 3, 0);
        label1.Name = "label1";
        label1.Padding = new Padding(25, 0, 0, 0);
        label1.Size = new Size(864, 39);
        label1.TabIndex = 1;
        label1.Text = "Valheim Server";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panelValheimBar
        // 
        panelValheimBar.Controls.Add(label1);
        panelValheimBar.Controls.Add(lblServerValheimPathInfo);
        panelValheimBar.Controls.Add(lblServerPath);
        panelValheimBar.Controls.Add(lblServerRunning);
        panelValheimBar.Controls.Add(lblServerValheimRunningInfo);
        panelValheimBar.Controls.Add(lblServerValheimInstalledInfo);
        panelValheimBar.Controls.Add(lblServerInstalledValheim);
        panelValheimBar.Controls.Add(panelServerUsage);
        panelValheimBar.Dock = DockStyle.Top;
        panelValheimBar.Location = new Point(0, 83);
        panelValheimBar.Name = "panelValheimBar";
        panelValheimBar.Size = new Size(864, 105);
        panelValheimBar.TabIndex = 1;
        // 
        // lblServerValheimPathInfo
        // 
        lblServerValheimPathInfo.AutoSize = true;
        lblServerValheimPathInfo.BackColor = Color.Transparent;
        lblServerValheimPathInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerValheimPathInfo.ForeColor = Color.White;
        lblServerValheimPathInfo.ImeMode = ImeMode.NoControl;
        lblServerValheimPathInfo.Location = new Point(87, 80);
        lblServerValheimPathInfo.Name = "lblServerValheimPathInfo";
        lblServerValheimPathInfo.Size = new Size(38, 17);
        lblServerValheimPathInfo.TabIndex = 5;
        lblServerValheimPathInfo.Text = "C:\\...";
        // 
        // lblServerPath
        // 
        lblServerPath.AutoSize = true;
        lblServerPath.BackColor = Color.Transparent;
        lblServerPath.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPath.ForeColor = Color.White;
        lblServerPath.ImeMode = ImeMode.NoControl;
        lblServerPath.Location = new Point(5, 80);
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
        lblServerRunning.ImeMode = ImeMode.NoControl;
        lblServerRunning.Location = new Point(21, 59);
        lblServerRunning.Name = "lblServerRunning";
        lblServerRunning.Size = new Size(64, 17);
        lblServerRunning.TabIndex = 3;
        lblServerRunning.Text = "Running:";
        // 
        // lblServerValheimRunningInfo
        // 
        lblServerValheimRunningInfo.AutoSize = true;
        lblServerValheimRunningInfo.BackColor = Color.Transparent;
        lblServerValheimRunningInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerValheimRunningInfo.ForeColor = Color.White;
        lblServerValheimRunningInfo.ImeMode = ImeMode.NoControl;
        lblServerValheimRunningInfo.Location = new Point(87, 59);
        lblServerValheimRunningInfo.Name = "lblServerValheimRunningInfo";
        lblServerValheimRunningInfo.Size = new Size(51, 17);
        lblServerValheimRunningInfo.TabIndex = 2;
        lblServerValheimRunningInfo.Text = "Offline";
        // 
        // lblServerValheimInstalledInfo
        // 
        lblServerValheimInstalledInfo.AutoSize = true;
        lblServerValheimInstalledInfo.BackColor = Color.Transparent;
        lblServerValheimInstalledInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerValheimInstalledInfo.ForeColor = Color.White;
        lblServerValheimInstalledInfo.ImeMode = ImeMode.NoControl;
        lblServerValheimInstalledInfo.Location = new Point(87, 38);
        lblServerValheimInstalledInfo.Name = "lblServerValheimInstalledInfo";
        lblServerValheimInstalledInfo.Size = new Size(26, 17);
        lblServerValheimInstalledInfo.TabIndex = 1;
        lblServerValheimInstalledInfo.Text = "No";
        // 
        // lblServerInstalledValheim
        // 
        lblServerInstalledValheim.AutoSize = true;
        lblServerInstalledValheim.BackColor = Color.Transparent;
        lblServerInstalledValheim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerInstalledValheim.ForeColor = Color.White;
        lblServerInstalledValheim.ImeMode = ImeMode.NoControl;
        lblServerInstalledValheim.Location = new Point(19, 38);
        lblServerInstalledValheim.Name = "lblServerInstalledValheim";
        lblServerInstalledValheim.Size = new Size(65, 17);
        lblServerInstalledValheim.TabIndex = 0;
        lblServerInstalledValheim.Text = "Installed:";
        // 
        // panelServerUsage
        // 
        panelServerUsage.Controls.Add(progressBarRAMValheim);
        panelServerUsage.Controls.Add(lblRAMUsageInfoValheim);
        panelServerUsage.Controls.Add(lblRAMUsageValheim);
        panelServerUsage.Controls.Add(lblCPUUsageInfo);
        panelServerUsage.Controls.Add(lblCPUUsage);
        panelServerUsage.Location = new Point(477, 42);
        panelServerUsage.Name = "panelServerUsage";
        panelServerUsage.Size = new Size(373, 55);
        panelServerUsage.TabIndex = 7;
        // 
        // progressBarRAMValheim
        // 
        progressBarRAMValheim.BackColor = Color.Black;
        progressBarRAMValheim.ForeColor = Color.Firebrick;
        progressBarRAMValheim.ImeMode = ImeMode.NoControl;
        progressBarRAMValheim.Location = new Point(222, 32);
        progressBarRAMValheim.Name = "progressBarRAMValheim";
        progressBarRAMValheim.Size = new Size(142, 15);
        progressBarRAMValheim.Step = 1;
        progressBarRAMValheim.TabIndex = 17;
        // 
        // lblRAMUsageInfoValheim
        // 
        lblRAMUsageInfoValheim.AutoSize = true;
        lblRAMUsageInfoValheim.BackColor = Color.Transparent;
        lblRAMUsageInfoValheim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsageInfoValheim.ForeColor = Color.White;
        lblRAMUsageInfoValheim.ImeMode = ImeMode.NoControl;
        lblRAMUsageInfoValheim.Location = new Point(87, 32);
        lblRAMUsageInfoValheim.Name = "lblRAMUsageInfoValheim";
        lblRAMUsageInfoValheim.Size = new Size(84, 17);
        lblRAMUsageInfoValheim.TabIndex = 16;
        lblRAMUsageInfoValheim.Text = "0 MB / 0 MB";
        // 
        // lblRAMUsageValheim
        // 
        lblRAMUsageValheim.AutoSize = true;
        lblRAMUsageValheim.BackColor = Color.Transparent;
        lblRAMUsageValheim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsageValheim.ForeColor = Color.White;
        lblRAMUsageValheim.ImeMode = ImeMode.NoControl;
        lblRAMUsageValheim.Location = new Point(3, 32);
        lblRAMUsageValheim.Name = "lblRAMUsageValheim";
        lblRAMUsageValheim.Size = new Size(86, 17);
        lblRAMUsageValheim.TabIndex = 15;
        lblRAMUsageValheim.Text = "RAM Usage: ";
        // 
        // lblCPUUsageInfo
        // 
        lblCPUUsageInfo.AutoSize = true;
        lblCPUUsageInfo.BackColor = Color.Transparent;
        lblCPUUsageInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblCPUUsageInfo.ForeColor = Color.White;
        lblCPUUsageInfo.ImeMode = ImeMode.NoControl;
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
        lblCPUUsage.ImeMode = ImeMode.NoControl;
        lblCPUUsage.Location = new Point(7, 7);
        lblCPUUsage.Name = "lblCPUUsage";
        lblCPUUsage.Size = new Size(82, 17);
        lblCPUUsage.TabIndex = 13;
        lblCPUUsage.Text = "CPU Usage: ";
        lblCPUUsage.Visible = false;
        // 
        // FormHome
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(864, 491);
        Controls.Add(panelValheimBar);
        Controls.Add(panelTopBar);
        Name = "FormHome";
        Text = "Dashbord";
        Load += FormHome_LoadAsync;
        panelTopBar.ResumeLayout(false);
        panelTopBar.PerformLayout();
        panelValheimBar.ResumeLayout(false);
        panelValheimBar.PerformLayout();
        panelServerUsage.ResumeLayout(false);
        panelServerUsage.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Panel panelTopBar;
    private Label label1;
    private Panel panelValheimBar;
    private Label lblServerValheimPathInfo;
    private Panel panelServerUsage;
    private ProgressBar progressBarRAMValheim;
    private Label lblRAMUsageInfoValheim;
    private Label lblRAMUsageValheim;
    private Label lblCPUUsageInfo;
    private Label lblCPUUsage;
    private Label lblServerPath;
    private Label lblServerRunning;
    private Label lblServerValheimRunningInfo;
    private Label lblServerValheimInstalledInfo;
    private Label lblServerInstalledValheim;
    private Label lblRamUsageSystemInfo;
    private Label lblRamUsageSystem;
    private Label lblCpuNameInfo;
    private Label label2;
    private Label lblCpuNumberOfCoresInfo;
    private Label label3;
    private Label label4;
    private Label lblSteamCMDInstalledINfo;
}