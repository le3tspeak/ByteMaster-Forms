
namespace Game_Server_Manager.Forms;

partial class FormDownloader
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
        btnResume = new FontAwesome.Sharp.IconButton();
        lblURL = new Label();
        lblStatus = new Label();
        lblStatusInfo = new Label();
        progressBar = new ProgressBar();
        lblPercent = new Label();
        btnPause = new FontAwesome.Sharp.IconButton();
        btnStart = new FontAwesome.Sharp.IconButton();
        lblDownloaded = new Label();
        lblSpeed = new Label();
        lblDownloadedMB = new Label();
        lblSpeedStatus = new Label();
        btnAbort = new FontAwesome.Sharp.IconButton();
        lblURLInfo = new Label();
        SuspendLayout();
        // 
        // btnResume
        // 
        btnResume.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnResume.BackColor = Color.Transparent;
        btnResume.FlatAppearance.BorderSize = 0;
        btnResume.FlatStyle = FlatStyle.Flat;
        btnResume.ForeColor = Color.Transparent;
        btnResume.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
        btnResume.IconColor = Color.White;
        btnResume.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnResume.Location = new Point(659, 119);
        btnResume.Name = "btnResume";
        btnResume.Size = new Size(54, 54);
        btnResume.TabIndex = 0;
        btnResume.UseVisualStyleBackColor = false;
        btnResume.Visible = false;
        btnResume.Click += btnResume_Click;
        // 
        // lblURL
        // 
        lblURL.AutoSize = true;
        lblURL.Location = new Point(26, 18);
        lblURL.Name = "lblURL";
        lblURL.Size = new Size(31, 15);
        lblURL.TabIndex = 1;
        lblURL.Text = "URL:";
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(26, 46);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(42, 15);
        lblStatus.TabIndex = 3;
        lblStatus.Text = "Status:";
        // 
        // lblStatusInfo
        // 
        lblStatusInfo.AutoSize = true;
        lblStatusInfo.Location = new Point(74, 46);
        lblStatusInfo.Name = "lblStatusInfo";
        lblStatusInfo.Size = new Size(22, 15);
        lblStatusInfo.TabIndex = 4;
        lblStatusInfo.Text = "???";
        // 
        // progressBar
        // 
        progressBar.BackColor = Color.Black;
        progressBar.Location = new Point(26, 73);
        progressBar.Name = "progressBar";
        progressBar.Size = new Size(747, 23);
        progressBar.Step = 5;
        progressBar.TabIndex = 5;
        // 
        // lblPercent
        // 
        lblPercent.AutoSize = true;
        lblPercent.Location = new Point(750, 46);
        lblPercent.Name = "lblPercent";
        lblPercent.Size = new Size(23, 15);
        lblPercent.TabIndex = 6;
        lblPercent.Text = "0%";
        // 
        // btnPause
        // 
        btnPause.BackColor = Color.Transparent;
        btnPause.FlatAppearance.BorderSize = 0;
        btnPause.FlatStyle = FlatStyle.Flat;
        btnPause.ForeColor = Color.Transparent;
        btnPause.IconChar = FontAwesome.Sharp.IconChar.PauseCircle;
        btnPause.IconColor = Color.White;
        btnPause.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnPause.Location = new Point(659, 119);
        btnPause.Name = "btnPause";
        btnPause.Size = new Size(54, 54);
        btnPause.TabIndex = 7;
        btnPause.UseVisualStyleBackColor = false;
        btnPause.Click += btnPause_Click;
        // 
        // btnStart
        // 
        btnStart.ForeColor = Color.Black;
        btnStart.IconChar = FontAwesome.Sharp.IconChar.None;
        btnStart.IconColor = Color.Black;
        btnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnStart.Location = new Point(204, 135);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(121, 23);
        btnStart.TabIndex = 8;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Visible = false;
        btnStart.Click += btnStart_Click;
        // 
        // lblDownloaded
        // 
        lblDownloaded.AutoSize = true;
        lblDownloaded.Location = new Point(26, 116);
        lblDownloaded.Name = "lblDownloaded";
        lblDownloaded.Size = new Size(77, 15);
        lblDownloaded.TabIndex = 9;
        lblDownloaded.Text = "Downloaded:";
        // 
        // lblSpeed
        // 
        lblSpeed.AutoSize = true;
        lblSpeed.Location = new Point(392, 116);
        lblSpeed.Name = "lblSpeed";
        lblSpeed.Size = new Size(45, 15);
        lblSpeed.TabIndex = 10;
        lblSpeed.Text = "Speed: ";
        // 
        // lblDownloadedMB
        // 
        lblDownloadedMB.AutoSize = true;
        lblDownloadedMB.Location = new Point(109, 116);
        lblDownloadedMB.Name = "lblDownloadedMB";
        lblDownloadedMB.Size = new Size(34, 15);
        lblDownloadedMB.TabIndex = 11;
        lblDownloadedMB.Text = "0 MB";
        // 
        // lblSpeedStatus
        // 
        lblSpeedStatus.AutoSize = true;
        lblSpeedStatus.Location = new Point(450, 116);
        lblSpeedStatus.Name = "lblSpeedStatus";
        lblSpeedStatus.Size = new Size(44, 15);
        lblSpeedStatus.TabIndex = 12;
        lblSpeedStatus.Text = "0 MB/s";
        // 
        // btnAbort
        // 
        btnAbort.BackColor = Color.Transparent;
        btnAbort.FlatAppearance.BorderSize = 0;
        btnAbort.FlatStyle = FlatStyle.Flat;
        btnAbort.ForeColor = Color.Transparent;
        btnAbort.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
        btnAbort.IconColor = Color.White;
        btnAbort.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnAbort.Location = new Point(719, 119);
        btnAbort.Name = "btnAbort";
        btnAbort.Size = new Size(54, 54);
        btnAbort.TabIndex = 13;
        btnAbort.UseVisualStyleBackColor = false;
        btnAbort.Click += btnAbort_Click;
        // 
        // lblURLInfo
        // 
        lblURLInfo.AutoSize = true;
        lblURLInfo.Location = new Point(63, 18);
        lblURLInfo.MaximumSize = new Size(700, 0);
        lblURLInfo.Name = "lblURLInfo";
        lblURLInfo.Size = new Size(47, 15);
        lblURLInfo.TabIndex = 14;
        lblURLInfo.Text = "https://";
        // 
        // FormDownloader
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(800, 185);
        Controls.Add(lblURLInfo);
        Controls.Add(btnAbort);
        Controls.Add(lblSpeedStatus);
        Controls.Add(lblDownloadedMB);
        Controls.Add(lblSpeed);
        Controls.Add(lblDownloaded);
        Controls.Add(btnStart);
        Controls.Add(btnPause);
        Controls.Add(lblPercent);
        Controls.Add(progressBar);
        Controls.Add(lblStatusInfo);
        Controls.Add(lblStatus);
        Controls.Add(lblURL);
        Controls.Add(btnResume);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormDownloader";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "FormDownloader";
        ResumeLayout(false);
        PerformLayout();
    }



    #endregion

    private FontAwesome.Sharp.IconButton btnResume;
    private Label lblURL;
    private Label lblStatus;
    private Label lblStatusInfo;
    private ProgressBar progressBar;
    private Label lblPercent;
    private FontAwesome.Sharp.IconButton btnPause;
    private FontAwesome.Sharp.IconButton btnStart;
    private Label lblDownloaded;
    private Label lblSpeed;
    private Label lblDownloadedMB;
    private Label lblSpeedStatus;
    private FontAwesome.Sharp.IconButton btnAbort;
    private Label lblURLInfo;
}