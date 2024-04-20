using System.Diagnostics;
using Game_Server_Manager.Properties;
using GameManager = Game_Server_Manager.Properties.Settings;
using GameManager_Enshrouded = Game_Server_Manager.Properties.Enshrouded;
using GameManager_Valheim = Game_Server_Manager.Properties.Valheim;
using Timer = System.Windows.Forms.Timer;

namespace Game_Server_Manager.Forms;
public partial class FormHome : Form
{
    public FormHome()
    {
        InitializeComponent();
        StartUp();
    }

    // Startroutine
    private void StartUp()
    {
        // Timer Start
        Timer();
        // Form Einstellungen
        LoadFormSettings();
        // Farb Einstellungen
        LoadColorSettings();
        // Valheim
        ValheimUpdate();
        // Enshrouded
        EnshroudedUpdate();
    }

    // Lade Form Einstellungen
    private void LoadFormSettings()
    {
        Text = string.Empty;
        ControlBox = false;
        DoubleBuffered = true;
    }

    // Lade Farb Einstellungen
    private void LoadColorSettings()
    {
        // Form
        BackColor = RGBColors.Default.FormBGChild;
        // Labels
        lblValheimTitle.ForeColor = RGBColors.Default.Text;
        label2.ForeColor = RGBColors.Default.Text;
        lblServerInstalledValheim.ForeColor = RGBColors.Default.Text;
    }

    // Timer für die Aktualisierung der Informationen
    private void Timer()
    {
        // Timer 0.5 Sekunden
        Timer timerShort = new Timer();
        timerShort.Interval = 500;
        timerShort.Tick += Timer_Tick_Short;
        timerShort.Start();
        // Timer 1 Sekunde
        Timer timerLong = new Timer();
        timerLong.Interval = 1000;
        timerLong.Tick += Timer_Tick_Long;
        timerLong.Start();
    }
    // Eventhandler für die Timer
    private void Timer_Tick_Short(object sender, EventArgs e)
    {

    }

    private void Timer_Tick_Long(object sender, EventArgs e)
    {
        ValheimUpdate();
        EnshroudedUpdate();
    }

    //
    // Valheim
    //
    private void ValheimUpdate()
    {
        var InstallDirValheim = Path.Combine(GameManager.Default.ServerPath, GameManager_Valheim.Default.ServerFolderName);

        // Überprüfen, ob der Server installiert ist
        if (File.Exists(Path.Combine(InstallDirValheim, GameManager_Valheim.Default.ServerExe)))
        {
            lblServerValheimInstalledInfo.ForeColor = Color.Green;
            lblServerValheimInstalledInfo.Text = "Installed";
        }
        else
        {
            lblServerValheimInstalledInfo.ForeColor = Color.Red;
            lblServerValheimInstalledInfo.Text = "Not Installed";
        }

        // Überprüfen, ob der Prozess läuft
        if (Worker.ProcessManager.Check(GameManager_Valheim.Default.ProzessName))
        {
            lblServerValheimRunningInfo.ForeColor = Color.Green;
            // Server läuft
            lblServerValheimRunningInfo.Text = "Der Prozess läuft.";
        }
        else
        {
            lblServerValheimRunningInfo.ForeColor = Color.Red;
            // Server läuft nicht
            lblServerValheimRunningInfo.Text = "Der Prozess läuft nicht.";
        }

        // Installationspfad Valheim
        lblServerValheimPathInfo.Text = InstallDirValheim;

        // Load Last Update Time
        lblValheimLastUpdateInfo.Text = GameManager.Default.ValheimLastUpdate;

        // RAM-Verbrauch
        (string infoText, int progressBarValue) ramUsageInfo = Worker.RAMUsage.UpdateShortGB(GameManager_Valheim.Default.ProzessName);
        if (ramUsageInfo.infoText != lblRAMUsageInfoValheim.Text || ramUsageInfo.progressBarValue != progressBarRAMValheim.Value)
        {
            lblRAMUsageInfoValheim.Text = ramUsageInfo.infoText;
            progressBarRAMValheim.Value = ramUsageInfo.progressBarValue;
        }
    }

    //
    // Enshrouded
    //

    private void EnshroudedUpdate()
    {
        var InstallDirEnshrouded = Path.Combine(GameManager.Default.ServerPath, GameManager_Enshrouded.Default.ServerFolderName);

        // Überprüfen, ob der Server installiert ist
        if (File.Exists(Path.Combine(InstallDirEnshrouded, GameManager_Enshrouded.Default.ServerExe)))
        {
            lblServerInstalledEnshroudedInfo.ForeColor = Color.Green;
            lblServerInstalledEnshroudedInfo.Text = "Installed";
        }
        else
        {
            lblServerInstalledEnshroudedInfo.ForeColor = Color.Red;
            lblServerInstalledEnshroudedInfo.Text = "Not Installed";
        }

        // Überprüfen, ob der Prozess läuft
        if (Worker.ProcessManager.Check(GameManager_Enshrouded.Default.ProzessName))
        {
            lblServerRunningEnshroudedInfo.ForeColor = Color.Green;
            // Server läuft
            lblServerRunningEnshroudedInfo.Text = "Der Prozess läuft.";
        }
        else
        {
            lblServerRunningEnshroudedInfo.ForeColor = Color.Red;
            // Server läuft nicht
            lblServerRunningEnshroudedInfo.Text = "Der Prozess läuft nicht.";
        }

        // Installationspfad Enshrouded
        lblServerPathEnshroudedInfo.Text = InstallDirEnshrouded;

        // Load Last Update Time
        lblEnshroudedLastUpdateInfo.Text = GameManager.Default.EnshroudedLastUpdate;

        // RAM-Verbrauch
        (string infoText, int progressBarValue) ramUsageInfo = Worker.RAMUsage.UpdateShortGB(GameManager_Enshrouded.Default.ProzessName);
        if (ramUsageInfo.infoText != lblRAMUsageEnshroudedInfo.Text || ramUsageInfo.progressBarValue != progressBarRAMEnshrouded.Value)
        {
            lblRAMUsageEnshroudedInfo.Text = ramUsageInfo.infoText;
            progressBarRAMEnshrouded.Value = ramUsageInfo.progressBarValue;
        }
    }
}
