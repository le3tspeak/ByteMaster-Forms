﻿namespace Game_Server_Manager.Forms;

partial class FormSettings
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
        lblServersPath = new Label();
        btnSteamCMDInstall = new FontAwesome.Sharp.IconButton();
        tbServerPath = new TextBox();
        tbSteamCMDPath = new TextBox();
        lblSteamCMDPath = new Label();
        lblVersion = new Label();
        btnSetServerPath = new FontAwesome.Sharp.IconButton();
        btnSetStemCMDPath = new FontAwesome.Sharp.IconButton();
        btnSteamCMDUninstall = new FontAwesome.Sharp.IconButton();
        lblSteamCMD = new Label();
        lblSteamCMDLatUpdateInfo = new Label();
        btnGitHub = new FontAwesome.Sharp.IconButton();
        btnThemeDesigner = new FontAwesome.Sharp.IconButton();
        btnUpdateGMS = new FontAwesome.Sharp.IconButton();
        btnSteamCMDAutoUpdate = new FontAwesome.Sharp.IconButton();
        lblSteamCMDAutoUpdate = new Label();
        SuspendLayout();
        // 
        // lblServersPath
        // 
        lblServersPath.AutoSize = true;
        lblServersPath.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblServersPath.ForeColor = Color.White;
        lblServersPath.Location = new Point(12, 9);
        lblServersPath.Name = "lblServersPath";
        lblServersPath.Size = new Size(201, 21);
        lblServersPath.TabIndex = 0;
        lblServersPath.Text = "Location of game servers";
        // 
        // btnSteamCMDInstall
        // 
        btnSteamCMDInstall.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnSteamCMDInstall.BackColor = Color.Transparent;
        btnSteamCMDInstall.BackgroundImageLayout = ImageLayout.Zoom;
        btnSteamCMDInstall.FlatAppearance.BorderSize = 0;
        btnSteamCMDInstall.FlatStyle = FlatStyle.Flat;
        btnSteamCMDInstall.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnSteamCMDInstall.ForeColor = Color.White;
        btnSteamCMDInstall.IconChar = FontAwesome.Sharp.IconChar.Steam;
        btnSteamCMDInstall.IconColor = Color.White;
        btnSteamCMDInstall.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnSteamCMDInstall.IconSize = 45;
        btnSteamCMDInstall.ImageAlign = ContentAlignment.MiddleLeft;
        btnSteamCMDInstall.Location = new Point(12, 408);
        btnSteamCMDInstall.Name = "btnSteamCMDInstall";
        btnSteamCMDInstall.Size = new Size(150, 50);
        btnSteamCMDInstall.TabIndex = 1;
        btnSteamCMDInstall.Text = "Update";
        btnSteamCMDInstall.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSteamCMDInstall.UseVisualStyleBackColor = false;
        btnSteamCMDInstall.Click += btnSteamCMDUpdate_Click;
        // 
        // tbServerPath
        // 
        tbServerPath.Location = new Point(31, 33);
        tbServerPath.Name = "tbServerPath";
        tbServerPath.PlaceholderText = "Servers Path";
        tbServerPath.ReadOnly = true;
        tbServerPath.Size = new Size(766, 23);
        tbServerPath.TabIndex = 3;
        tbServerPath.MouseClick += tbServerPath_MouseClick;
        // 
        // tbSteamCMDPath
        // 
        tbSteamCMDPath.Location = new Point(31, 98);
        tbSteamCMDPath.Name = "tbSteamCMDPath";
        tbSteamCMDPath.PlaceholderText = "SteamCMD Path";
        tbSteamCMDPath.ReadOnly = true;
        tbSteamCMDPath.Size = new Size(766, 23);
        tbSteamCMDPath.TabIndex = 5;
        tbSteamCMDPath.MouseClick += tbSteamCMDPath_MouseClick;
        // 
        // lblSteamCMDPath
        // 
        lblSteamCMDPath.AutoSize = true;
        lblSteamCMDPath.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSteamCMDPath.ForeColor = Color.White;
        lblSteamCMDPath.Location = new Point(12, 74);
        lblSteamCMDPath.Name = "lblSteamCMDPath";
        lblSteamCMDPath.Size = new Size(162, 21);
        lblSteamCMDPath.TabIndex = 6;
        lblSteamCMDPath.Text = "SteamCMD location";
        // 
        // lblVersion
        // 
        lblVersion.AutoSize = true;
        lblVersion.BackColor = Color.Transparent;
        lblVersion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblVersion.ForeColor = Color.White;
        lblVersion.Location = new Point(788, 504);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(80, 17);
        lblVersion.TabIndex = 7;
        lblVersion.Text = "Version: 0.1";
        // 
        // btnSetServerPath
        // 
        btnSetServerPath.BackColor = Color.Transparent;
        btnSetServerPath.BackgroundImageLayout = ImageLayout.Zoom;
        btnSetServerPath.FlatAppearance.BorderSize = 0;
        btnSetServerPath.FlatStyle = FlatStyle.Popup;
        btnSetServerPath.ForeColor = Color.White;
        btnSetServerPath.IconChar = FontAwesome.Sharp.IconChar.FolderTree;
        btnSetServerPath.IconColor = Color.White;
        btnSetServerPath.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnSetServerPath.IconSize = 15;
        btnSetServerPath.Location = new Point(813, 32);
        btnSetServerPath.Name = "btnSetServerPath";
        btnSetServerPath.Size = new Size(49, 23);
        btnSetServerPath.TabIndex = 8;
        btnSetServerPath.UseVisualStyleBackColor = false;
        btnSetServerPath.Click += btnSetServerPath_Click;
        // 
        // btnSetStemCMDPath
        // 
        btnSetStemCMDPath.BackColor = Color.Transparent;
        btnSetStemCMDPath.BackgroundImageLayout = ImageLayout.Zoom;
        btnSetStemCMDPath.FlatAppearance.BorderSize = 0;
        btnSetStemCMDPath.FlatStyle = FlatStyle.Popup;
        btnSetStemCMDPath.ForeColor = Color.White;
        btnSetStemCMDPath.IconChar = FontAwesome.Sharp.IconChar.FolderTree;
        btnSetStemCMDPath.IconColor = Color.White;
        btnSetStemCMDPath.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnSetStemCMDPath.IconSize = 15;
        btnSetStemCMDPath.Location = new Point(813, 98);
        btnSetStemCMDPath.Name = "btnSetStemCMDPath";
        btnSetStemCMDPath.Size = new Size(49, 23);
        btnSetStemCMDPath.TabIndex = 9;
        btnSetStemCMDPath.UseVisualStyleBackColor = false;
        btnSetStemCMDPath.Click += btnSetStemCMDPath_Click;
        // 
        // btnSteamCMDUninstall
        // 
        btnSteamCMDUninstall.BackColor = Color.Transparent;
        btnSteamCMDUninstall.BackgroundImageLayout = ImageLayout.Zoom;
        btnSteamCMDUninstall.FlatAppearance.BorderSize = 0;
        btnSteamCMDUninstall.FlatStyle = FlatStyle.Flat;
        btnSteamCMDUninstall.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnSteamCMDUninstall.ForeColor = Color.White;
        btnSteamCMDUninstall.IconChar = FontAwesome.Sharp.IconChar.Steam;
        btnSteamCMDUninstall.IconColor = Color.White;
        btnSteamCMDUninstall.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnSteamCMDUninstall.IconSize = 45;
        btnSteamCMDUninstall.ImageAlign = ContentAlignment.MiddleLeft;
        btnSteamCMDUninstall.Location = new Point(12, 468);
        btnSteamCMDUninstall.Name = "btnSteamCMDUninstall";
        btnSteamCMDUninstall.Size = new Size(150, 50);
        btnSteamCMDUninstall.TabIndex = 10;
        btnSteamCMDUninstall.Text = "Uninstall";
        btnSteamCMDUninstall.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSteamCMDUninstall.UseVisualStyleBackColor = false;
        btnSteamCMDUninstall.Click += btnSteamCMDInstall_Click;
        // 
        // lblSteamCMD
        // 
        lblSteamCMD.AutoSize = true;
        lblSteamCMD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSteamCMD.ForeColor = Color.White;
        lblSteamCMD.Location = new Point(31, 330);
        lblSteamCMD.Name = "lblSteamCMD";
        lblSteamCMD.Size = new Size(95, 21);
        lblSteamCMD.TabIndex = 11;
        lblSteamCMD.Text = "SteamCMD";
        // 
        // lblSteamCMDLatUpdateInfo
        // 
        lblSteamCMDLatUpdateInfo.AutoSize = true;
        lblSteamCMDLatUpdateInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSteamCMDLatUpdateInfo.ForeColor = Color.White;
        lblSteamCMDLatUpdateInfo.Location = new Point(77, 355);
        lblSteamCMDLatUpdateInfo.Name = "lblSteamCMDLatUpdateInfo";
        lblSteamCMDLatUpdateInfo.Size = new Size(108, 17);
        lblSteamCMDLatUpdateInfo.TabIndex = 12;
        lblSteamCMDLatUpdateInfo.Text = "22.04.2024 14:03";
        // 
        // btnGitHub
        // 
        btnGitHub.BackColor = Color.Transparent;
        btnGitHub.BackgroundImageLayout = ImageLayout.Zoom;
        btnGitHub.FlatAppearance.BorderSize = 0;
        btnGitHub.FlatStyle = FlatStyle.Flat;
        btnGitHub.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnGitHub.ForeColor = Color.White;
        btnGitHub.IconChar = FontAwesome.Sharp.IconChar.GithubSquare;
        btnGitHub.IconColor = Color.White;
        btnGitHub.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnGitHub.IconSize = 45;
        btnGitHub.ImageAlign = ContentAlignment.MiddleLeft;
        btnGitHub.Location = new Point(644, 468);
        btnGitHub.Name = "btnGitHub";
        btnGitHub.Size = new Size(120, 50);
        btnGitHub.TabIndex = 13;
        btnGitHub.Text = "GitHub";
        btnGitHub.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnGitHub.UseVisualStyleBackColor = false;
        btnGitHub.Click += btnGitHub_Click;
        // 
        // btnThemeDesigner
        // 
        btnThemeDesigner.BackColor = Color.Transparent;
        btnThemeDesigner.BackgroundImageLayout = ImageLayout.Zoom;
        btnThemeDesigner.FlatAppearance.BorderSize = 0;
        btnThemeDesigner.FlatStyle = FlatStyle.Flat;
        btnThemeDesigner.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnThemeDesigner.ForeColor = Color.White;
        btnThemeDesigner.IconChar = FontAwesome.Sharp.IconChar.Brush;
        btnThemeDesigner.IconColor = Color.White;
        btnThemeDesigner.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnThemeDesigner.IconSize = 35;
        btnThemeDesigner.ImageAlign = ContentAlignment.MiddleLeft;
        btnThemeDesigner.Location = new Point(518, 468);
        btnThemeDesigner.Name = "btnThemeDesigner";
        btnThemeDesigner.Size = new Size(120, 50);
        btnThemeDesigner.TabIndex = 14;
        btnThemeDesigner.Text = "Design";
        btnThemeDesigner.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnThemeDesigner.UseVisualStyleBackColor = false;
        btnThemeDesigner.Visible = false;
        btnThemeDesigner.Click += btnThemeDesigner_Click;
        // 
        // btnUpdateGMS
        // 
        btnUpdateGMS.BackColor = Color.Transparent;
        btnUpdateGMS.BackgroundImageLayout = ImageLayout.Zoom;
        btnUpdateGMS.FlatAppearance.BorderSize = 0;
        btnUpdateGMS.FlatStyle = FlatStyle.Flat;
        btnUpdateGMS.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnUpdateGMS.ForeColor = Color.White;
        btnUpdateGMS.IconChar = FontAwesome.Sharp.IconChar.Wrench;
        btnUpdateGMS.IconColor = Color.White;
        btnUpdateGMS.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnUpdateGMS.IconSize = 45;
        btnUpdateGMS.ImageAlign = ContentAlignment.MiddleLeft;
        btnUpdateGMS.Location = new Point(644, 408);
        btnUpdateGMS.Name = "btnUpdateGMS";
        btnUpdateGMS.Size = new Size(120, 50);
        btnUpdateGMS.TabIndex = 15;
        btnUpdateGMS.Text = "Update";
        btnUpdateGMS.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnUpdateGMS.UseVisualStyleBackColor = false;
        btnUpdateGMS.Click += btnUpdateGMS_Click;
        // 
        // btnSteamCMDAutoUpdate
        // 
        btnSteamCMDAutoUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnSteamCMDAutoUpdate.BackColor = Color.Transparent;
        btnSteamCMDAutoUpdate.BackgroundImageLayout = ImageLayout.Zoom;
        btnSteamCMDAutoUpdate.FlatAppearance.BorderSize = 0;
        btnSteamCMDAutoUpdate.FlatStyle = FlatStyle.Flat;
        btnSteamCMDAutoUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnSteamCMDAutoUpdate.ForeColor = Color.White;
        btnSteamCMDAutoUpdate.IconChar = FontAwesome.Sharp.IconChar.Steam;
        btnSteamCMDAutoUpdate.IconColor = Color.White;
        btnSteamCMDAutoUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnSteamCMDAutoUpdate.IconSize = 45;
        btnSteamCMDAutoUpdate.ImageAlign = ContentAlignment.MiddleLeft;
        btnSteamCMDAutoUpdate.Location = new Point(168, 468);
        btnSteamCMDAutoUpdate.Name = "btnSteamCMDAutoUpdate";
        btnSteamCMDAutoUpdate.Size = new Size(151, 50);
        btnSteamCMDAutoUpdate.TabIndex = 16;
        btnSteamCMDAutoUpdate.Text = "Auto Update";
        btnSteamCMDAutoUpdate.TextAlign = ContentAlignment.MiddleRight;
        btnSteamCMDAutoUpdate.UseVisualStyleBackColor = false;
        btnSteamCMDAutoUpdate.Click += btnSteamCMDAutoUpdate_Click;
        // 
        // lblSteamCMDAutoUpdate
        // 
        lblSteamCMDAutoUpdate.AutoSize = true;
        lblSteamCMDAutoUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblSteamCMDAutoUpdate.ForeColor = Color.White;
        lblSteamCMDAutoUpdate.Location = new Point(77, 372);
        lblSteamCMDAutoUpdate.Name = "lblSteamCMDAutoUpdate";
        lblSteamCMDAutoUpdate.Size = new Size(111, 17);
        lblSteamCMDAutoUpdate.TabIndex = 17;
        lblSteamCMDAutoUpdate.Text = "Auto Update: EN";
        // 
        // FormSettings
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(880, 530);
        Controls.Add(lblSteamCMDAutoUpdate);
        Controls.Add(btnSteamCMDAutoUpdate);
        Controls.Add(btnUpdateGMS);
        Controls.Add(btnThemeDesigner);
        Controls.Add(btnGitHub);
        Controls.Add(lblSteamCMDLatUpdateInfo);
        Controls.Add(lblSteamCMD);
        Controls.Add(btnSteamCMDUninstall);
        Controls.Add(btnSetStemCMDPath);
        Controls.Add(btnSetServerPath);
        Controls.Add(lblVersion);
        Controls.Add(lblSteamCMDPath);
        Controls.Add(tbSteamCMDPath);
        Controls.Add(tbServerPath);
        Controls.Add(btnSteamCMDInstall);
        Controls.Add(lblServersPath);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormSettings";
        Text = "Settings";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblServersPath;
    private FontAwesome.Sharp.IconButton btnSteamCMDInstall;
    private TextBox tbServerPath;
    private TextBox tbSteamCMDPath;
    private Label lblSteamCMDPath;
    private Label lblVersion;
    private FontAwesome.Sharp.IconButton btnSetServerPath;
    private FontAwesome.Sharp.IconButton btnSetStemCMDPath;
    private FontAwesome.Sharp.IconButton btnSteamCMDUninstall;
    private Label lblSteamCMD;
    private Label lblSteamCMDLatUpdateInfo;
    private FontAwesome.Sharp.IconButton btnGitHub;
    private FontAwesome.Sharp.IconButton btnThemeDesigner;
    private FontAwesome.Sharp.IconButton btnUpdateGMS;
    private FontAwesome.Sharp.IconButton btnSteamCMDAutoUpdate;
    private Label lblSteamCMDAutoUpdate;
}