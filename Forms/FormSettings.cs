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

namespace Game_Server_Manager.Forms;
public partial class FormSettings : Form
{
    public FormSettings()
    {
        InitializeComponent();
        // Load the settings
        tbServerPath.Text = Properties.Settings.Default.ServerPath;
        tbSteamCMDPath.Text = Properties.Settings.Default.SteamCMDPath;
        lblVersion.Text = $"Version: {Properties.Settings.Default.Version}";

        //Form
        ControlBox = false;
        DoubleBuffered = true;
        //Colors
        BackColor = Properties.ColorTheme.Default.FormBG;
        btnSteamCMDUpdate.IconColor = Properties.ColorTheme.Default.IconSteam;
        btnSteamCMDUpdate.ForeColor = Properties.ColorTheme.Default.Text;
        btnSteamCMDUpdate.FlatAppearance.MouseDownBackColor = Properties.ColorTheme.Default.MouseDown;
        btnSteamCMDUpdate.FlatAppearance.MouseOverBackColor = Properties.ColorTheme.Default.MouseHover;
        tbServerPath.BackColor = Properties.ColorTheme.Default.TextBoxBG;
        tbServerPath.ForeColor = Properties.ColorTheme.Default.TextBoxText;
        tbSteamCMDPath.BackColor = Properties.ColorTheme.Default.TextBoxBG;
        tbSteamCMDPath.ForeColor = Properties.ColorTheme.Default.TextBoxText;
    }

    // Variables
    private readonly string downloadLink = Properties.Settings.Default.SteamCMDURL;
    private readonly string downloadPath = Path.Combine(Properties.Settings.Default.SteamCMDPath, "steamcmd.zip");
    private readonly string steamCMDzipPath = Path.Combine(Properties.Settings.Default.SteamCMDPath, "steamcmd.zip");
    private readonly string steamCMDunzipPath = Properties.Settings.Default.SteamCMDPath;

    // Test the Variables and show an error message if one or more are empty
    public static bool ValidateSettings(string downloadLink, string downloadPath, string steamCMDzipPath, string steamCMDunzipPath)
    {
        if (string.IsNullOrEmpty(Properties.Settings.Default.SteamCMDPath) || string.IsNullOrEmpty(Properties.Settings.Default.SteamCMDURL) || string.IsNullOrEmpty(downloadLink) || string.IsNullOrEmpty(downloadPath) || string.IsNullOrEmpty(steamCMDzipPath) || string.IsNullOrEmpty(steamCMDunzipPath))
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

    // Update the SteamCMD Button
    private void btnSteamCMDUpdate_Click(object sender, EventArgs e)
    {
        ValidateSettings(downloadLink, downloadPath, steamCMDzipPath, steamCMDunzipPath);

        try
        {
            // Check if the Path to the SteamCMD 
            if (string.IsNullOrEmpty(Properties.Settings.Default.SteamCMDPath))
            {
                ShowErrorMessage("The path to the SteamCMD is not set!");
                return;
            }
            // Check if the SteamCMD is already downloaded
            if (!System.IO.File.Exists(steamCMDzipPath))
            {
                //Download the SteamCMD
                Game_Server_Manager.Forms.FormDownloader formDownloader = new Game_Server_Manager.Forms.FormDownloader();
                formDownloader.SetDownloadLink(downloadLink, downloadPath);
                formDownloader.Download();
                formDownloader.ShowDialog();
            }
            // Check if the SteamCMD is already extracted
            if (!System.IO.File.Exists(steamCMDunzipPath + "\\steamcmd.exe"))
            {
                // Extract the SteamCMD
                Game_Server_Manager.Forms.FormZIP formZIP = new Game_Server_Manager.Forms.FormZIP();
                formZIP.SetZIPPath(steamCMDzipPath, steamCMDunzipPath);
                formZIP.Extract();
                formZIP.ShowDialog();
            }
            // Run the SteamCMD
            Game_Server_Manager.Forms.FormSteamCMD formSteamCMD = new Game_Server_Manager.Forms.FormSteamCMD();
            formSteamCMD.StartSteamCMD("+quit");
            formSteamCMD.ShowDialog();
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
            Properties.Settings.Default.ServerPath = folderBrowserDialog.SelectedPath;
            Properties.Settings.Default.Save();
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
        folderBrowserDialog.InitialDirectory = Properties.Settings.Default.SteamCMDPath;
        folderBrowserDialog.Description = "Select the path to the servers";
        folderBrowserDialog.ShowNewFolderButton = false;

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            Properties.Settings.Default.SteamCMDPath = folderBrowserDialog.SelectedPath;
            Properties.Settings.Default.Save();
            tbSteamCMDPath.Text = folderBrowserDialog.SelectedPath;
            MessageBox.Show($"SteamCMD path saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnSetStemCMDPath_Click(object sender, EventArgs e)
    {
        tbSteamCMDPath_MouseClick(sender, null);
    }
}
