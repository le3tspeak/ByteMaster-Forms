using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using Timer = System.Windows.Forms.Timer;
using GameManager = Game_Server_Manager.Properties.Valheim;
using Game_Server_Manager.Properties;

namespace Game_Server_Manager.Forms;

public partial class FormValheim : Form
{
    // Alle Settings aus Properties.Valheim.Default
    private static readonly int BATAppID = GameManager.Default.BATAppID;
    private static readonly string BATExeName = GameManager.Default.BATEXEName;
    private static readonly string BATName = GameManager.Default.BATName;
    private static readonly int SteamAppID = GameManager.Default.SteamAppID;
    private static readonly string ServerFolderName = GameManager.Default.ServerFolderName;
    private static readonly string ServerExe = GameManager.Default.ServerExe;
    private static readonly string ProzessName = GameManager.Default.ProzessName;
    private static readonly string ServerLogFileName = GameManager.Default.ServerLogFileName;
    private static string ServerName = GameManager.Default.ServerName;
    private static string ServerPassword = GameManager.Default.ServerPassword;
    private static string ServerPort = GameManager.Default.ServerPort;
    private static string ServerWorld = GameManager.Default.ServerWorld;
    private static string ServerBackups = GameManager.Default.ServerBackups;
    private static string ServerSaveDir = GameManager.Default.ServerSaveDir;
    private static string ServerSaveInterval = GameManager.Default.ServerSaveInterval;
    private static string ServerBackupShort = GameManager.Default.ServerBackupShort;
    private static string ServerBackupLong = GameManager.Default.ServerBackupLong;
    private static bool ServerCrossplay = GameManager.Default.ServerCrossplay;
    private static bool ServerPublic = GameManager.Default.ServerPublic;
    private static bool ServerLogFile = GameManager.Default.ServerLogFile;
    private static string ServerPreset = GameManager.Default.ServerPreset;
    private static int ServerPresetTrackbar = GameManager.Default.ServerPresetTrackbar;

    private readonly string InstallDir = Path.Combine(Settings.Default.ServerPath, ServerFolderName);

    public FormValheim()
    {
        InitializeComponent();
        StartUp();
    }

    private void StartUp()
    {
        // Timer Start
        Timer();
        // Load Form Settings
        LoadFormSettings();
        // Load Color Settings
        LoadColorSettings();
        // Load Settings
        LoadSettings();
        // Checks
        CheckServerInstalled();
        CheckServerRunning();
        SettingsEnabeld();
        // Update Process Info
        UpdateRAMInfo();
    }

    // Timer
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
    // Timer Eventhandler
    private void Timer_Tick_Short(object sender, EventArgs e)
    {

    }
    private void Timer_Tick_Long(object sender, EventArgs e)
    {
        CheckServerRunning();
        UpdateRAMInfo();
        SettingsEnabeld();
    }

    // Load Form Settings
    private void LoadFormSettings()
    {
        // Form Settings
        ControlBox = false;
        DoubleBuffered = true;
        BackColor = ColorTheme.Default.FormBG;
    }

    // Lade Farb Einstellungen
    private void LoadColorSettings()
    {

        // Form
        BackColor = ColorTheme.Default.FormBG;
        // Buttons
        btnInstallServer.IconColor = ColorTheme.Default.IconValheim;
        btnInstallServer.ForeColor = ColorTheme.Default.Text;
        btnInstallServer.BackColor = ColorTheme.Default.ButtonBG;
        btnInstallServer.IconColor = ColorTheme.Default.Icon;
        btnInstallServer.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnInstallServer.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnUninstallServer.IconColor = ColorTheme.Default.Icon;
        btnUninstallServer.ForeColor = ColorTheme.Default.Text;
        btnUninstallServer.BackColor = ColorTheme.Default.ButtonBG;
        btnUninstallServer.IconColor = ColorTheme.Default.Icon;
        btnUninstallServer.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnUninstallServer.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnStartServer.IconColor = ColorTheme.Default.IconValheim;
        btnStartServer.ForeColor = ColorTheme.Default.Text;
        btnStartServer.BackColor = ColorTheme.Default.ButtonBG;
        btnStartServer.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnStartServer.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnStopServer.IconColor = ColorTheme.Default.IconValheim;
        btnStopServer.ForeColor = ColorTheme.Default.Text;
        btnStopServer.BackColor = ColorTheme.Default.ButtonBG;
        btnStopServer.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnStopServer.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnOpenLogFile.IconColor = ColorTheme.Default.IconValheim;
        btnOpenLogFile.ForeColor = ColorTheme.Default.Text;
        btnOpenLogFile.BackColor = ColorTheme.Default.ButtonBG;
        btnOpenLogFile.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnOpenLogFile.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnOpenServerDir.IconColor = ColorTheme.Default.IconValheim;
        btnOpenServerDir.ForeColor = ColorTheme.Default.Text;
        btnOpenServerDir.BackColor = ColorTheme.Default.ButtonBG;
        btnOpenServerDir.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnOpenServerDir.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        // Textboxen
        tbServerNameInfo.BackColor = ColorTheme.Default.TextBoxBG;
        tbServerNameInfo.ForeColor = ColorTheme.Default.TextBoxText;
        tbServerPasswordInfo.BackColor = ColorTheme.Default.TextBoxBG;
        tbServerPasswordInfo.ForeColor = ColorTheme.Default.TextBoxText;
        tbServerPortInfo.BackColor = ColorTheme.Default.TextBoxBG;
        tbServerPortInfo.ForeColor = ColorTheme.Default.TextBoxText;
        tbServerWorldInfo.BackColor = ColorTheme.Default.TextBoxBG;
        tbServerWorldInfo.ForeColor = ColorTheme.Default.TextBoxText;
        tbServerBackupsInfo.BackColor = ColorTheme.Default.TextBoxBG;
        tbServerBackupsInfo.ForeColor = ColorTheme.Default.TextBoxText;
        tbServerSaveDirInfo.BackColor = ColorTheme.Default.TextBoxBG;
        tbServerSaveDirInfo.ForeColor = ColorTheme.Default.TextBoxText;
        tbServerSaveIntervalInfo.BackColor = ColorTheme.Default.TextBoxBG;
        tbServerSaveIntervalInfo.ForeColor = ColorTheme.Default.TextBoxText;
        tbBackupShortInfo.BackColor = ColorTheme.Default.TextBoxBG;
        tbBackupShortInfo.ForeColor = ColorTheme.Default.TextBoxText;
        tbBackupLongInfo.BackColor = ColorTheme.Default.TextBoxBG;
        tbBackupLongInfo.ForeColor = ColorTheme.Default.TextBoxText;
    }

    // Load Settings
    private void LoadSettings()
    {
        // Load Labels
        lblServerPathInfo.Text = InstallDir;


        // Load Textboxes
        tbServerNameInfo.Text = $"{ServerName}";
        tbServerPasswordInfo.Text = $"{ServerPassword}";
        tbServerIPInfo.Text = $"{GetLocalIPAddress()}";
        tbServerPortInfo.Text = $"{ServerPort}";
        tbServerWorldInfo.Text = $"{ServerWorld}";
        tbServerBackupsInfo.Text = $"{ServerBackups}";
        tbServerSaveDirInfo.Text = $"{ServerSaveDir}";
        tbServerSaveIntervalInfo.Text = $"{ServerSaveInterval}";
        tbBackupShortInfo.Text = $"{ServerBackupShort}";
        tbBackupLongInfo.Text = $"{ServerBackupLong}";

        // Load Checkboxes
        cbCrossplay.Checked = ServerCrossplay;
        cbPublic.Checked = ServerPublic;
        cbLogFile.Checked = ServerLogFile;

        // Load Preset Bar
        trackBarPreset.Value = ServerPresetTrackbar;
        LoadPreset(ServerPresetTrackbar);
    }

    // Disable Editing Settings if Server is Running
    private void SettingsEnabeld()
    {
        if (IsProcessRunning(ProzessName))
        {
            EnableSettings(false);
            return;
        }
        else
        {
            EnableSettings(true);
        }
    }

    // Set Editing Settings
    private void EnableSettings(bool value)
    {
        // Textboxes
        tbServerNameInfo.Enabled = value;
        tbServerPasswordInfo.Enabled = value;
        tbServerPortInfo.Enabled = value;
        tbServerWorldInfo.Enabled = value;
        tbServerBackupsInfo.Enabled = value;
        tbServerSaveDirInfo.Enabled = value;
        tbServerSaveIntervalInfo.Enabled = value;
        tbBackupShortInfo.Enabled = value;
        tbBackupLongInfo.Enabled = value;
        // Checkboxes
        cbCrossplay.Enabled = value;
        cbPublic.Enabled = value;
        cbLogFile.Enabled = value;
        // Trackbar
        trackBarPreset.Enabled = value;
        // Buttons
        btnInstallServer.Enabled = value;
        btnUninstallServer.Enabled = value;
        btnOpenLogFile.Enabled = value;
    }

    // Start Server
    private void StartProcess()
    {
        try
        {
            var processPath = Path.Combine(InstallDir, BATName);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = processPath;
            startInfo.UseShellExecute = false; // Erforderlich für WindowStyle-Eigenschaft
            startInfo.CreateNoWindow = true; // Kein Fenster erstellen
            startInfo.WindowStyle = ProcessWindowStyle.Hidden; // Verstecktes Fenster
            Process.Start(startInfo);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Starten des Prozesses: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Stop Server
    private void StopProcess()
    {
        try
        {
            Process[] processes = Process.GetProcessesByName(ProzessName);
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Stoppen des Prozesses: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Check Folder Exist
    private void CheckFolderExist()
    {
        if (!Directory.Exists(InstallDir))
        {
            Directory.CreateDirectory(InstallDir);
        }
        if (!Directory.Exists(Path.Combine(InstallDir, ServerSaveDir)))
        {
            Directory.CreateDirectory(Path.Combine(InstallDir, ServerSaveDir));
        }
    }

    // Install Server 
    private void InstallServer()
    {
        // Ceck if the Server is Running
        if (IsProcessRunning(ProzessName))
        {
            MessageBox.Show("The Server is still running. Please stop the Server first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if the Path to the Server is set
        if (string.IsNullOrEmpty(Settings.Default.ServerPath))
        {
            ShowErrorMessage("The path to the Server is not set!");
            return;
        }
        // Check if Server is already installed
        if (File.Exists(Path.Combine(InstallDir, ServerExe)))
        {

            DialogResult dialogResult = MessageBox.Show("Do you want to Update the Server?", "Update Server", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        CheckFolderExist();
        FormSteamCMD formSteamCMD = new FormSteamCMD();
        formSteamCMD.StartSteamCMD($"+force_install_dir \"{InstallDir}\" +login anonymous +app_update {SteamAppID} validate +exit");
        formSteamCMD.ShowDialog();
        CheckServerInstalled();
    }

    private void ShowErrorMessage(string v) => throw new NotImplementedException();

    // Check Server is Installed
    private void CheckServerInstalled()
    {
        if (File.Exists(Path.Combine(InstallDir, ServerExe)))
        {
            btnInstallServer.Text = "Update Server";
            btnUninstallServer.Enabled = true;
            lblServerInstalledInfo.ForeColor = System.Drawing.Color.Green;
            lblServerInstalledInfo.Text = "Installed";
        }
        else
        {
            btnInstallServer.Text = "Install Server";
            btnUninstallServer.Enabled = false;
            lblServerInstalledInfo.ForeColor = System.Drawing.Color.Red;
            lblServerInstalledInfo.Text = "Not Installed";
        }
    }

    // Check Server Running and Display Info
    private void CheckServerRunning()
    {
        // Überprüfen, ob der Prozess läuft
        if (IsProcessRunning(ProzessName))
        {
            lblServerRunningInfo.ForeColor = System.Drawing.Color.Green;
            // Server is Running
            lblServerRunningInfo.Text = "Der Prozess läuft.";
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
        }
        else
        {
            lblServerRunningInfo.ForeColor = System.Drawing.Color.Red;
            // Server is not Running
            lblServerRunningInfo.Text = "Der Prozess läuft nicht.";
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
        }
    }
    // Check Process Running 
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

    // Methode für die Aktualisierung der CPU-Informationen
    private void UpdateCPUInfo()
    {
        lblCPUUsageInfo.Text = Worker.CPUUsage.Update(ProzessName);
    }

    // Methode für die Aktualisierung der RAM-Informationen
    private void UpdateRAMInfo()
    {
        (var ramUsageInfoText, var progressBarValue) = Worker.RAMUsage.UpdateShortGB(ProzessName);
        lblRAMUsageInfo.Text = ramUsageInfoText;
        progressBarRAM.Value = progressBarValue;
    }

    // Uninstall Server from System
    private void UninstallServer()
    {
        // Check if Server is installed
        if (!File.Exists(Path.Combine(InstallDir, ServerExe)))
        {
            MessageBox.Show("The Server is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if the Server is Running
        if (IsProcessRunning(ProzessName))
        {
            MessageBox.Show("The Server is still running. Please stop the Server first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if the User really want to delete the Server
        DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the Valheim Server?", "Delete Server", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            Directory.Delete(InstallDir, true);
            CheckServerInstalled();
        }
    }

    // Create Server Start Bat File
    private void CreateStartBat()
    {
        if (File.Exists(Path.Combine(InstallDir, ServerExe)))
        {
            var batFile = Path.Combine(InstallDir, BATName);
            string batContent_Public;
            var batContent_ServerLog = "";
            string batContent_Crossplay;

            // Public Server
            if (ServerPublic)
            {
                batContent_Public = "-public 1 ";
            }
            else
            {
                batContent_Public = "-public 0 ";
            }
            // Server Log File
            if (ServerLogFile)
            {
                batContent_ServerLog += $"-logfile \"{Path.Combine(InstallDir, ServerLogFileName)}\" ";
            }
            else
            {
                batContent_ServerLog = "";
            }
            // Crossplay
            if (ServerCrossplay)
            {
                batContent_Crossplay = "-crossplay ";
            }
            else
            {
                batContent_Crossplay = "";
            }

            // Inhalt der Batch-Datei
            var batContent = $"@echo off\n" +
                             $"title Valheim Gameserver\n" +
                             $"set SteamAppId={BATAppID}\n\n" +
                             $"{Path.Combine(InstallDir, BATExeName)} " +
                             $"-nographics " +
                             $"-batchmode " +
                             $"-name \"{ServerName}\" " +
                             $"-port {ServerPort} " +
                             $"-world \"{ServerWorld}\" " +
                             $"-password \"{ServerPassword}\" " +
                             $"-savedir {Path.Combine(InstallDir, ServerSaveDir)} " +
                             $"{batContent_Public}" +
                             $"{batContent_ServerLog}" +
                             $"-saveinterval {ServerSaveInterval} " +
                             $"-backups {ServerBackups} " +
                             $"-backupshort {ServerBackupShort} " +
                             $"-backuplong {ServerBackupLong} " +
                             $"{batContent_Crossplay}" +
                             $"-preset {ServerPreset} ";

            // Batch-Datei erstellen
            try
            {
                File.WriteAllText(batFile, batContent);
                //MessageBox.Show("StartServer.bat created", "BAT File Created");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Fehler beim Erstellen der Batch-Datei: " + ex.Message);
            }
        }
    }

    private string GetLocalIPAddress()
    {
        // IP-Adresse des lokalen Computers abrufen
        var localIP = "";
        try
        {
            // IPv4-Adressen ermitteln
            foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = address.ToString();
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Abrufen der IP-Adresse: " + ex.Message);
        }
        return localIP;
    }

    //
    // Buttons
    //

    // Install Server Button
    private void btnInstallServer_Click(object sender, EventArgs e)
    {
        InstallServer();
    }

    // Uninstall Server Button
    private void btnUninstallServer_Click(object sender, EventArgs e)
    {
        UninstallServer();
    }

    // Start Server Button
    private void btnStartServer_Click(object sender, EventArgs e)
    {
        CreateStartBat();
        // Wait for Bat File
        Thread.Sleep(500);
        StartProcess();
        CheckServerRunning();
    }
    // Stop Server Button
    private void btnStopServer_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Do you want to Stop the Server?", "Stop Server", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            StopProcess();
            CheckServerRunning();
            return;
        }
    }

    // Open Log File Button
    private void btnOpenLogFile_Click(object sender, EventArgs e)
    {
        // Überprüfen, ob die Textdatei existiert
        if (File.Exists(Path.Combine(InstallDir, ServerLogFileName)))
        {
            try
            {
                // Öffne die Textdatei mit der Standardanwendung für Textdateien
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Path.Combine(InstallDir, ServerLogFileName);
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Öffnen der Logdatei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Die Logdatei existiert nicht.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Open Server Directory Button
    private void btnOpenServerDir_Click(object sender, EventArgs e)
    {
        if (Directory.Exists(InstallDir))
        {
            // Öffne das Verzeichnis im Explorer
            Process.Start("explorer.exe", InstallDir);
        }
        else
        {
            MessageBox.Show("Das Verzeichnis existiert nicht.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    // 
    // Textboxes
    //
    private void tbServerNameInfo_TextChanged(object sender, EventArgs e)
    {
        ServerName = tbServerNameInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerPasswordInfo_TextChanged(object sender, EventArgs e)
    {
        ServerPassword = tbServerPasswordInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerPortInfo_TextChanged(object sender, EventArgs e)
    {
        ServerPort = tbServerPortInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerWorldInfo_TextChanged(object sender, EventArgs e)
    {
        ServerWorld = tbServerWorldInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerBackupsInfo_TextChanged(object sender, EventArgs e)
    {
        ServerBackups = tbServerBackupsInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerSaveDirInfo_TextChanged(object sender, EventArgs e)
    {
        ServerSaveDir = tbServerSaveDirInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerSaveIntervalInfo_TextChanged(object sender, EventArgs e)
    {
        ServerSaveInterval = tbServerSaveIntervalInfo.Text;
        GameManager.Default.Save();
    }

    private void tbBackupShortInfo_TextChanged(object sender, EventArgs e)
    {
        ServerBackupShort = tbBackupShortInfo.Text;
        GameManager.Default.Save();
    }

    private void tbBackupLonfInfo_TextChanged(object sender, EventArgs e)
    {
        ServerBackupLong = tbBackupLongInfo.Text;
        GameManager.Default.Save();
    }

    //
    // Checkboxes
    //
    private void cbCrossplay_CheckedChanged(object sender, EventArgs e)
    {
        ServerCrossplay = cbCrossplay.Checked;
        GameManager.Default.Save();
    }

    private void cbPublic_CheckedChanged(object sender, EventArgs e)
    {
        ServerPublic = cbPublic.Checked;
        GameManager.Default.Save();
    }

    private void cbLogFile_CheckedChanged(object sender, EventArgs e)
    {
        ServerLogFile = cbLogFile.Checked;
        GameManager.Default.Save();
    }

    //
    // Preset
    //    
    private void PresetCasual()
    {
        // Casual
        lblPresetCasual.Font = new Font(lblPreset.Font, FontStyle.Bold);
        lblPresetEasy.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetNormal.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHard.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHardcore.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetImmersive.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHammer.Font = new Font(lblPreset.Font, FontStyle.Regular);
        ServerPreset = "casual";
        ServerPresetTrackbar = 1;
        GameManager.Default.Save();
    }
    private void PresetEasy()
    {
        // Easy
        lblPresetCasual.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetEasy.Font = new Font(lblPreset.Font, FontStyle.Bold);
        lblPresetNormal.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHard.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHardcore.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetImmersive.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHammer.Font = new Font(lblPreset.Font, FontStyle.Regular);
        ServerPreset = "easy";
        ServerPresetTrackbar = 2;
        GameManager.Default.Save();
    }
    private void PresetNormal()
    {
        // Normal
        lblPresetCasual.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetEasy.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetNormal.Font = new Font(lblPreset.Font, FontStyle.Bold);
        lblPresetHard.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHardcore.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetImmersive.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHammer.Font = new Font(lblPreset.Font, FontStyle.Regular);
        ServerPreset = "normal";
        ServerPresetTrackbar = 3;
        GameManager.Default.Save();
    }
    private void PresetHard()
    {
        // Hard
        lblPresetCasual.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetEasy.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetNormal.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHard.Font = new Font(lblPreset.Font, FontStyle.Bold);
        lblPresetHardcore.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetImmersive.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHammer.Font = new Font(lblPreset.Font, FontStyle.Regular);
        ServerPreset = "hard";
        ServerPresetTrackbar = 4;
        GameManager.Default.Save();
    }
    private void PresetHardcore()
    {
        // Hardcore
        lblPresetCasual.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetEasy.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetNormal.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHard.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHardcore.Font = new Font(lblPreset.Font, FontStyle.Bold);
        lblPresetImmersive.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHammer.Font = new Font(lblPreset.Font, FontStyle.Regular);
        ServerPreset = "hardcore";
        ServerPresetTrackbar = 5;
        GameManager.Default.Save();
    }
    private void PresetImmersive()
    {
        // Immersive
        lblPresetCasual.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetEasy.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetNormal.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHard.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHardcore.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetImmersive.Font = new Font(lblPreset.Font, FontStyle.Bold);
        lblPresetHammer.Font = new Font(lblPreset.Font, FontStyle.Regular);
        ServerPreset = "immersive";
        ServerPresetTrackbar = 6;
        GameManager.Default.Save();
    }
    private void PresetHammer()
    {
        // Hammer
        lblPresetCasual.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetEasy.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetNormal.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHard.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHardcore.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetImmersive.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHammer.Font = new Font(lblPreset.Font, FontStyle.Bold);
        ServerPreset = "hammer";
        ServerPresetTrackbar = 7;
        GameManager.Default.Save();
    }

    private void LoadPreset(int value)
    {
        switch (value)
        {
            case 1:
                //Casual
                PresetCasual();
                break;
            case 2:
                // Easy
                PresetEasy();
                break;
            case 3:
                PresetNormal();
                break;
            case 4:
                // Hard
                PresetHard();
                break;
            case 5:
                // Hardcore
                PresetHardcore();
                break;
            case 6:
                // Immersive
                PresetImmersive();
                break;
            case 7:
                // Hammer
                PresetHammer();
                break;
            default:
                // Hard
                PresetHard();
                break;
        }
    }

    private void trackBarPreset_Scroll(object sender, EventArgs e)
    {
        switch (trackBarPreset.Value)
        {
            case 1:
                // Casual
                PresetCasual();
                break;
            case 2:
                // Easy
                PresetEasy();
                break;
            case 3:
                PresetNormal();
                break;
            case 4:
                // Hard
                PresetHard();
                break;
            case 5:
                // Hardcore
                PresetHardcore();
                break;
            case 6:
                // Immersive
                PresetImmersive();
                break;
            case 7:
                // Hammer
                PresetHammer();
                break;
            default:
                // Hard
                PresetHard();
                break;
        }
    }
}
