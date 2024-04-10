using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Server_Manager.Worker;

internal class ProcessManager
{
    // Check Process Running 
    public static bool Check(string processName)
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

    // Öffne Website
    public static void OpenWebsite(string URL)
    {        
        var url = URL;
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url}",
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Fehler beim Öffnen der URL: {ex.Message}");
        }
    }
}
