using System.Drawing.Text;
using System.Management;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Game_Server_Manager.Forms;
using Game_Server_Manager.Properties;
using Timer = System.Windows.Forms.Timer;
using GameManager = Game_Server_Manager.Properties.Settings;
using GameManager_Valheim = Game_Server_Manager.Properties.Valheim;

namespace Game_Server_Manager;

public partial class FormByteMaster : Form
{
    // Fields
    private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;

    public FormByteMaster()
    {
        InitializeComponent();
        StartUp();
    }

    // Startroutine
    private void StartUp()
    {
        OpenChildForm(new Forms.FormHome());
        // System Informationen
        SystemInfo();
        // Timer Start
        Timer();
        // Form Einstellungen
        LoadFormSettings();
        // Farb Einstellungen
        LoadColorSettings();
        // Lade SteamCMD Informationen
        SteamCMD();
    }

    // Laden der Form Einstellungen
    private void LoadFormSettings()
    {
        Text = string.Empty;
        ControlBox = false;
        DoubleBuffered = true;
        MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        leftBorderBtn = new Panel();
        leftBorderBtn.Size = new Size(7, 60);
        panelMenu.Controls.Add(leftBorderBtn);
        lblTitleChildForm.Text = "Home";
    }

    // Lade Farb Einstellungen
    private void LoadColorSettings()
    {
        // Form
        BackColor = RGBColors.Default.FormBG;
        panelMenu.BackColor = RGBColors.Default.FormBG;
        panelShadow.BackColor = RGBColors.Default.FormBG;
        panelDesktop.BackColor = RGBColors.Default.FormBG;
        panelTitelBar.BackColor = RGBColors.Default.FormBG;
        btnHome.BackColor = RGBColors.Default.FormBG;
        // Buttons
        btnValheim.BackColor = RGBColors.Default.FormBG;
        btnValheim.IconColor = RGBColors.Default.Icon;
        btnValheim.FlatAppearance.MouseDownBackColor = RGBColors.Default.MouseDown;
        btnValheim.FlatAppearance.MouseOverBackColor = RGBColors.Default.MouseHover;
        btnSettings.BackColor = RGBColors.Default.FormBG;
        btnSettings.IconColor = RGBColors.Default.Icon;
        btnSettings.FlatAppearance.MouseDownBackColor = RGBColors.Default.MouseDown;
        btnSettings.FlatAppearance.MouseOverBackColor = RGBColors.Default.MouseHover;
        // Text
        lblTitleChildForm.ForeColor = RGBColors.Default.Text;
    }

    // Timer für die Aktualisierung der Informationen
    private void Timer()
    {
        // Timer 0.5 Sekunden
        Timer timerShort = new Timer();
        timerShort.Interval = 500;
        timerShort.Tick += Timer_Tick_Short;
        timerShort.Start();
        // Timer 2 Sekunden
        Timer timerLong = new Timer();
        timerLong.Interval = 2000;
        timerLong.Tick += Timer_Tick_Long;
        timerLong.Start();
    }

    // Eventhandler für die Timer
    private void Timer_Tick_Short(object sender, EventArgs e)
    {

    }

    private void Timer_Tick_Long(object sender, EventArgs e)
    {
        SystemInfo();
        SteamCMD();
    }

    // Drag Form
    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

    // Drag Form from panelTitleBar
    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    // Methods

    // Lade RAM-Informationen
    private void SystemInfo()
    {
        // RAM-Nutzung des Systems ermitteln
        var ramFree = (double)new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory / (1024 * 1024 * 1024);
        var ramUsage = (double)new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024 * 1024) - ramFree;
        var totalRAM = (double)new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024 * 1024);
        var totalRAMPercentage = (float)(100f * ramFree / totalRAM);
        totalRAMPercentage = (float)Math.Round(totalRAMPercentage, 2);
        // Formatierung für die Ausgabe
        lblRamUsageSystem.Text = $"RAM: {ramUsage:F2}GB / {totalRAM:F0}GB Free: {totalRAMPercentage:F2}%";
    }

    // Prüfe ob SteamCMD installiert ist
    private void SteamCMD()
    {
        if (File.Exists(Path.Combine((GameManager.Default.SteamCMDPath), "steamerrorreporter.exe")))
        {
            // SteamCMD vorhanden
            lblSteamCMDInstalledInfo.ForeColor = Color.Green;
            lblSteamCMDInstalledInfo.Text = "Installed";
        }
        else
        {
            // SteamCMD nicht vorhanden
            lblSteamCMDInstalledInfo.ForeColor = Color.Red;
            lblSteamCMDInstalledInfo.Text = "Not Installed";
        }
    }

    private void ActivateButton(object senderBtn, Color color)
    {
        if (senderBtn != null)
        {
            DisableButton();
            // Button
            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = RGBColors.Default.FormBG;
            currentBtn.ForeColor = RGBColors.Default.Text;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            // Left border button
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            // Icon Current Child Form
            iconCurrentChildForm.IconChar = currentBtn.IconChar;
            iconCurrentChildForm.IconColor = color;
        }
    }

    // Disable button
    private void DisableButton()
    {
        if (currentBtn != null)
        {
            currentBtn.BackColor = RGBColors.Default.FormBG;
            currentBtn.ForeColor = RGBColors.Default.Text;
            currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            currentBtn.IconColor = RGBColors.Default.Icon;
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            leftBorderBtn.Visible = false;
        }
    }

    // Open Child Form
    private void OpenChildForm(Form childForm)
    {
        if (currentChildForm != null)
        {
            // Open only form
            currentChildForm.Hide();
        }
        currentChildForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        panelDesktop.Controls.Add(childForm);
        panelDesktop.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        lblTitleChildForm.Text = childForm.Text;
    }

    // Button Home
    private void btnHome_Click(object sender, EventArgs e)
    {
        // Prüfe ob childForm nicht null ist und schließe es.
        if (currentChildForm != null)
            currentChildForm.Close();
        Reset();
        OpenChildForm(new FormHome());
        lblTitleChildForm.Text = "Home";
    }

    // Reset
    private void Reset()
    {
        DisableButton();
        leftBorderBtn.Visible = false;
        iconCurrentChildForm.IconChar = IconChar.HomeUser;
        iconCurrentChildForm.IconColor = RGBColors.Default.HomeBTN;
    }

    // Button Valheim
    private void btnValheim_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.Default.SideMenuSelected);
        OpenChildForm(new FormValheim());
    }

    // Button Enshrouded
    private void btnEnshrouded_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.Default.SideMenuSelected);
        OpenChildForm(new FormEnshrouded());
    }

    // Button Settings
    private void btnSettings_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.Default.color6);
        OpenChildForm(new FormSettings());
    }

    private void btnControlboxExit_MouseEnter(object sender, EventArgs e)
    {
        btnControlboxExit.IconColor = RGBColors.Default.ExitBTN;
    }

    private void btnControlboxExit_MouseLeave(object sender, EventArgs e)
    {
        btnControlboxExit.IconColor = Color.White;
    }

    private void btnControlboxExit_Click(object sender, EventArgs e)
    {
        FormExit formExit = new FormExit();
        formExit.ShowDialog();
    }

    private void btnControlboxMinimize_Click(object sender, EventArgs e)
    {
        // Minimize App 
        WindowState = FormWindowState.Minimized;
    }

    private void lblSteamCMDInstalled_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormSettings());
    }

    private void lblSteamCMDInstalledInfo_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormSettings());
    }


}
