using System.Drawing.Text;
using System.Management;

namespace Game_Server_Manager;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();

        // Erstelle das Splash-Screen-Objekt
        using var splashForm = new Game_Server_Manager.Forms.FormSplashScreen();
        // Load the Splash Screen
        splashForm.ShowDialog();

        // Load the Main Form
        Application.Run(new FormByteMaster());
    }

    // Exit the application
    public static void Exit()
    {
        Environment.Exit(0);
    }
}