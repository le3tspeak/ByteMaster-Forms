using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using GameManager = Game_Server_Manager.Properties.Settings;
using GameManager_Valheim = Game_Server_Manager.Properties.Valheim;
using GameManager_Enshrouded = Game_Server_Manager.Properties.Enshrouded;
using System.Diagnostics;
using System.Windows.Controls;
using System.Management;
using Game_Server_Manager.Properties;

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
        ValheimUpdate();
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
            lblServerValheimInstalledInfo.ForeColor = System.Drawing.Color.Green;
            lblServerValheimInstalledInfo.Text = "Installed";
        }
        else
        {
            lblServerValheimInstalledInfo.ForeColor = System.Drawing.Color.Red;
            lblServerValheimInstalledInfo.Text = "Not Installed";
        }

        // Überprüfen, ob der Prozess läuft
        if (IsProcessRunning(GameManager_Valheim.Default.ProzessName))
        {
            lblServerValheimRunningInfo.ForeColor = System.Drawing.Color.Green;
            // Server läuft
            lblServerValheimRunningInfo.Text = "Der Prozess läuft.";
        }
        else
        {
            lblServerValheimRunningInfo.ForeColor = System.Drawing.Color.Red;
            // Server läuft nicht
            lblServerValheimRunningInfo.Text = "Der Prozess läuft nicht.";
        }

        // Installationspfad Valheim
        lblServerValheimPathInfo.Text = InstallDirValheim;

        // RAM-Verbrauch
        (string infoText, int progressBarValue) ramUsageInfo = Worker.RAMUsage.UpdateShortGB(GameManager_Valheim.Default.ProzessName);
        if (ramUsageInfo.infoText != lblRAMUsageInfoValheim.Text || ramUsageInfo.progressBarValue != progressBarRAMValheim.Value)
        {
            lblRAMUsageInfoValheim.Text = ramUsageInfo.infoText;
            progressBarRAMValheim.Value = ramUsageInfo.progressBarValue;
        }
    }
    //
    // Default
    //

    // Überprüfen, ob der Prozess läuft
    private bool IsProcessRunning(string processName)
    {
        // Alle Prozesse auf dem System durchgehen
        foreach (Process process in Process.GetProcesses())
        {
            // Überprüfen, ob der Prozess mit dem angegebenen Namen existiert
            if (process.ProcessName.Equals(processName, StringComparison.OrdinalIgnoreCase))
            {
                return true; // Prozess gefunden
            }
        }
        return false; // Prozess nicht gefunden
    }
}
