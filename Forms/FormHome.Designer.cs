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
        label1 = new Label();
        panelValheimBar = new Panel();
        lblValheimLastUpdateInfo = new Label();
        lblValheimLastUpdate = new Label();
        progressBarRAMValheim = new ProgressBar();
        lblRAMUsageInfoValheim = new Label();
        lblRAMUsageValheim = new Label();
        lblServerValheimPathInfo = new Label();
        lblServerPathValheim = new Label();
        lblServerRunningValheim = new Label();
        lblServerValheimRunningInfo = new Label();
        lblServerValheimInstalledInfo = new Label();
        lblServerInstalledValheim = new Label();
        panel1 = new Panel();
        lblEnshroudedLastUpdateInfo = new Label();
        progressBarRAMEnshrouded = new ProgressBar();
        lblEnshroudedLastUpdate = new Label();
        lblRAMUsageEnshroudedInfo = new Label();
        lblRAMUsageEnshrouded = new Label();
        label2 = new Label();
        lblServerPathEnshroudedInfo = new Label();
        lblServerPathEnshrouded = new Label();
        lblServerRunningEnshrouded = new Label();
        lblServerRunningEnshroudedInfo = new Label();
        lblServerInstalledEnshroudedInfo = new Label();
        lblServerInstalledEnshrouded = new Label();
        panelValheimBar.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
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
        panelValheimBar.Controls.Add(lblValheimLastUpdateInfo);
        panelValheimBar.Controls.Add(lblValheimLastUpdate);
        panelValheimBar.Controls.Add(progressBarRAMValheim);
        panelValheimBar.Controls.Add(lblRAMUsageInfoValheim);
        panelValheimBar.Controls.Add(lblRAMUsageValheim);
        panelValheimBar.Controls.Add(label1);
        panelValheimBar.Controls.Add(lblServerValheimPathInfo);
        panelValheimBar.Controls.Add(lblServerPathValheim);
        panelValheimBar.Controls.Add(lblServerRunningValheim);
        panelValheimBar.Controls.Add(lblServerValheimRunningInfo);
        panelValheimBar.Controls.Add(lblServerValheimInstalledInfo);
        panelValheimBar.Controls.Add(lblServerInstalledValheim);
        panelValheimBar.Dock = DockStyle.Top;
        panelValheimBar.Location = new Point(0, 0);
        panelValheimBar.Name = "panelValheimBar";
        panelValheimBar.Size = new Size(864, 105);
        panelValheimBar.TabIndex = 1;
        // 
        // lblValheimLastUpdateInfo
        // 
        lblValheimLastUpdateInfo.AutoSize = true;
        lblValheimLastUpdateInfo.BackColor = Color.Transparent;
        lblValheimLastUpdateInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblValheimLastUpdateInfo.ForeColor = Color.White;
        lblValheimLastUpdateInfo.ImeMode = ImeMode.NoControl;
        lblValheimLastUpdateInfo.Location = new Point(597, 38);
        lblValheimLastUpdateInfo.Name = "lblValheimLastUpdateInfo";
        lblValheimLastUpdateInfo.Size = new Size(72, 17);
        lblValheimLastUpdateInfo.TabIndex = 21;
        lblValheimLastUpdateInfo.Text = "01.01.2000";
        // 
        // lblValheimLastUpdate
        // 
        lblValheimLastUpdate.AutoSize = true;
        lblValheimLastUpdate.BackColor = Color.Transparent;
        lblValheimLastUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblValheimLastUpdate.ForeColor = Color.White;
        lblValheimLastUpdate.ImeMode = ImeMode.NoControl;
        lblValheimLastUpdate.Location = new Point(506, 38);
        lblValheimLastUpdate.Name = "lblValheimLastUpdate";
        lblValheimLastUpdate.Size = new Size(85, 17);
        lblValheimLastUpdate.TabIndex = 21;
        lblValheimLastUpdate.Text = "Last Update:";
        // 
        // progressBarRAMValheim
        // 
        progressBarRAMValheim.BackColor = Color.Black;
        progressBarRAMValheim.ForeColor = Color.Firebrick;
        progressBarRAMValheim.ImeMode = ImeMode.NoControl;
        progressBarRAMValheim.Location = new Point(313, 59);
        progressBarRAMValheim.Name = "progressBarRAMValheim";
        progressBarRAMValheim.Size = new Size(142, 10);
        progressBarRAMValheim.Step = 1;
        progressBarRAMValheim.TabIndex = 20;
        // 
        // lblRAMUsageInfoValheim
        // 
        lblRAMUsageInfoValheim.AutoSize = true;
        lblRAMUsageInfoValheim.BackColor = Color.Transparent;
        lblRAMUsageInfoValheim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsageInfoValheim.ForeColor = Color.White;
        lblRAMUsageInfoValheim.ImeMode = ImeMode.NoControl;
        lblRAMUsageInfoValheim.Location = new Point(313, 38);
        lblRAMUsageInfoValheim.Name = "lblRAMUsageInfoValheim";
        lblRAMUsageInfoValheim.Size = new Size(84, 17);
        lblRAMUsageInfoValheim.TabIndex = 19;
        lblRAMUsageInfoValheim.Text = "0 MB / 0 MB";
        // 
        // lblRAMUsageValheim
        // 
        lblRAMUsageValheim.AutoSize = true;
        lblRAMUsageValheim.BackColor = Color.Transparent;
        lblRAMUsageValheim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsageValheim.ForeColor = Color.White;
        lblRAMUsageValheim.ImeMode = ImeMode.NoControl;
        lblRAMUsageValheim.Location = new Point(229, 38);
        lblRAMUsageValheim.Name = "lblRAMUsageValheim";
        lblRAMUsageValheim.Size = new Size(86, 17);
        lblRAMUsageValheim.TabIndex = 18;
        lblRAMUsageValheim.Text = "RAM Usage: ";
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
        // lblServerPathValheim
        // 
        lblServerPathValheim.AutoSize = true;
        lblServerPathValheim.BackColor = Color.Transparent;
        lblServerPathValheim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPathValheim.ForeColor = Color.White;
        lblServerPathValheim.ImeMode = ImeMode.NoControl;
        lblServerPathValheim.Location = new Point(5, 80);
        lblServerPathValheim.Name = "lblServerPathValheim";
        lblServerPathValheim.Size = new Size(83, 17);
        lblServerPathValheim.TabIndex = 4;
        lblServerPathValheim.Text = "Server Path:";
        // 
        // lblServerRunningValheim
        // 
        lblServerRunningValheim.AutoSize = true;
        lblServerRunningValheim.BackColor = Color.Transparent;
        lblServerRunningValheim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerRunningValheim.ForeColor = Color.White;
        lblServerRunningValheim.ImeMode = ImeMode.NoControl;
        lblServerRunningValheim.Location = new Point(21, 59);
        lblServerRunningValheim.Name = "lblServerRunningValheim";
        lblServerRunningValheim.Size = new Size(64, 17);
        lblServerRunningValheim.TabIndex = 3;
        lblServerRunningValheim.Text = "Running:";
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
        // panel1
        // 
        panel1.Controls.Add(lblEnshroudedLastUpdateInfo);
        panel1.Controls.Add(progressBarRAMEnshrouded);
        panel1.Controls.Add(lblEnshroudedLastUpdate);
        panel1.Controls.Add(lblRAMUsageEnshroudedInfo);
        panel1.Controls.Add(lblRAMUsageEnshrouded);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(lblServerPathEnshroudedInfo);
        panel1.Controls.Add(lblServerPathEnshrouded);
        panel1.Controls.Add(lblServerRunningEnshrouded);
        panel1.Controls.Add(lblServerRunningEnshroudedInfo);
        panel1.Controls.Add(lblServerInstalledEnshroudedInfo);
        panel1.Controls.Add(lblServerInstalledEnshrouded);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 105);
        panel1.Name = "panel1";
        panel1.Size = new Size(864, 105);
        panel1.TabIndex = 2;
        // 
        // lblEnshroudedLastUpdateInfo
        // 
        lblEnshroudedLastUpdateInfo.AutoSize = true;
        lblEnshroudedLastUpdateInfo.BackColor = Color.Transparent;
        lblEnshroudedLastUpdateInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblEnshroudedLastUpdateInfo.ForeColor = Color.White;
        lblEnshroudedLastUpdateInfo.ImeMode = ImeMode.NoControl;
        lblEnshroudedLastUpdateInfo.Location = new Point(597, 38);
        lblEnshroudedLastUpdateInfo.Name = "lblEnshroudedLastUpdateInfo";
        lblEnshroudedLastUpdateInfo.Size = new Size(72, 17);
        lblEnshroudedLastUpdateInfo.TabIndex = 21;
        lblEnshroudedLastUpdateInfo.Text = "01.01.2000";
        // 
        // progressBarRAMEnshrouded
        // 
        progressBarRAMEnshrouded.BackColor = Color.Black;
        progressBarRAMEnshrouded.ForeColor = Color.Firebrick;
        progressBarRAMEnshrouded.ImeMode = ImeMode.NoControl;
        progressBarRAMEnshrouded.Location = new Point(313, 59);
        progressBarRAMEnshrouded.Name = "progressBarRAMEnshrouded";
        progressBarRAMEnshrouded.Size = new Size(142, 10);
        progressBarRAMEnshrouded.Step = 1;
        progressBarRAMEnshrouded.TabIndex = 20;
        // 
        // lblEnshroudedLastUpdate
        // 
        lblEnshroudedLastUpdate.AutoSize = true;
        lblEnshroudedLastUpdate.BackColor = Color.Transparent;
        lblEnshroudedLastUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblEnshroudedLastUpdate.ForeColor = Color.White;
        lblEnshroudedLastUpdate.ImeMode = ImeMode.NoControl;
        lblEnshroudedLastUpdate.Location = new Point(506, 38);
        lblEnshroudedLastUpdate.Name = "lblEnshroudedLastUpdate";
        lblEnshroudedLastUpdate.Size = new Size(85, 17);
        lblEnshroudedLastUpdate.TabIndex = 21;
        lblEnshroudedLastUpdate.Text = "Last Update:";
        // 
        // lblRAMUsageEnshroudedInfo
        // 
        lblRAMUsageEnshroudedInfo.AutoSize = true;
        lblRAMUsageEnshroudedInfo.BackColor = Color.Transparent;
        lblRAMUsageEnshroudedInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsageEnshroudedInfo.ForeColor = Color.White;
        lblRAMUsageEnshroudedInfo.ImeMode = ImeMode.NoControl;
        lblRAMUsageEnshroudedInfo.Location = new Point(313, 38);
        lblRAMUsageEnshroudedInfo.Name = "lblRAMUsageEnshroudedInfo";
        lblRAMUsageEnshroudedInfo.Size = new Size(84, 17);
        lblRAMUsageEnshroudedInfo.TabIndex = 19;
        lblRAMUsageEnshroudedInfo.Text = "0 MB / 0 MB";
        // 
        // lblRAMUsageEnshrouded
        // 
        lblRAMUsageEnshrouded.AutoSize = true;
        lblRAMUsageEnshrouded.BackColor = Color.Transparent;
        lblRAMUsageEnshrouded.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblRAMUsageEnshrouded.ForeColor = Color.White;
        lblRAMUsageEnshrouded.ImeMode = ImeMode.NoControl;
        lblRAMUsageEnshrouded.Location = new Point(229, 38);
        lblRAMUsageEnshrouded.Name = "lblRAMUsageEnshrouded";
        lblRAMUsageEnshrouded.Size = new Size(86, 17);
        lblRAMUsageEnshrouded.TabIndex = 18;
        lblRAMUsageEnshrouded.Text = "RAM Usage: ";
        // 
        // label2
        // 
        label2.Dock = DockStyle.Top;
        label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
        label2.ForeColor = Color.White;
        label2.ImeMode = ImeMode.NoControl;
        label2.Location = new Point(0, 0);
        label2.Margin = new Padding(20, 0, 3, 0);
        label2.Name = "label2";
        label2.Padding = new Padding(25, 0, 0, 0);
        label2.Size = new Size(864, 39);
        label2.TabIndex = 1;
        label2.Text = "Enshrouded Server";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblServerPathEnshroudedInfo
        // 
        lblServerPathEnshroudedInfo.AutoSize = true;
        lblServerPathEnshroudedInfo.BackColor = Color.Transparent;
        lblServerPathEnshroudedInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPathEnshroudedInfo.ForeColor = Color.White;
        lblServerPathEnshroudedInfo.ImeMode = ImeMode.NoControl;
        lblServerPathEnshroudedInfo.Location = new Point(87, 80);
        lblServerPathEnshroudedInfo.Name = "lblServerPathEnshroudedInfo";
        lblServerPathEnshroudedInfo.Size = new Size(38, 17);
        lblServerPathEnshroudedInfo.TabIndex = 5;
        lblServerPathEnshroudedInfo.Text = "C:\\...";
        // 
        // lblServerPathEnshrouded
        // 
        lblServerPathEnshrouded.AutoSize = true;
        lblServerPathEnshrouded.BackColor = Color.Transparent;
        lblServerPathEnshrouded.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerPathEnshrouded.ForeColor = Color.White;
        lblServerPathEnshrouded.ImeMode = ImeMode.NoControl;
        lblServerPathEnshrouded.Location = new Point(5, 80);
        lblServerPathEnshrouded.Name = "lblServerPathEnshrouded";
        lblServerPathEnshrouded.Size = new Size(83, 17);
        lblServerPathEnshrouded.TabIndex = 4;
        lblServerPathEnshrouded.Text = "Server Path:";
        // 
        // lblServerRunningEnshrouded
        // 
        lblServerRunningEnshrouded.AutoSize = true;
        lblServerRunningEnshrouded.BackColor = Color.Transparent;
        lblServerRunningEnshrouded.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerRunningEnshrouded.ForeColor = Color.White;
        lblServerRunningEnshrouded.ImeMode = ImeMode.NoControl;
        lblServerRunningEnshrouded.Location = new Point(21, 59);
        lblServerRunningEnshrouded.Name = "lblServerRunningEnshrouded";
        lblServerRunningEnshrouded.Size = new Size(64, 17);
        lblServerRunningEnshrouded.TabIndex = 3;
        lblServerRunningEnshrouded.Text = "Running:";
        // 
        // lblServerRunningEnshroudedInfo
        // 
        lblServerRunningEnshroudedInfo.AutoSize = true;
        lblServerRunningEnshroudedInfo.BackColor = Color.Transparent;
        lblServerRunningEnshroudedInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerRunningEnshroudedInfo.ForeColor = Color.White;
        lblServerRunningEnshroudedInfo.ImeMode = ImeMode.NoControl;
        lblServerRunningEnshroudedInfo.Location = new Point(87, 59);
        lblServerRunningEnshroudedInfo.Name = "lblServerRunningEnshroudedInfo";
        lblServerRunningEnshroudedInfo.Size = new Size(51, 17);
        lblServerRunningEnshroudedInfo.TabIndex = 2;
        lblServerRunningEnshroudedInfo.Text = "Offline";
        // 
        // lblServerInstalledEnshroudedInfo
        // 
        lblServerInstalledEnshroudedInfo.AutoSize = true;
        lblServerInstalledEnshroudedInfo.BackColor = Color.Transparent;
        lblServerInstalledEnshroudedInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerInstalledEnshroudedInfo.ForeColor = Color.White;
        lblServerInstalledEnshroudedInfo.ImeMode = ImeMode.NoControl;
        lblServerInstalledEnshroudedInfo.Location = new Point(87, 38);
        lblServerInstalledEnshroudedInfo.Name = "lblServerInstalledEnshroudedInfo";
        lblServerInstalledEnshroudedInfo.Size = new Size(26, 17);
        lblServerInstalledEnshroudedInfo.TabIndex = 1;
        lblServerInstalledEnshroudedInfo.Text = "No";
        // 
        // lblServerInstalledEnshrouded
        // 
        lblServerInstalledEnshrouded.AutoSize = true;
        lblServerInstalledEnshrouded.BackColor = Color.Transparent;
        lblServerInstalledEnshrouded.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblServerInstalledEnshrouded.ForeColor = Color.White;
        lblServerInstalledEnshrouded.ImeMode = ImeMode.NoControl;
        lblServerInstalledEnshrouded.Location = new Point(19, 38);
        lblServerInstalledEnshrouded.Name = "lblServerInstalledEnshrouded";
        lblServerInstalledEnshrouded.Size = new Size(65, 17);
        lblServerInstalledEnshrouded.TabIndex = 0;
        lblServerInstalledEnshrouded.Text = "Installed:";
        // 
        // FormHome
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(864, 491);
        Controls.Add(panel1);
        Controls.Add(panelValheimBar);
        Name = "FormHome";
        Text = "Home";
        panelValheimBar.ResumeLayout(false);
        panelValheimBar.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Label label1;
    private Panel panelValheimBar;
    private Label lblServerValheimPathInfo;
    private Label lblServerPathValheim;
    private Label lblServerRunningValheim;
    private Label lblServerValheimRunningInfo;
    private Label lblServerValheimInstalledInfo;
    private Label lblServerInstalledValheim;
    private Panel panel1;
    private Label label2;
    private Label lblServerPathEnshroudedInfo;
    private Label lblServerPathEnshrouded;
    private Label lblServerRunningEnshrouded;
    private Label lblServerRunningEnshroudedInfo;
    private Label lblServerInstalledEnshroudedInfo;
    private Label lblServerInstalledEnshrouded;
    private Label lblEnshroudedLastUpdate;
    private Label lblEnshroudedLastUpdateInfo;
    private ProgressBar progressBarRAMValheim;
    private Label lblRAMUsageInfoValheim;
    private Label lblRAMUsageValheim;
    private ProgressBar progressBarRAMEnshrouded;
    private Label lblRAMUsageEnshroudedInfo;
    private Label lblRAMUsageEnshrouded;
    private Label lblValheimLastUpdateInfo;
    private Label lblValheimLastUpdate;
}