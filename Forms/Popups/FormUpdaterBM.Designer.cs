namespace Game_Server_Manager.Forms;

partial class FormUpdaterBM
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
        btnExit = new FontAwesome.Sharp.IconButton();
        lblLatestVersion = new Label();
        label1 = new Label();
        label2 = new Label();
        lblVersionInfo = new Label();
        btnUpdate = new FontAwesome.Sharp.IconButton();
        lblNewVersion = new Label();
        panelTopBar = new Panel();
        lblTopBar = new Label();
        panelTopBar.SuspendLayout();
        SuspendLayout();
        // 
        // btnExit
        // 
        btnExit.BackColor = Color.Transparent;
        btnExit.BackgroundImageLayout = ImageLayout.Zoom;
        btnExit.FlatAppearance.BorderSize = 0;
        btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
        btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        btnExit.FlatStyle = FlatStyle.Flat;
        btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
        btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnExit.ForeColor = Color.White;
        btnExit.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
        btnExit.IconColor = Color.White;
        btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnExit.IconSize = 45;
        btnExit.ImageAlign = ContentAlignment.MiddleLeft;
        btnExit.Location = new Point(174, 141);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(110, 50);
        btnExit.TabIndex = 16;
        btnExit.Text = "Exit";
        btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnExit.UseVisualStyleBackColor = false;
        btnExit.Click += btnExit_Click;
        btnExit.MouseEnter += btnExit_MouseEnter;
        btnExit.MouseLeave += btnExit_MouseLeave;
        // 
        // lblLatestVersion
        // 
        lblLatestVersion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLatestVersion.ForeColor = Color.White;
        lblLatestVersion.Location = new Point(0, 53);
        lblLatestVersion.Name = "lblLatestVersion";
        lblLatestVersion.Size = new Size(296, 17);
        lblLatestVersion.TabIndex = 18;
        lblLatestVersion.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(0, 36);
        label1.Name = "label1";
        label1.Size = new Size(296, 17);
        label1.TabIndex = 19;
        label1.Text = "Aktuelle Version";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.White;
        label2.Location = new Point(0, 76);
        label2.Name = "label2";
        label2.Size = new Size(296, 17);
        label2.TabIndex = 20;
        label2.Text = "Lokale Version";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblVersionInfo
        // 
        lblVersionInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblVersionInfo.ForeColor = Color.White;
        lblVersionInfo.Location = new Point(0, 93);
        lblVersionInfo.Name = "lblVersionInfo";
        lblVersionInfo.Size = new Size(296, 17);
        lblVersionInfo.TabIndex = 21;
        lblVersionInfo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.Transparent;
        btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
        btnUpdate.Enabled = false;
        btnUpdate.FlatAppearance.BorderSize = 0;
        btnUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
        btnUpdate.FlatStyle = FlatStyle.Flat;
        btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnUpdate.ForeColor = Color.White;
        btnUpdate.IconChar = FontAwesome.Sharp.IconChar.CloudDownloadAlt;
        btnUpdate.IconColor = Color.White;
        btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnUpdate.IconSize = 45;
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
        btnUpdate.Location = new Point(12, 141);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(110, 50);
        btnUpdate.TabIndex = 22;
        btnUpdate.Text = "Update";
        btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnDownload_Click;
        btnUpdate.MouseEnter += btnUpdate_MouseEnter;
        btnUpdate.MouseLeave += btnUpdate_MouseLeave;
        // 
        // lblNewVersion
        // 
        lblNewVersion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblNewVersion.ForeColor = Color.White;
        lblNewVersion.Location = new Point(0, 115);
        lblNewVersion.Name = "lblNewVersion";
        lblNewVersion.Size = new Size(296, 31);
        lblNewVersion.TabIndex = 23;
        lblNewVersion.Text = "Keine Neue Version verfügbar";
        lblNewVersion.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panelTopBar
        // 
        panelTopBar.Controls.Add(lblTopBar);
        panelTopBar.Dock = DockStyle.Top;
        panelTopBar.Location = new Point(0, 0);
        panelTopBar.Name = "panelTopBar";
        panelTopBar.Size = new Size(296, 27);
        panelTopBar.TabIndex = 24;
        // 
        // lblTopBar
        // 
        lblTopBar.Dock = DockStyle.Fill;
        lblTopBar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTopBar.ForeColor = Color.White;
        lblTopBar.Location = new Point(0, 0);
        lblTopBar.Name = "lblTopBar";
        lblTopBar.Size = new Size(296, 27);
        lblTopBar.TabIndex = 25;
        lblTopBar.Text = "Bytemaster Versions Update";
        lblTopBar.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FormUpdaterBM
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(296, 203);
        Controls.Add(panelTopBar);
        Controls.Add(lblNewVersion);
        Controls.Add(btnUpdate);
        Controls.Add(lblVersionInfo);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(lblLatestVersion);
        Controls.Add(btnExit);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormUpdaterBM";
        StartPosition = FormStartPosition.CenterParent;
        Text = "FormUpdaterBM";
        panelTopBar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private FontAwesome.Sharp.IconButton btnExit;
    private Label lblLatestVersion;
    private Label label1;
    private Label label2;
    private Label lblVersionInfo;
    private FontAwesome.Sharp.IconButton btnUpdate;
    private Label lblNewVersion;
    private Panel panelTopBar;
    private Label lblTopBar;
}