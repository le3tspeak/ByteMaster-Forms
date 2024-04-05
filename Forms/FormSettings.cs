using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Server_Manager.Properties;
using Newtonsoft.Json.Linq;
using GameManager = Game_Server_Manager.Properties.Settings;

namespace Game_Server_Manager.Forms;

public partial class FormSettings : Form
{
    // Variables
    private readonly string downloadLink = GameManager.Default.SteamCMDURL;
    private readonly string downloadPath = Path.Combine(GameManager.Default.SteamCMDPath, "steamcmd.zip");
    private readonly string steamCMDzipPath = Path.Combine(GameManager.Default.SteamCMDPath, "steamcmd.zip");
    private readonly string steamCMDunzipPath = GameManager.Default.SteamCMDPath;

    public FormSettings()
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
        // Lade Informationen
        LoadInfos();
        //Lade SteamCMD Informationen
        SteamCMD();
    }

    // Laden der Einstellungen
    private void LoadInfos()
    {
        tbServerPath.Text = GameManager.Default.ServerPath;
        tbSteamCMDPath.Text = GameManager.Default.SteamCMDPath;
        lblVersion.Text = $"Version: {GameManager.Default.Version}";
    }

    // Laden der Form Einstellungen
    private void LoadFormSettings()
    {
        ControlBox = false;
        DoubleBuffered = true;
    }

    // Lade Farb Einstellungen
    private void LoadColorSettings()
    {
        // Form
        BackColor = ColorTheme.Default.FormBG;
        // Buttons
        btnSteamCMDInstall.IconColor = ColorTheme.Default.IconSteam;
        btnSteamCMDInstall.ForeColor = ColorTheme.Default.Text;
        btnSteamCMDInstall.BackColor = ColorTheme.Default.ButtonBG;
        btnSteamCMDInstall.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnSteamCMDInstall.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        btnSteamCMDUninstall.IconColor = ColorTheme.Default.IconSteam;
        btnSteamCMDUninstall.ForeColor = ColorTheme.Default.Text;
        btnSteamCMDUninstall.BackColor = ColorTheme.Default.ButtonBG;
        btnSteamCMDUninstall.FlatAppearance.MouseDownBackColor = ColorTheme.Default.MouseDown;
        btnSteamCMDUninstall.FlatAppearance.MouseOverBackColor = ColorTheme.Default.MouseHover;
        // Textboxen
        tbServerPath.BackColor = ColorTheme.Default.TextBoxBG;
        tbServerPath.ForeColor = ColorTheme.Default.TextBoxText;
        tbSteamCMDPath.BackColor = ColorTheme.Default.TextBoxBG;
        tbSteamCMDPath.ForeColor = ColorTheme.Default.TextBoxText;
    }

    // Test the Variables and show an error message if one or more are empty
    public static bool ValidateSettings(string downloadLink, string downloadPath, string steamCMDzipPath, string steamCMDunzipPath)
    {
        if (string.IsNullOrEmpty(GameManager.Default.SteamCMDPath) || string.IsNullOrEmpty(GameManager.Default.SteamCMDURL) || string.IsNullOrEmpty(downloadLink) || string.IsNullOrEmpty(downloadPath) || string.IsNullOrEmpty(steamCMDzipPath) || string.IsNullOrEmpty(steamCMDunzipPath))
        {
            ShowErrorMessage("One or more required settings are not set!");
            return false;
        }
        return true;
    }

    // Show an error message
    private static void ShowErrorMessage(string message)
    {
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    // Prüfe ob SteamCMD installiert ist
    private void SteamCMD()
    {
        // Load the SteamCMD Information
        lblSteamCMDLatUpdateInfo.Text = $"Last Update: {GameManager.Default.SteamCMDLastUpdate}";

        if (File.Exists(Path.Combine((GameManager.Default.SteamCMDPath), "steamerrorreporter.exe")))
        {
            btnSteamCMDInstall.Text = "Update SteamCMD";
            btnSteamCMDUninstall.Enabled = true;
        }
        else
        {
            btnSteamCMDInstall.Text = "Install SteamCMD";
            btnSteamCMDUninstall.Enabled = false;
        }
    }

    // Update the SteamCMD Button
    private void btnSteamCMDUpdate_Click(object sender, EventArgs e)
    {
        ValidateSettings(downloadLink, downloadPath, steamCMDzipPath, steamCMDunzipPath);

        try
        {
            // Prüfe ob der SteamCMD Ordner existiert
            if (!Directory.Exists(GameManager.Default.SteamCMDPath))
            {
                Directory.CreateDirectory(GameManager.Default.SteamCMDPath);
            }

            // Check if the Path to the SteamCMD 
            if (string.IsNullOrEmpty(GameManager.Default.SteamCMDPath))
            {
                ShowErrorMessage("The path to the SteamCMD is not set!");
                return;
            }
            // Check if the SteamCMD is already downloaded
            if (!File.Exists(steamCMDzipPath))
            {
                //Download the SteamCMD
                FormDownloader formDownloader = new FormDownloader();
                formDownloader.SetDownloadLink(downloadLink, downloadPath);
                formDownloader.Download();
                formDownloader.ShowDialog();
            }
            // Check if the SteamCMD is already extracted
            if (!System.IO.File.Exists(steamCMDunzipPath + "\\steamcmd.exe"))
            {
                // Extract the SteamCMD
                FormZIP formZIP = new FormZIP();
                formZIP.SetZIPPath(steamCMDzipPath, steamCMDunzipPath);
                formZIP.Extract();
                formZIP.ShowDialog();
            }
            // Run the SteamCMD
            FormSteamCMD formSteamCMD = new FormSteamCMD();
            formSteamCMD.StartSteamCMD("+quit");
            formSteamCMD.ShowDialog();

            // Update the SteamCMD Date
            lblSteamCMDLatUpdateInfo.Text = $"Last Update: {DateTime.Now}";
            GameManager.Default.SteamCMDLastUpdate = DateTime.Now;

            // Check if the SteamCMD is installed
            SteamCMD();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Save the path to the Servers
    private void tbServerPath_MouseClick(object sender, MouseEventArgs e)
    {
        // Open the FolderBrowserDialog Smal to select the path to the servers and save it to the settings
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.InitialDirectory = Properties.Settings.Default.ServerPath;
        folderBrowserDialog.Description = "Select the path to the servers";
        folderBrowserDialog.ShowNewFolderButton = false;

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            GameManager.Default.ServerPath = folderBrowserDialog.SelectedPath;
            GameManager.Default.Save();
            tbServerPath.Text = folderBrowserDialog.SelectedPath;
            MessageBox.Show($"Server path saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    private void btnSetServerPath_Click(object sender, EventArgs e)
    {
        tbServerPath_MouseClick(sender, null);
    }

    // Save the path to the SteamCMD
    private void tbSteamCMDPath_MouseClick(object sender, MouseEventArgs e)
    {
        // Open the FolderBrowserDialog Smal to select the path to the servers and save it to the settings
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.InitialDirectory = GameManager.Default.SteamCMDPath;
        folderBrowserDialog.Description = "Select the path to the servers";
        folderBrowserDialog.ShowNewFolderButton = false;

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            GameManager.Default.SteamCMDPath = folderBrowserDialog.SelectedPath;
            GameManager.Default.Save();
            tbSteamCMDPath.Text = folderBrowserDialog.SelectedPath;
            MessageBox.Show($"SteamCMD path saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnSetStemCMDPath_Click(object sender, EventArgs e)
    {
        tbSteamCMDPath_MouseClick(sender, null);
    }

    private void btnSteamCMDInstall_Click(object sender, EventArgs e)
    {
        // Uninstall SteamCMD
        if (File.Exists(Path.Combine((GameManager.Default.SteamCMDPath), "steamerrorreporter.exe")))
        {
            try
            {
                Directory.Delete(GameManager.Default.SteamCMDPath, true);
                MessageBox.Show("SteamCMD uninstalled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SteamCMD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("SteamCMD is not installed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
