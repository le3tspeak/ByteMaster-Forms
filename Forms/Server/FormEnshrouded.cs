using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using Game_Server_Manager.Properties;
using Newtonsoft.Json;
using GameManager = Game_Server_Manager.Properties.Enshrouded;
using Timer = System.Windows.Forms.Timer;

namespace Game_Server_Manager.Forms;

public partial class FormEnshrouded : Form
{
    // Alle Settings aus Properties.Enshrouded.Default
    private static readonly int SteamAppID = GameManager.Default.SteamAppID;
    private static readonly string ServerFolderName = GameManager.Default.ServerFolderName;
    private static readonly string ServerExe = GameManager.Default.ServerExe;
    private static readonly string ProzessName = GameManager.Default.ProzessName;
    private static string ServerName = GameManager.Default.ServerName;
    private static string ServerPassword = GameManager.Default.ServerPassword;
    private static string ServerPort = GameManager.Default.ServerPort;
    private static string ServerQueryPort = GameManager.Default.ServerQueryPort;
    private static string ServerSaveDir = GameManager.Default.ServerSaveDir;
    private static string ServerLogFolder = GameManager.Default.ServerLogFolder;
    private static string ServerCFGName = GameManager.Default.ServerCFGName;
    private static string ServerSlots = GameManager.Default.ServerSlots;

    private readonly string InstallDir = Path.Combine(Settings.Default.ServerPath, ServerFolderName);

    public FormEnshrouded()
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

    private void LoadColorSettings()
    {

        // Form
        BackColor = ColorTheme.Default.FormBG;
        // Buttons

        // Textboxen

    }
    private void LoadSettings()
    {
        // Load Labels
        lblServerPathInfo.Text = InstallDir;

        // Load Textboxes
        tbServerNameInfo.Text = $"{ServerName}";
        tbServerPasswordInfo.Text = $"{ServerPassword}";
        tbServerIPInfo.Text = $"{GetLocalIPAddress()}";
        tbServerPortInfo.Text = $"{ServerPort}";
        tbServerQueryPortInfo.Text = $"{ServerQueryPort}";
        tbServerSaveDirInfo.Text = $"{ServerSaveDir}";
        tbServerLogDirInfo.Text = $"{ServerLogFolder}";
        tbServerSlotsInfo.Text = $"{ServerSlots}";
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
        tbServerQueryPortInfo.Enabled = value;
        tbServerSaveDirInfo.Enabled = value;
        tbServerLogDirInfo.Enabled = value;
        tbServerSlotsInfo.Enabled = value;

        // Buttons
        btnInstallServer.Enabled = value;
        btnUninstallServer.Enabled = value;
    }

    // Start Server
    private void StartProcess()
    {
        try
        {
            var processPath = Path.Combine(InstallDir, ServerExe);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = processPath;
            startInfo.UseShellExecute = false; // Erforderlich für WindowStyle-Eigenschaft
            startInfo.CreateNoWindow = true; // Kein Fenster erstellen (True)
            startInfo.WindowStyle = ProcessWindowStyle.Hidden; // Verstecktes Fenster (Hidden)
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
        if (IsProcessRunning(ProzessName))
        {
            lblServerRunningInfo.ForeColor = Color.Green;
            // Server is Running
            lblServerRunningInfo.Text = "Der Prozess läuft.";
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
        }
        else
        {
            lblServerRunningInfo.ForeColor = Color.Red;
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
        DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the Enschrouded Server?", "Delete Server", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            Directory.Delete(InstallDir, true);
            CheckServerInstalled();
        }
    }

    // Create Server Config File
    private void CreateCFGJson()
    {
        if (File.Exists(Path.Combine(InstallDir, ServerExe)))
        {
            var JsonFile = Path.Combine(InstallDir, ServerCFGName);

            var serverConfig = new
            {
                name = ServerName,
                password = ServerPassword,
                saveDirectory = "./" + ServerSaveDir,
                serverLog = "./" + ServerLogFolder,
                ip = "0.0.0.0",
                port = ServerPort,
                queryPort = ServerQueryPort,
                maxPlayers = ServerSlots
            };

            try
            {
                var jsonContent = JsonConvert.SerializeObject(serverConfig, Formatting.Indented);
                File.WriteAllText(JsonFile, jsonContent);
                //MessageBox.Show("Server config file created successfully.", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating server config file: " + ex.Message, "Error");
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
        CreateCFGJson();
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

    // Open Log Directory Button
    private void btnOpenLogDir_Click(object sender, EventArgs e)
    {
        if (Directory.Exists(Path.Combine(InstallDir, ServerLogFolder)))
        {
            // Öffne das Verzeichnis im Explorer
            Process.Start("explorer.exe", Path.Combine(InstallDir, ServerLogFolder));
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
        // Prüfen auf Leerzeichen
        if (tbServerPasswordInfo.Text.Contains(" "))
        {
            MessageBox.Show("Please enter a password without spaces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerPasswordInfo.Text = "password";
            return;
        }
        ServerPassword = tbServerPasswordInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerPortInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfen, ob der Text in der Textbox eine Zahl ist ohne Leerzeichen
        if (!int.TryParse(tbServerPortInfo.Text, out _))
        {
            MessageBox.Show("Please enter a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerPortInfo.Text = "2456";
            return;
        }

        ServerPort = tbServerPortInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerQuaryPortInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfen, ob der Text in der Textbox eine Zahl ist ohne Leerzeichen
        if (!int.TryParse(tbServerQueryPortInfo.Text, out _))
        {
            MessageBox.Show("Please enter a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerQueryPortInfo.Text = "2456";
            return;
        }

        ServerQueryPort = tbServerQueryPortInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerSaveDirInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfen auf Sonderzeichen und Leerzeichen
        if (tbServerSaveDirInfo.Text.Contains(" ") || tbServerSaveDirInfo.Text.Contains("/") || tbServerSaveDirInfo.Text.Contains("\\") || tbServerSaveDirInfo.Text.Contains(":") || tbServerSaveDirInfo.Text.Contains("*") || tbServerSaveDirInfo.Text.Contains("?") || tbServerSaveDirInfo.Text.Contains("\"") || tbServerSaveDirInfo.Text.Contains("<") || tbServerSaveDirInfo.Text.Contains(">") || tbServerSaveDirInfo.Text.Contains("|"))
        {
            MessageBox.Show("Please enter a valid folder name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerSaveDirInfo.Text = "Save";
            return;
        }

        ServerSaveDir = tbServerSaveDirInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerLogDirInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfen auf Sonderzeichen und Leerzeichen
        if (tbServerLogDirInfo.Text.Contains(" ") || tbServerLogDirInfo.Text.Contains("/") || tbServerLogDirInfo.Text.Contains("\\") || tbServerLogDirInfo.Text.Contains(":") || tbServerLogDirInfo.Text.Contains("*") || tbServerLogDirInfo.Text.Contains("?") || tbServerLogDirInfo.Text.Contains("\"") || tbServerLogDirInfo.Text.Contains("<") || tbServerLogDirInfo.Text.Contains(">") || tbServerLogDirInfo.Text.Contains("|"))
        {
            MessageBox.Show("Please enter a valid folder name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerLogDirInfo.Text = "Logs";
            return;
        }
        ServerLogFolder = tbServerLogDirInfo.Text;
        GameManager.Default.Save();
    }

    private void tbServerSlotsInfo_TextChanged(object sender, EventArgs e)
    {
        // Prüfen, ob der Text in der Textbox eine Zahl ist
        if (!int.TryParse(tbServerSlotsInfo.Text, out _))
        {
            MessageBox.Show("Please enter a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerSlotsInfo.Text = "16";
            return;
        }

        // Prüfen ob der Wert zwischen 1 und 16 liegt
        if (Convert.ToInt32(tbServerSlotsInfo.Text) < 1 || Convert.ToInt32(tbServerSlotsInfo.Text) > 16)
        {
            MessageBox.Show("Please enter a number between 1 and 16!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbServerSlotsInfo.Text = ServerSlots;
            return;
        }

        ServerSlots = tbServerSlotsInfo.Text;
        GameManager.Default.Save();
    }
}
