using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game_Server_Manager.Properties;
using Newtonsoft.Json;

namespace Game_Server_Manager.Forms;
public partial class FormUpdaterBM : Form
{
    private const string Owner = "le3tspeak";
    private const string Repo = "ByteMaster";
    private readonly string Version = Settings.Default.Version;
    private string LatestVersion = "";

    public FormUpdaterBM()
    {
        InitializeComponent();
        StartUp();
    }

    // Startroutine
    private void StartUp()
    {
        // Form Einstellungen
        LoadFormSettings();
        // Farb Einstellungen
        LoadColorSettings();
        // Infos laden
        LoadInfos();
        // Version Update
        UpdateVersion();
    }

    // Laden der Form Einstellungen
    private void LoadFormSettings()
    {
        ControlBox = false;
        DoubleBuffered = true;
    }

    // Laden der Infos
    private void LoadInfos()
    {
        lblVersionInfo.Text = $"{Settings.Default.Version}";
    }

    // Lade Farb Einstellungen
    private void LoadColorSettings()
    {
        // Form
        BackColor = ColorTheme.Default.FormBGPopup;
        // TopBar
        panelTopBar.BackColor = ColorTheme.Default.FormBGPopupTopBar;
        // Buttons
        btnUpdate.IconColor = ColorTheme.Default.Icon;
        btnUpdate.ForeColor = ColorTheme.Default.Text;
        btnExit.IconColor = ColorTheme.Default.Icon;
        btnExit.ForeColor = ColorTheme.Default.Text;
    }

    private async void UpdateVersion()
    {
        try
        {
            var latestVersion = await GetLatestVersion();
            lblLatestVersion.Text = latestVersion;

            if (Settings.Default.Version != latestVersion)
            {
                lblNewVersion.Text = "Es ist eine neue Version verfügbar";
                btnUpdate.Enabled = true;
            }
            else
            {
                lblNewVersion.Text = "Sie verwenden bereits die neueste Version.";
                btnUpdate.Enabled = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Abrufen der neuesten Version: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task<string> GetLatestVersion()
    {
        using HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.UserAgent.ParseAdd("GitHubReleaseDownloader");

        HttpResponseMessage response = await client.GetAsync($"https://api.github.com/repos/{Owner}/{Repo}/releases/latest");
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();
        dynamic release = JsonConvert.DeserializeObject(responseBody);
        return release.tag_name;
    }

    public static void StartInstaller(string installerPath)
    {
        try
        {
            // Überprüfe, ob die Datei existiert
            if (!File.Exists(installerPath))
            {
                MessageBox.Show("Die Installer-Datei wurde nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Starte den Installer
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = installerPath;
            startInfo.Arguments = "";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(startInfo);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Starten des Installers: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Methode zum Starten des Downloads der neuesten Version
    private async void btnDownload_Click(object sender, EventArgs e)
    {
        var latestVersion = await GetLatestVersion();
        var downloadUrl = $"https://github.com/{Owner}/{Repo}/releases/download/{latestVersion}/ByteMaster.zip";
        var savePath = Path.Combine(Settings.Default.ServerPath, "Updater", "ByteMaster.zip");
        var unzipPath = Path.Combine(Settings.Default.ServerPath, "Updater");

        try
        {
            // prüfen, ob der Download-Ordner existiert
            if (!Directory.Exists(Path.Combine(Settings.Default.ServerPath, "Updater")))
                Directory.CreateDirectory(Path.Combine(Settings.Default.ServerPath, "Updater"));

            //Download the Release
            FormDownloader formDownloader = new FormDownloader();
            formDownloader.SetDownloadLink(downloadUrl, savePath);
            formDownloader.Download();
            formDownloader.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Herunterladen der neuesten Version: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        try
        {
            // Extract the SteamCMD
            FormZIP formZIP = new FormZIP();
            formZIP.SetZIPPath(savePath, unzipPath);
            formZIP.Extract();
            formZIP.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Fehler beim Entpacken der neuesten Version: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Starte den Installer ByteMaster.msi
        StartInstaller(Path.Combine(Settings.Default.ServerPath, "Updater", "setup.exe"));

        // Schließe das Programm
        Program.Exit();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnUpdate_MouseEnter(object sender, EventArgs e)
    {
        btnUpdate.IconColor = RGBColors.Default.Confirm;
    }

    private void btnUpdate_MouseLeave(object sender, EventArgs e)
    {
        btnUpdate.IconColor = Color.White;
    }

    private void btnExit_MouseEnter(object sender, EventArgs e)
    {
        btnExit.IconColor = RGBColors.Default.Cancel;
    }

    private void btnExit_MouseLeave(object sender, EventArgs e)
    {
        btnExit.IconColor = Color.White;
    }
}
