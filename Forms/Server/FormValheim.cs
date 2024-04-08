using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using Game_Server_Manager.Properties;
using GameManager = Game_Server_Manager.Properties.Valheim;
using Timer = System.Windows.Forms.Timer;

namespace Game_Server_Manager.Forms;

public partial class FormValheim : Form
{
    // Konstanten
    private static readonly string ServerFolderName = GameManager.Default.ServerFolderName;
    private static readonly string ProzessName = GameManager.Default.ProzessName;
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
        // Check Server Installed
        CheckServerInstalled();
        // Check Server Running
        CheckServerRunning();
        // Update Process Info
        UpdateRAMInfo();
        // Settings Enabled
        SettingsEnabeld();
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
        btnInstallServer.ForeColor = ColorTheme.Default.Text;
        btnInstallServer.IconColor = ColorTheme.Default.Icon;
        btnInstallServer.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnInstallServer.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnUninstallServer.ForeColor = ColorTheme.Default.Text;
        btnUninstallServer.IconColor = ColorTheme.Default.Icon;
        btnUninstallServer.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnUninstallServer.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnStartServer.IconColor = ColorTheme.Default.Icon;
        btnStartServer.ForeColor = ColorTheme.Default.Text;
        btnStartServer.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnStartServer.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnStopServer.IconColor = ColorTheme.Default.Icon;
        btnStopServer.ForeColor = ColorTheme.Default.Text;
        btnStopServer.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnStopServer.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnOpenLogFile.IconColor = ColorTheme.Default.Icon;
        btnOpenLogFile.ForeColor = ColorTheme.Default.Text;
        btnOpenLogFile.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnOpenLogFile.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnOpenServerDir.IconColor = ColorTheme.Default.Icon;
        btnOpenServerDir.ForeColor = ColorTheme.Default.Text;
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
        lblLastUpdateInfo.Text = Settings.Default.ValheimLastUpdate;

        // Load Textboxes
        tbServerNameInfo.Text = $"{GameManager.Default.ServerName}";
        tbServerPasswordInfo.Text = $"{GameManager.Default.ServerPassword}";
        tbServerIPInfo.Text = $"{GetLocalIPAddress()}";
        tbServerPortInfo.Text = $"{GameManager.Default.ServerPort}";
        tbServerWorldInfo.Text = $"{GameManager.Default.ServerWorld}";
        tbServerBackupsInfo.Text = $"{GameManager.Default.ServerBackups}";
        tbServerSaveDirInfo.Text = $"{GameManager.Default.ServerSaveDir}";
        tbServerSaveIntervalInfo.Text = $"{GameManager.Default.ServerSaveInterval}";
        tbBackupShortInfo.Text = $"{GameManager.Default.ServerBackupShort}";
        tbBackupLongInfo.Text = $"{GameManager.Default.ServerBackupLong}";

        // Load Checkboxes
        cbCrossplay.Checked = GameManager.Default.ServerCrossplay;
        cbPublic.Checked = GameManager.Default.ServerPublic;
        cbLogFile.Checked = GameManager.Default.ServerLogFile;

        // Load Trackbar
        InitializeTrackbar();
    }

    // Disable Editing Settings if Server is Running
    private void SettingsEnabeld()
    {
        if (IsProcessRunning(GameManager.Default.ProzessName))
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
            var processPath = Path.Combine(InstallDir, GameManager.Default.BATName);

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
            Process[] processes = Process.GetProcessesByName(GameManager.Default.ProzessName);
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
        if (!Directory.Exists(Path.Combine(InstallDir, GameManager.Default.ServerSaveDir)))
        {
            Directory.CreateDirectory(Path.Combine(InstallDir, GameManager.Default.ServerSaveDir));
        }
    }

    // Install Server 
    private void InstallServer()
    {
        // Ceck if the Server is Running
        if (IsProcessRunning(GameManager.Default.ProzessName))
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
        if (File.Exists(Path.Combine(InstallDir, GameManager.Default.ServerExe)))
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Update the Server?", "Uninstall SteamCMD", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        CheckFolderExist();
        FormSteamCMD formSteamCMD = new FormSteamCMD();
        formSteamCMD.StartSteamCMD($"+force_install_dir \"{InstallDir}\" +login anonymous +app_update {GameManager.Default.SteamAppID} validate +exit");
        formSteamCMD.ShowDialog();
        CheckServerInstalled();

        // Save Server Update Time
        Settings.Default.ValheimLastUpdate = DateTime.Now.ToString();
        Settings.Default.Save();
    }

    private void ShowErrorMessage(string v) => throw new NotImplementedException();

    // Check Server is Installed
    private void CheckServerInstalled()
    {
        if (File.Exists(Path.Combine(InstallDir, GameManager.Default.ServerExe)))
        {
            btnInstallServer.Text = "Update Server";
            btnUninstallServer.Enabled = true;
            lblServerInstalledInfo.ForeColor = Color.Green;
            lblServerInstalledInfo.Text = "Installed";
        }
        else
        {
            btnInstallServer.Text = "Install Server";
            btnUninstallServer.Enabled = false;
            lblServerInstalledInfo.ForeColor = Color.Red;
            lblServerInstalledInfo.Text = "Not Installed";
        }
    }

    // Check Server Running and Display Info
    private void CheckServerRunning()
    {
        // Überprüfen, ob der Prozess läuft
        if (IsProcessRunning(GameManager.Default.ProzessName))
        {
            lblServerRunningInfo.ForeColor = Color.Green;
            // Server is Running
            lblServerRunningInfo.Text = "Der Prozess läuft.";
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
            lblLastUpdateInfo.Text = Settings.Default.ValheimLastUpdate;
        }
        else
        {
            lblServerRunningInfo.ForeColor = Color.Red;
            // Server is not Running
            lblServerRunningInfo.Text = "Der Prozess läuft nicht.";
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
            lblLastUpdateInfo.Text = Settings.Default.ValheimLastUpdate;
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

    // Methode für die Aktualisierung der RAM-Informationen
    private void UpdateRAMInfo()
    {
        (var ramUsageInfoText, var progressBarValue) = Worker.RAMUsage.UpdateShortGB(GameManager.Default.ProzessName);
        lblRAMUsageInfo.Text = ramUsageInfoText;
        progressBarRAM.Value = progressBarValue;
    }

    // Uninstall Server from System
    private void UninstallServer()
    {
        // Check if Server is installed
        if (!File.Exists(Path.Combine(InstallDir, GameManager.Default.ServerExe)))
        {
            MessageBox.Show("The Server is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Check if the Server is Running
        if (IsProcessRunning(GameManager.Default.ProzessName))
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
        if (File.Exists(Path.Combine(InstallDir, GameManager.Default.ServerExe)))
        {
            var batFile = Path.Combine(InstallDir, GameManager.Default.BATName);
            string batContent_Public;
            var batContent_ServerLog = "";
            string batContent_Crossplay;

            // Public Server
            if (GameManager.Default.ServerPublic)
            {
                batContent_Public = "-public 1 ";
            }
            else
            {
                batContent_Public = "-public 0 ";
            }
            // Server Log File
            if (GameManager.Default.ServerLogFile)
            {
                batContent_ServerLog += $"-logfile \"{Path.Combine(InstallDir, GameManager.Default.ServerLogFileName)}\" ";
            }
            else
            {
                batContent_ServerLog = "";
            }
            // Crossplay
            if (GameManager.Default.ServerCrossplay)
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
                             $"set SteamAppId={GameManager.Default.BATAppID}\n\n" +
                             $"{Path.Combine(InstallDir, GameManager.Default.BATEXEName)} " +
                             $"-nographics " +
                             $"-batchmode " +
                             $"-name \"{GameManager.Default.ServerName}\" " +
                             $"-port {GameManager.Default.ServerPort} " +
                             $"-world \"{GameManager.Default.ServerWorld}\" " +
                             $"-password \"{GameManager.Default.ServerPassword}\" " +
                             $"-savedir {Path.Combine(InstallDir, GameManager.Default.ServerSaveDir)} " +
                             $"{batContent_Public}" +
                             $"{batContent_ServerLog}" +
                             $"-saveinterval {GameManager.Default.ServerSaveInterval} " +
                             $"-backups {GameManager.Default.ServerBackups} " +
                             $"-backupshort {GameManager.Default.ServerBackupShort} " +
                             $"-backuplong {GameManager.Default.ServerBackupLong} " +
                             $"{batContent_Crossplay}" +
                             $"-preset {GameManager.Default.ServerPreset} ";

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
        DialogResult dialogResult = MessageBox.Show("Do you want to Uninstall the Server?", "Uninstall Server", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            UninstallServer();
            return;
        }
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
        if (File.Exists(Path.Combine(InstallDir, GameManager.Default.ServerLogFileName)))
        {
            try
            {
                // Öffne die Textdatei mit der Standardanwendung für Textdateien
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Path.Combine(InstallDir, GameManager.Default.ServerLogFileName);
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
        GameManager.Default.ServerName = tbServerNameInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerPasswordInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfe ob das Passwort Leerzeichen enthält
        if (tbServerPasswordInfo.Text.Contains(" "))
        {
            MessageBox.Show("The password must not contain any spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerPasswordInfo.Text = GameManager.Default.ServerPassword;
            return;
        }
        GameManager.Default.ServerPassword = tbServerPasswordInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerPortInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfe ob der Port eine Zahl ist
        if (!int.TryParse(tbServerPortInfo.Text, out _))
        {
            MessageBox.Show("The port must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerPortInfo.Text = GameManager.Default.ServerPort;
            return;
        }

        GameManager.Default.ServerPort = tbServerPortInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerWorldInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfe auf Leerzeichen
        if (tbServerWorldInfo.Text.Contains(" "))
        {
            MessageBox.Show("The world name must not contain any spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerWorldInfo.Text = GameManager.Default.ServerWorld;
            return;
        }

        GameManager.Default.ServerWorld = tbServerWorldInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerBackupsInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfe ob der Wert eine Zahl ist
        if (!int.TryParse(tbServerBackupsInfo.Text, out _))
        {
            MessageBox.Show("The number of backups must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerBackupsInfo.Text = GameManager.Default.ServerBackups;
            return;
        }

        GameManager.Default.ServerBackups = tbServerBackupsInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerSaveDirInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfe auf Leerzeichen
        if (tbServerSaveDirInfo.Text.Contains(" "))
        {
            MessageBox.Show("The save directory must not contain any spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerSaveDirInfo.Text = GameManager.Default.ServerSaveDir;
            return;
        }

        GameManager.Default.ServerSaveDir = tbServerSaveDirInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerSaveIntervalInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfe ob der Wert eine Zahl ist
        if (!int.TryParse(tbServerSaveIntervalInfo.Text, out _))
        {
            MessageBox.Show("The save interval must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerSaveIntervalInfo.Text = GameManager.Default.ServerSaveInterval;
            return;
        }

        GameManager.Default.ServerSaveInterval = tbServerSaveIntervalInfo.Text;
        GameManager.Default.Save();
    }

    private void tbBackupShortInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfe ob der Wert eine Zahl ist
        if (!int.TryParse(tbBackupShortInfo.Text, out _))
        {
            MessageBox.Show("The short backup interval must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbBackupShortInfo.Text = GameManager.Default.ServerBackupShort;
            return;
        }

        GameManager.Default.ServerBackupShort = tbBackupShortInfo.Text;
        GameManager.Default.Save();
    }

    private void tbBackupLonfInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfe ob der Wert eine Zahl ist
        if (!int.TryParse(tbBackupLongInfo.Text, out _))
        {

            MessageBox.Show("The long backup interval must be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbBackupLongInfo.Text = GameManager.Default.ServerBackupLong;
            return;
        }

        GameManager.Default.ServerBackupLong = tbBackupLongInfo.Text;
        GameManager.Default.Save();
    }

    //
    // Checkboxes
    //
    private void cbCrossplay_CheckedChanged(object sender, EventArgs e)
    {
        GameManager.Default.ServerCrossplay = cbCrossplay.Checked;
        GameManager.Default.Save();
    }

    private void cbPublic_CheckedChanged(object sender, EventArgs e)
    {
        GameManager.Default.ServerPublic = cbPublic.Checked;
        GameManager.Default.Save();
    }

    private void cbLogFile_CheckedChanged(object sender, EventArgs e)
    {
        GameManager.Default.ServerLogFile = cbLogFile.Checked;
        GameManager.Default.Save();
    }

    //
    // Preset
    //    
    private void InitializeTrackbar()
    {
        var defaultTrackbarValue = 1; // Setzen Sie hier den Standardwert für den Trackbar-Wert

        // Laden Sie den Wert aus der Konfiguration oder verwenden Sie den Standardwert, falls nicht vorhanden
        var savedTrackbarValue = GameManager.Default.ServerPresetTrackbarValue;

        // Stellen Sie sicher, dass der gespeicherte Wert im gültigen Bereich liegt
        if (savedTrackbarValue < trackBarPreset.Minimum || savedTrackbarValue > trackBarPreset.Maximum)
        {
            savedTrackbarValue = defaultTrackbarValue;
        }

        // Setzen Sie den Trackbar-Wert
        trackBarPreset.Value = savedTrackbarValue;

        // Laden Sie die Einstellungen entsprechend dem Trackbar-Wert
        LoadPreset(savedTrackbarValue);
    }

    private void ApplyPreset(string preset, FontStyle fontStyle, int trackbarValue)
    {
        lblPresetCasual.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetEasy.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetNormal.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHard.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHardcore.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetImmersive.Font = new Font(lblPreset.Font, FontStyle.Regular);
        lblPresetHammer.Font = new Font(lblPreset.Font, FontStyle.Regular);

        switch (preset.ToLower())
        {
            case "casual":
                lblPresetCasual.Font = new Font(lblPreset.Font, fontStyle);
                break;
            case "easy":
                lblPresetEasy.Font = new Font(lblPreset.Font, fontStyle);
                break;
            case "normal":
                lblPresetNormal.Font = new Font(lblPreset.Font, fontStyle);
                break;
            case "hard":
                lblPresetHard.Font = new Font(lblPreset.Font, fontStyle);
                break;
            case "hardcore":
                lblPresetHardcore.Font = new Font(lblPreset.Font, fontStyle);
                break;
            case "immersive":
                lblPresetImmersive.Font = new Font(lblPreset.Font, fontStyle);
                break;
            case "hammer":
                lblPresetHammer.Font = new Font(lblPreset.Font, fontStyle);
                break;
            default:
                throw new ArgumentException("Invalid preset");
        }

        GameManager.Default.ServerPreset = preset;
        GameManager.Default.ServerPresetTrackbarValue = trackbarValue;
        GameManager.Default.Save();
    }

    private void LoadPreset(int value)
    {
        switch (value)
        {
            case 1:
                ApplyPreset("casual", FontStyle.Bold, 1);
                break;
            case 2:
                ApplyPreset("easy", FontStyle.Bold, 2);
                break;
            case 3:
                ApplyPreset("normal", FontStyle.Bold, 3);
                break;
            case 4:
                ApplyPreset("hard", FontStyle.Bold, 4);
                break;
            case 5:
                ApplyPreset("hardcore", FontStyle.Bold, 5);
                break;
            case 6:
                ApplyPreset("immersive", FontStyle.Bold, 6);
                break;
            case 7:
                ApplyPreset("hammer", FontStyle.Bold, 7);
                break;
            default:
                LoadPreset(GameManager.Default.ServerPresetTrackbarValue);
                break;
        }
    }

    private void trackBarPreset_Scroll(object sender, EventArgs e)
    {
        var trackbarValue = trackBarPreset.Value;
        LoadPreset(trackbarValue);
    }
}
