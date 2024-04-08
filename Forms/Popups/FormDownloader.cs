using AltoHttp;
using Game_Server_Manager.Properties;

namespace Game_Server_Manager.Forms;

public partial class FormDownloader : Form
{
    public FormDownloader()
    {
        InitializeComponent();
        BackColor = ColorTheme.Default.FormBGPopup;
    }

    // Fields
    HttpDownloader httpDownloader;
    private string URL = "";
    private string savePath = "";


    // Methode zum Empfangen des Download-Links & Speicherpfad
    public void SetDownloadLink(string url, string path)
    {
        URL = url;
        savePath = path;
    }

    // Methode zum Starten des Downloads
    public void Download()
    {
        httpDownloader = new HttpDownloader(URL, savePath);
        lblURLInfo.Text = URL;
        httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
        httpDownloader.ProgressChanged += HttpDownloader_DownloadProgressChanged;
        httpDownloader.ErrorOccured += HttpDownloader_DownloadErrorOccured;
        httpDownloader.Start();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        httpDownloader = new HttpDownloader(URL, savePath);
        httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
        httpDownloader.ProgressChanged += HttpDownloader_DownloadProgressChanged;
        httpDownloader.ErrorOccured += HttpDownloader_DownloadErrorOccured;
        httpDownloader.Start();
    }

    // Event-Handler für den Download-Fehler-Event
    private void HttpDownloader_DownloadErrorOccured(object sender, EventArgs e)
    {
        this.Invoke((MethodInvoker)delegate
               {
                   lblStatusInfo.Text = "Download failed!";
                   lblPercent.Text = "Failed";
               });
        //Play a Beep sound when the download fails
        System.Media.SystemSounds.Beep.Play();
        // Delete the file
        File.Delete(savePath);
        // Wait 5 seconds before closing the form
        Task.Delay(5000).ContinueWith(t => this.Invoke((MethodInvoker)delegate { this.Close(); }));
    }

    // Event-Handler für den Download-Abgeschlossen-Event
    private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
    {
        this.Invoke((MethodInvoker)delegate
        {
            lblStatusInfo.Text = "Download completed!";
            lblPercent.Text = "100%";
            btnResume.Visible = false;
            btnPause.Visible = false;
            btnAbort.Visible = false;
        });
        // Play a Ping sound when the download is complete
        System.Media.SystemSounds.Question.Play();

        // Wait 2 seconds before closing the form
        Task.Delay(2000).ContinueWith(t => Invoke((MethodInvoker)delegate { Close(); }));
    }

    // Event-Handler für den Download-Fortschritt-Event
    private void HttpDownloader_DownloadProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
    {
        progressBar.Value = (int)e.Progress;
        lblPercent.Text = $"{e.Progress.ToString("0.0")} %";
        lblSpeedStatus.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
        lblDownloadedMB.Text = string.Format("{0} MB/s", (httpDownloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
        lblStatusInfo.Text = "Downloading...";
    }

    // Event-Handler für den Pause-Button
    private void btnPause_Click(object sender, EventArgs e)
    {
        if (httpDownloader != null)
            httpDownloader.Pause();
        btnPause.Visible = false;
        btnResume.Visible = true;
    }

    // Event-Handler für den Resume-Button
    private void btnResume_Click(object sender, EventArgs e)
    {
        if (httpDownloader != null)
            httpDownloader.Resume();
        btnPause.Visible = true;
        btnResume.Visible = false;
    }

    // Event-Handler für den Abort-Button
    private void btnAbort_Click(object sender, EventArgs e)
    {
        if (httpDownloader != null)
            httpDownloader.Pause();
        btnPause.Visible = false;
        btnResume.Visible = false;
        lblStatusInfo.Text = "Aborting...";
        // Delete the file
        File.Delete(savePath);
        // Wait 2 seconds before closing the form
        Task.Delay(2000).ContinueWith(t => Invoke((MethodInvoker)delegate { Close(); }));
    }
}
