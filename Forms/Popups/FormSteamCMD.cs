using System.Diagnostics;
using GameManager = Game_Server_Manager.Properties.Settings;

namespace Game_Server_Manager.Forms;

public partial class FormSteamCMD : Form
{
    private Process process;

    public FormSteamCMD()
    {
        InitializeComponent();
        //Form
        ControlBox = false;
        DoubleBuffered = true;
        // Text
        Text = "SteamCMD";
        lblSteamCMDInformation.Text = "Steam CMD is running but possible not updating de Console...";
        lblSteamCMDPath.Text = "SteamCMD Path:";
        lblSteamArguments.Text = "SteamCMD Arguments:";
        //Colors
        BackColor = Properties.ColorTheme.Default.FormBGPopup;
        tbConsole.BackColor = Properties.ColorTheme.Default.FormBG;
        tbConsole.ForeColor = Properties.ColorTheme.Default.TextBoxText;
        lblSteamCMDPathInfo.ForeColor = Properties.ColorTheme.Default.Text;
        lblSteamArgumentsInfo.ForeColor = Properties.ColorTheme.Default.Text;
    }

    private readonly string SteamCMDPath = Path.Combine(GameManager.Default.SteamCMDPath, "steamcmd.exe");
    private readonly string LogFilePath = Path.Combine(GameManager.Default.SteamCMDPath, "logs", "bootstrap_log.txt");

    public async void StartSteamCMD(string arguments)
    {
        try
        {
            await StartCMDProcess(arguments);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error starting SteamCMD: " + ex.Message);
        }
    }

    private async Task StartCMDProcess(string arguments)
    {
        var exePath = SteamCMDPath;
        lblSteamCMDPathInfo.Text = $"{exePath}";
        lblSteamArgumentsInfo.Text = $"{arguments}";

        if (!File.Exists(exePath))
        {
            MessageBox.Show("SteamCMD executable not found at the specified path.");
            return;
        }

        // Start the CMD process
        process = new Process();
        process.StartInfo.FileName = exePath;
        process.StartInfo.Arguments = arguments;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true; // Redirect standard error stream
        process.StartInfo.CreateNoWindow = true; // Hide the CMD window

        // Handle the Exited event to know when the process exits
        process.EnableRaisingEvents = true;
        process.Exited += SteamCMDExited;

        // Start the process asynchronously
        process.Start();

        // Read the output asynchronously
        await Task.Run(() =>
        {
            // Read standard output and standard error streams asynchronously
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            // Combine standard output and standard error
            string combinedOutput = output + error;

            // Update the output
            UpdateOutput(combinedOutput);
        });
    }

    private void SteamCMDExited(object sender, EventArgs e)
    {
        // Überprüfen, ob die TextBox leer ist
        if (tbConsole.InvokeRequired)
        {
            // Wenn ja, den Zugriff auf das UI-Element im UI-Thread planen
            tbConsole.Invoke(new Action<object, EventArgs>(SteamCMDExited), sender, e);
            return;
        }
        // Schreibe eine andere überprüfung für die TextBox
        if (tbConsole.Text.Trim() == "")
        {

            //TextBox ist leer, also lesen wir das Log - File
            if (File.Exists(LogFilePath))
            {
                string logContent = File.ReadAllText(LogFilePath);
                tbConsole.Text = logContent;

                // Das Formular nach 5 Sekunden automatisch schließen
                Task.Delay(5000).ContinueWith(_ =>
                                   {
                                       if (!IsDisposed)
                                       {
                                           Invoke(new Action(() => Close()));
                                       }
                                   });
            }
            else
            {
                MessageBox.Show("Log file not found: " + LogFilePath);
                Close();
            }
        }
        else
        {
            // TextBox ist nicht leer, also schließen wir das Formular direkt
            Close();
        }
    }

    private void UpdateOutput(string output)
    {
        // Check if the call needs to be made on the UI thread
        if (InvokeRequired)
        {
            Invoke(new Action<string>(UpdateOutput), output);
            return;
        }

        // Update the text box with CMD output
        tbConsole.AppendText(output);
    }

    private void FormSteamCMD_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Ensure that the CMD process is stopped when the form is closing
        StopCMDProcess();
    }

    private void StopCMDProcess()
    {
        // Check if the process exists and is active
        if (process != null && !process.HasExited)
        {
            // Terminate the process
            process.Kill();
        }
    }
}