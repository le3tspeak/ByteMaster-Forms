using Game_Server_Manager.Properties;

namespace Game_Server_Manager.Forms;
public partial class FormSplashScreen : Form
{
    // Components
    public FormSplashScreen()
    {
        InitializeComponent();
        // Set the Form to the center of the screen
        StartPosition = FormStartPosition.CenterScreen;
        // Set Timer for Splash Screen Animation
        timer1.Enabled = true;
        timer1.Interval = 1;
        // Set the Size of the Form
        Size = new Size(800, 300);
        // Set Size of the PictureBox
        pictureBox1.Size = new Size(800, 297);
        pictureBox1.Location = new Point(0, 0);
        // Set Panel 1 to the bottom of the Form and set the Size
        panel1.Location = new Point(0, 297);
        panel1.BackColor = RGBColors.Default.Loading;
        // Load Settings Version
        string version = Properties.Settings.Default.Version;
        lblVersion.Text = $"Version: {version}";
    }

    // State Game Server Manager
    private void GSMStart(object sender, EventArgs e)
    {
        Close();
    }

    // Timer for Splash Screen Animation
    private void timer1_Tick(object sender, EventArgs e)
    {
        panel1.Width += 5;
        timer1.Start();
        if (panel1.Width >= Size.Width)
        {
            timer1.Stop();
            GSMStart(sender, e);
        }
    }
}
