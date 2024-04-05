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

namespace Game_Server_Manager.Forms;
public partial class FormHome : Form
{
    public FormHome()
    {
        InitializeComponent();
        StartUp();
    }

    private void StartUp()
    {
        // Timer Start
        Timer();        
        SystemInfo();
        // Valheim
        ValheimUpdate();
    }

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

    private void Timer_Tick_Short(object sender, EventArgs e)
    {

    }

    private void Timer_Tick_Long(object sender, EventArgs e)
    {
        SystemInfo();
        ValheimUpdate();
    }
    //
    // Valheim
    //
    private void ValheimUpdate()
    {
        var InstallDirValheim = Path.Combine(GameManager.Default.ServerPath, GameManager_Valheim.Default.ServerFolderName);

        // Check Server Installed and Display Info
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

        // Check Server Running and Display Info
        // Überprüfen, ob der Prozess läuft
        if (IsProcessRunning(GameManager_Valheim.Default.ProzessName))
        {
            lblServerValheimRunningInfo.ForeColor = System.Drawing.Color.Green;
            // Server is Running
            lblServerValheimRunningInfo.Text = "Der Prozess läuft.";
        }
        else
        {
            lblServerValheimRunningInfo.ForeColor = System.Drawing.Color.Red;
            // Server is not Running
            lblServerValheimRunningInfo.Text = "Der Prozess läuft nicht.";
        }

        // InstallDirValheim
        lblServerValheimPathInfo.Text = InstallDirValheim;

        // RAM-Verbrauch
        (string infoText, int progressBarValue) ramUsageInfo = Worker.RAMUsage.UpdateShort(GameManager_Valheim.Default.ProzessName);
        if (ramUsageInfo.infoText != lblRAMUsageInfoValheim.Text || ramUsageInfo.progressBarValue != progressBarRAMValheim.Value)
        {
            lblRAMUsageInfoValheim.Text = ramUsageInfo.infoText;
            progressBarRAMValheim.Value = ramUsageInfo.progressBarValue;
        }
    }
    //
    // Default
    //


    // CPU Info
    private void CpuInfo()
    {
        // Get CPU information
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
        foreach (ManagementObject obj in searcher.Get())
        {
            var cpuName = obj["Name"].ToString();
            var cpuNumberOfCores = obj["NumberOfCores"].ToString();

            // Display CPU information on the UI thread
            Invoke(new Action(() =>
            {
                lblCpuNameInfo.Text = cpuName;
                lblCpuNumberOfCoresInfo.Text = cpuNumberOfCores;
            }));
        }
    }

    // Lade ComputerInfo

    private void SystemInfo()
    {
        // RAM nutzung des Systems
        var ramFree = new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory / (1024 * 1024);
        var ramUsage = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024) - ramFree;
        var totalRAM = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024);
        var totalRAMPercentage = (float)(100f * ramFree / totalRAM);
        totalRAMPercentage = (float)Math.Round(totalRAMPercentage, 2);
        lblRamUsageSystemInfo.Text = $"{ramUsage} MB / {totalRAM} MB  {totalRAMPercentage} %";
    }

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

    private void lblRamUsageSystemInfo_Click(object sender, EventArgs e)
    {

    }

    private async void FormHome_LoadAsync(object sender, EventArgs e)
    {
        await Task.Run(CpuInfo);
    }
}
