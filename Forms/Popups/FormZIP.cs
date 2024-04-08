using System.IO.Compression;

namespace Game_Server_Manager.Forms;

public partial class FormZIP : Form
{
    public FormZIP()
    {
        InitializeComponent();
        //Form
        ControlBox = false;
        DoubleBuffered = true;
        BackColor = Properties.ColorTheme.Default.FormBGPopup;
    }

    // Fields
    string zipFile = "";
    string savePath = "";

    // Methode zum Empfangen des ZIP-Archivpfads & Speicherpfad
    public void SetZIPPath(string zippath, string extraxtpath)
    {
        zipFile = zippath;
        savePath = extraxtpath;
    }

    // Methode zum Entpacken des ZIP-Archivs
    public void Extract()
    {

        lblStatusInfo.Text = "Entpacke ZIP-Archiv...";
        lblZIPPathInfo.Text = $"{zipFile}";

        // Fortschrittsanzeige        
        var extractPath = savePath;
        var extractedFiles = 0;
        var totalFiles = 0;

        using (var archive = ZipFile.OpenRead(zipFile))
        {
            totalFiles = archive.Entries.Count;

            foreach (var entry in archive.Entries)
            {
                var destinationPath = Path.Combine(extractPath, entry.FullName);
                var directoryPath = Path.GetDirectoryName(destinationPath);

                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);

                entry.ExtractToFile(destinationPath, true);

                extractedFiles++;

                // Fortschrittsanzeige aktualisieren
                lblFilesInfo.Text = $"Fortschritt: {extractedFiles}/{totalFiles} Dateien extrahiert";
                progressBar.Value = (int)((double)extractedFiles / totalFiles * 100);
                lblPercent.Text = $"{progressBar.Value}%";
            }
        }

        lblStatusInfo.Text = "Entpacken abgeschlossen.";

        // Wait 2 seconds before closing the form
        Task.Delay(2000).ContinueWith(t => this.Invoke((MethodInvoker)delegate { this.Close(); }));
    }
}


