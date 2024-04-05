namespace Game_Server_Manager.Forms;

partial class FormSteamCMD
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
        tbConsole = new TextBox();
        lblSteamCMDPathInfo = new Label();
        panel1 = new Panel();
        lblSteamCMDInformation = new Label();
        panel2 = new Panel();
        lblSteamArguments = new Label();
        lblSteamArgumentsInfo = new Label();
        lblSteamCMDPath = new Label();
        panel3 = new Panel();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // tbConsole
        // 
        tbConsole.BackColor = Color.Black;
        tbConsole.BorderStyle = BorderStyle.None;
        tbConsole.Dock = DockStyle.Fill;
        tbConsole.ForeColor = Color.White;
        tbConsole.Location = new Point(0, 0);
        tbConsole.Multiline = true;
        tbConsole.Name = "tbConsole";
        tbConsole.ReadOnly = true;
        tbConsole.ScrollBars = ScrollBars.Horizontal;
        tbConsole.Size = new Size(800, 75);
        tbConsole.TabIndex = 0;
        // 
        // lblSteamCMDPathInfo
        // 
        lblSteamCMDPathInfo.AutoSize = true;
        lblSteamCMDPathInfo.ForeColor = Color.White;
        lblSteamCMDPathInfo.Location = new Point(153, 13);
        lblSteamCMDPathInfo.Name = "lblSteamCMDPathInfo";
        lblSteamCMDPathInfo.Size = new Size(31, 15);
        lblSteamCMDPathInfo.TabIndex = 1;
        lblSteamCMDPathInfo.Text = "path";
        // 
        // panel1
        // 
        panel1.BackColor = Color.Transparent;
        panel1.Controls.Add(lblSteamCMDInformation);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 35);
        panel1.TabIndex = 2;
        // 
        // lblSteamCMDInformation
        // 
        lblSteamCMDInformation.AutoSize = true;
        lblSteamCMDInformation.ForeColor = Color.White;
        lblSteamCMDInformation.Location = new Point(12, 9);
        lblSteamCMDInformation.Name = "lblSteamCMDInformation";
        lblSteamCMDInformation.Size = new Size(308, 15);
        lblSteamCMDInformation.TabIndex = 0;
        lblSteamCMDInformation.Text = "Steam CMD is running but possible not updating de list...";
        // 
        // panel2
        // 
        panel2.BackColor = Color.Transparent;
        panel2.Controls.Add(lblSteamArguments);
        panel2.Controls.Add(lblSteamArgumentsInfo);
        panel2.Controls.Add(lblSteamCMDPath);
        panel2.Controls.Add(lblSteamCMDPathInfo);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0, 110);
        panel2.Name = "panel2";
        panel2.Size = new Size(800, 54);
        panel2.TabIndex = 3;
        // 
        // lblSteamArguments
        // 
        lblSteamArguments.AutoSize = true;
        lblSteamArguments.ForeColor = Color.White;
        lblSteamArguments.Location = new Point(12, 30);
        lblSteamArguments.Name = "lblSteamArguments";
        lblSteamArguments.Size = new Size(135, 15);
        lblSteamArguments.TabIndex = 4;
        lblSteamArguments.Text = "Steam CMD Arguments:";
        // 
        // lblSteamArgumentsInfo
        // 
        lblSteamArgumentsInfo.AutoSize = true;
        lblSteamArgumentsInfo.ForeColor = Color.White;
        lblSteamArgumentsInfo.Location = new Point(153, 30);
        lblSteamArgumentsInfo.Name = "lblSteamArgumentsInfo";
        lblSteamArgumentsInfo.Size = new Size(64, 15);
        lblSteamArgumentsInfo.TabIndex = 3;
        lblSteamArgumentsInfo.Text = "arguments";
        // 
        // lblSteamCMDPath
        // 
        lblSteamCMDPath.AutoSize = true;
        lblSteamCMDPath.ForeColor = Color.White;
        lblSteamCMDPath.Location = new Point(47, 13);
        lblSteamCMDPath.Name = "lblSteamCMDPath";
        lblSteamCMDPath.Size = new Size(100, 15);
        lblSteamCMDPath.TabIndex = 2;
        lblSteamCMDPath.Text = "Steam CMD Path:";
        // 
        // panel3
        // 
        panel3.BackColor = Color.Transparent;
        panel3.Controls.Add(tbConsole);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 35);
        panel3.Name = "panel3";
        panel3.Size = new Size(800, 75);
        panel3.TabIndex = 4;
        // 
        // FormSteamCMD
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(800, 164);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormSteamCMD";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "FormSteamCMD";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TextBox tbConsole;
    private Label lblSteamCMDPathInfo;
    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private Label lblSteamCMDInformation;
    private Label lblSteamCMDPath;
    private Label lblSteamArguments;
    private Label lblSteamArgumentsInfo;
}