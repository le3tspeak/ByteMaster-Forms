
namespace Game_Server_Manager;

partial class FormByteMaster
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormByteMaster));
        panelMenu = new Panel();
        btnSettings = new FontAwesome.Sharp.IconButton();
        btnValheim = new FontAwesome.Sharp.IconButton();
        panelLogo = new Panel();
        btnHome = new PictureBox();
        panelTitelBar = new Panel();
        btnControlboxMinimize = new FontAwesome.Sharp.IconButton();
        btnControlboxExit = new FontAwesome.Sharp.IconButton();
        lblTitleChildForm = new Label();
        iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
        panelShadow = new Panel();
        panelDesktop = new Panel();
        panelMenu.SuspendLayout();
        panelLogo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
        panelTitelBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
        SuspendLayout();
        // 
        // panelMenu
        // 
        panelMenu.BackColor = Color.FromArgb(18, 0, 22);
        panelMenu.Controls.Add(btnSettings);
        panelMenu.Controls.Add(btnValheim);
        panelMenu.Controls.Add(panelLogo);
        resources.ApplyResources(panelMenu, "panelMenu");
        panelMenu.Name = "panelMenu";
        // 
        // btnSettings
        // 
        btnSettings.BackColor = Color.FromArgb(18, 0, 22);
        resources.ApplyResources(btnSettings, "btnSettings");
        btnSettings.FlatAppearance.BorderSize = 0;
        btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 0, 22);
        btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 0, 129);
        btnSettings.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
        btnSettings.IconColor = Color.White;
        btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnSettings.Name = "btnSettings";
        btnSettings.UseVisualStyleBackColor = false;
        btnSettings.Click += btnSettings_Click;
        // 
        // btnValheim
        // 
        btnValheim.BackColor = Color.FromArgb(18, 0, 22);
        resources.ApplyResources(btnValheim, "btnValheim");
        btnValheim.FlatAppearance.BorderSize = 0;
        btnValheim.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 0, 22);
        btnValheim.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 0, 129);
        btnValheim.IconChar = FontAwesome.Sharp.IconChar.Server;
        btnValheim.IconColor = Color.White;
        btnValheim.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnValheim.Name = "btnValheim";
        btnValheim.UseVisualStyleBackColor = false;
        btnValheim.Click += btnValheim_Click;
        // 
        // panelLogo
        // 
        panelLogo.Controls.Add(btnHome);
        resources.ApplyResources(panelLogo, "panelLogo");
        panelLogo.Name = "panelLogo";
        panelLogo.Click += btnHome_Click;
        panelLogo.DoubleClick += btnHome_Click;
        panelLogo.MouseDown += panelTitleBar_MouseDown;
        // 
        // btnHome
        // 
        resources.ApplyResources(btnHome, "btnHome");
        btnHome.Image = Properties.Resources.LogoNoBackground;
        btnHome.Name = "btnHome";
        btnHome.TabStop = false;
        btnHome.Click += btnHome_Click;
        btnHome.DoubleClick += btnHome_Click;
        // 
        // panelTitelBar
        // 
        panelTitelBar.BackColor = Color.FromArgb(18, 0, 22);
        panelTitelBar.Controls.Add(btnControlboxMinimize);
        panelTitelBar.Controls.Add(btnControlboxExit);
        panelTitelBar.Controls.Add(lblTitleChildForm);
        panelTitelBar.Controls.Add(iconCurrentChildForm);
        resources.ApplyResources(panelTitelBar, "panelTitelBar");
        panelTitelBar.Name = "panelTitelBar";
        panelTitelBar.MouseDown += panelTitleBar_MouseDown;
        // 
        // btnControlboxMinimize
        // 
        resources.ApplyResources(btnControlboxMinimize, "btnControlboxMinimize");
        btnControlboxMinimize.FlatAppearance.BorderSize = 0;
        btnControlboxMinimize.ForeColor = Color.Transparent;
        btnControlboxMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
        btnControlboxMinimize.IconColor = Color.White;
        btnControlboxMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnControlboxMinimize.IconSize = 16;
        btnControlboxMinimize.Name = "btnControlboxMinimize";
        btnControlboxMinimize.UseVisualStyleBackColor = true;
        btnControlboxMinimize.Click += btnControlboxMinimize_Click;
        // 
        // btnControlboxExit
        // 
        resources.ApplyResources(btnControlboxExit, "btnControlboxExit");
        btnControlboxExit.FlatAppearance.BorderSize = 0;
        btnControlboxExit.ForeColor = Color.Transparent;
        btnControlboxExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
        btnControlboxExit.IconColor = Color.White;
        btnControlboxExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnControlboxExit.IconSize = 20;
        btnControlboxExit.Name = "btnControlboxExit";
        btnControlboxExit.UseVisualStyleBackColor = true;
        btnControlboxExit.Click += btnControlboxExit_Click;
        btnControlboxExit.MouseEnter += btnControlboxExit_MouseEnter;
        btnControlboxExit.MouseLeave += btnControlboxExit_MouseLeave;
        // 
        // lblTitleChildForm
        // 
        resources.ApplyResources(lblTitleChildForm, "lblTitleChildForm");
        lblTitleChildForm.ForeColor = Color.Gainsboro;
        lblTitleChildForm.Name = "lblTitleChildForm";
        lblTitleChildForm.MouseDown += panelTitleBar_MouseDown;
        // 
        // iconCurrentChildForm
        // 
        iconCurrentChildForm.BackColor = Color.FromArgb(18, 0, 22);
        resources.ApplyResources(iconCurrentChildForm, "iconCurrentChildForm");
        iconCurrentChildForm.ForeColor = Color.FromArgb(12, 190, 228);
        iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
        iconCurrentChildForm.IconColor = Color.FromArgb(12, 190, 228);
        iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
        iconCurrentChildForm.IconSize = 45;
        iconCurrentChildForm.Name = "iconCurrentChildForm";
        iconCurrentChildForm.TabStop = false;
        iconCurrentChildForm.MouseDown += panelTitleBar_MouseDown;
        // 
        // panelShadow
        // 
        panelShadow.BackColor = Color.FromArgb(18, 0, 22);
        resources.ApplyResources(panelShadow, "panelShadow");
        panelShadow.Name = "panelShadow";
        // 
        // panelDesktop
        // 
        panelDesktop.BackColor = Color.FromArgb(18, 0, 22);
        resources.ApplyResources(panelDesktop, "panelDesktop");
        panelDesktop.Name = "panelDesktop";
        // 
        // FormByteMaster
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(18, 0, 22);
        ControlBox = false;
        Controls.Add(panelDesktop);
        Controls.Add(panelShadow);
        Controls.Add(panelTitelBar);
        Controls.Add(panelMenu);
        ForeColor = SystemColors.ButtonHighlight;
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormByteMaster";
        Load += btnHome_Click;
        panelMenu.ResumeLayout(false);
        panelLogo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
        panelTitelBar.ResumeLayout(false);
        panelTitelBar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Panel panelMenu;
    private Panel panelLogo;
    private FontAwesome.Sharp.IconButton btnSettings;
    private FontAwesome.Sharp.IconButton btnValheim;
    private PictureBox btnHome;
    private Panel panelTitelBar;
    private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
    private Label lblTitleChildForm;
    private Panel panelShadow;
    private Panel panelDesktop;
    private FontAwesome.Sharp.IconButton btnControlboxExit;
    private FontAwesome.Sharp.IconButton btnControlboxMinimize;
    private Panel panelTopBar;
    private Label lblServerPathInfo;
    private Panel panelServerUsage;
    private ProgressBar progressBarRAM;
    private Label lblRAMUsageInfo;
    private Label lblRAMUsage;
    private Label lblCPUUsageInfo;
    private Label lblCPUUsage;
    private Label lblServerPath;
    private Label lblServerRunning;
    private Label lblServerRunningInfo;
    private Label lblServerInstalledInfo;
    private Label lblServerInstalled;
}
