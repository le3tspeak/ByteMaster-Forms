using System.Diagnostics;

namespace Game_Server_Manager.Worker
{
    internal class CPUUsage
    {
        // Variable zur Verfolgung der vorherigen CPU-Zeit
        private static TimeSpan previousCpuTime = TimeSpan.Zero;

        // Methode für die Aktualisierung der CPU-Informationen
        public static string Update(string processToWatch)
        {
            // Den Prozessnamen festlegen
            var processName = processToWatch;

            // Den Prozess anhand des Namens suchen
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length > 0)
            {
                // Ersten Prozess auswählen (falls mehrere mit demselben Namen existieren)
                Process process = processes[0];

                // Aktuelle Systemzeit
                TimeSpan currentTime = DateTime.UtcNow - process.StartTime.ToUniversalTime();

                // CPU-Zeit seit dem letzten Update
                TimeSpan cpuTime = process.TotalProcessorTime - previousCpuTime;

                // CPU-Auslastung in Prozent berechnen
                var cpuUsage = (float)((100f * cpuTime.TotalMilliseconds / currentTime.TotalMilliseconds) * 100);

                // Vorherige CPU-Zeit aktualisieren
                previousCpuTime = process.TotalProcessorTime;

                // Text des CPU-Labels aktualisieren
                return $"{cpuUsage.ToString("0.00")} %";
            }
            else
            {
                // Prozess nicht gefunden
                return "0.00 %";
            }
        }
    }
}
