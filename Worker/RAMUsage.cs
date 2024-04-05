using System.Diagnostics;

namespace Game_Server_Manager.Worker;
internal class RAMUsage
{
    public static (string, int) Update(string ProcessToWatch)
    {
        // Den Prozessnamen festlegen
        var processName = ProcessToWatch;

        // Den Prozess anhand des Namens suchen
        Process[] processes = Process.GetProcessesByName(processName);

        if (processes.Length > 0)
        {
            // RAM-Verbrauch in Megabyte (MB) konvertieren
            var ramUsage = processes[0].WorkingSet64 / (1024 * 1024); // Bytes in Megabyte umrechnen

            // Total RAM des Systems
            var totalRAM = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024); // Bytes in Megabyte umrechnen            

            // RAM-Verbrauch relativ zum Gesamt-RAM berechnen
            var ramUsagePercentage = (float)(100f * ramUsage / totalRAM);

            // Text des RAM-Labels aktualisieren
            var ramUsageInfoText = ramUsage + " MB / " + totalRAM + " MB";

            // Fortschrittsbalken für RAM-Verbrauch aktualisieren
            var progressBarValue = (int)ramUsagePercentage;

            return (ramUsageInfoText, progressBarValue);
        }
        else
        {
            // Prozess nicht gefunden
            var totalRAM = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024); // Bytes in Megabyte umrechnen
            var ramUsageInfoText = "0 MB / " + totalRAM + " MB";
            var progressBarValue = 0;

            return (ramUsageInfoText, progressBarValue);
        }
    }

    public static (string, int) UpdateShort(string ProcessToWatch)
    {
        // Den Prozessnamen festlegen
        var processName = ProcessToWatch;

        // Den Prozess anhand des Namens suchen
        Process[] processes = Process.GetProcessesByName(processName);

        if (processes.Length > 0)
        {
            // RAM-Verbrauch in Megabyte (MB) konvertieren
            var ramUsage = processes[0].WorkingSet64 / (1024 * 1024); // Bytes in Megabyte umrechnen

            // Total RAM des Systems
            var totalRAM = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024); // Bytes in Megabyte umrechnen            

            // RAM-Verbrauch relativ zum Gesamt-RAM berechnen
            var ramUsagePercentage = (float)(100f * ramUsage / totalRAM);

            // Text des RAM-Labels aktualisieren
            var ramUsageInfoText = ramUsage + " MB";

            // Fortschrittsbalken für RAM-Verbrauch aktualisieren
            var progressBarValue = (int)ramUsagePercentage;

            return (ramUsageInfoText, progressBarValue);
        }
        else
        {
            var ramUsageInfoText = "0 MB";
            var progressBarValue = 0;

            return (ramUsageInfoText, progressBarValue);
        }
    }




}



