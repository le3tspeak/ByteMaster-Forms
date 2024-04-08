using Game_Server_Manager.Properties;
using Newtonsoft.Json;

namespace Game_Server_Manager.Forms;
public partial class FormUpdaterBM : Form
{
    private const string Owner = "le3tspeak";
    private const string Repo = "ByteMaster";
    private readonly string Version = Properties.Settings.Default.Version;
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
        btnUpdate.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnUpdate.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnExit.IconColor = ColorTheme.Default.Icon;
        btnExit.ForeColor = ColorTheme.Default.Text;
        btnExit.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnExit.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
    }

    private async void UpdateVersion()
    {
        try
        {
            var latestVersion = await GetLatestVersion();
            lblLatestVersion.Text = latestVersion;

            if (Settings.Default.Version != LatestVersion)
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

    // Methode zum Starten des Downloads der neuesten Version
    private async void btnDownload_Click(object sender, EventArgs e)
    {
        try
        {
            var latestVersion = await GetLatestVersion();
            var downloadUrl = $"https://github.com/{Owner}/{Repo}/releases/download/{latestVersion}/ByteMasterV{latestVersion}.zip";
            var savePath = Path.Combine(Settings.Default.ServerPath, "GitHub", $"{latestVersion}.zip");

            // prüfen, ob der Download-Ordner existiert
            if (!Directory.Exists(Path.Combine(Settings.Default.ServerPath, "GitHub")))
                Directory.CreateDirectory(Path.Combine(Settings.Default.ServerPath, "GitHub"));

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
    }






    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
