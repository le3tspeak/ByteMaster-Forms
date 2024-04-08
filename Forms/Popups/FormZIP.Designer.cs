namespace Game_Server_Manager.Forms;

partial class FormZIP
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
        progressBar = new ProgressBar();
        lblZIPPathInfo = new Label();
        lblZIPPath = new Label();
        lblStatusInfo = new Label();
        lblStatus = new Label();
        lblFilesInfo = new Label();
        lblPercent = new Label();
        SuspendLayout();
        // 
        // progressBar
        // 
        progressBar.BackColor = Color.Black;
        progressBar.Location = new Point(25, 55);
        progressBar.Name = "progressBar";
        progressBar.Size = new Size(412, 23);
        progressBar.Step = 5;
        progressBar.TabIndex = 6;
        // 
        // lblZIPPathInfo
        // 
        lblZIPPathInfo.Location = new Point(62, 9);
        lblZIPPathInfo.MaximumSize = new Size(700, 0);
        lblZIPPathInfo.Name = "lblZIPPathInfo";
        lblZIPPathInfo.Size = new Size(375, 15);
        lblZIPPathInfo.TabIndex = 16;
        lblZIPPathInfo.Text = "c:\\\\ Path";
        // 
        // lblZIPPath
        // 
        lblZIPPath.AutoSize = true;
        lblZIPPath.Location = new Point(25, 9);
        lblZIPPath.Name = "lblZIPPath";
        lblZIPPath.Size = new Size(28, 15);
        lblZIPPath.TabIndex = 15;
        lblZIPPath.Text = "File:";
        // 
        // lblStatusInfo
        // 
        lblStatusInfo.AutoSize = true;
        lblStatusInfo.Location = new Point(73, 28);
        lblStatusInfo.Name = "lblStatusInfo";
        lblStatusInfo.Size = new Size(22, 15);
        lblStatusInfo.TabIndex = 18;
        lblStatusInfo.Text = "???";
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(25, 28);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(42, 15);
        lblStatus.TabIndex = 17;
        lblStatus.Text = "Status:";
        // 
        // lblFilesInfo
        // 
        lblFilesInfo.AutoSize = true;
        lblFilesInfo.Location = new Point(25, 81);
        lblFilesInfo.Name = "lblFilesInfo";
        lblFilesInfo.Size = new Size(93, 15);
        lblFilesInfo.TabIndex = 20;
        lblFilesInfo.Text = " Fortschritt: 0 / 0";
        // 
        // lblPercent
        // 
        lblPercent.Location = new Point(387, 28);
        lblPercent.Name = "lblPercent";
        lblPercent.Size = new Size(62, 15);
        lblPercent.TabIndex = 21;
        lblPercent.Text = "0%";
        lblPercent.TextAlign = ContentAlignment.TopCenter;
        // 
        // FormZIP
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(461, 107);
        Controls.Add(lblPercent);
        Controls.Add(lblFilesInfo);
        Controls.Add(lblStatusInfo);
        Controls.Add(lblStatus);
        Controls.Add(lblZIPPathInfo);
        Controls.Add(lblZIPPath);
        Controls.Add(progressBar);
        DoubleBuffered = true;
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormZIP";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "FormZIP";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ProgressBar progressBar;
    private Label lblZIPPathInfo;
    private Label lblZIPPath;
    private Label lblStatusInfo;
    private Label lblStatus;
    private Label lblFilesInfo;
    private Label lblPercent;
}