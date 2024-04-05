using System.Drawing.Text;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Game_Server_Manager.Forms;
using Game_Server_Manager.Properties;

namespace Game_Server_Manager;

public partial class FormByteMaster : Form
{
    // Fields
    private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;

    public FormByteMaster()
    {
        InitializeComponent();

        // Form Settings
        Text = string.Empty;
        ControlBox = false;
        DoubleBuffered = true;
        MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        leftBorderBtn = new Panel();
        leftBorderBtn.Size = new Size(7, 60);
        panelMenu.Controls.Add(leftBorderBtn);

        // Colors Settings
        BackColor = RGBColors.Default.FormBG;
        panelMenu.BackColor = RGBColors.Default.FormBG;
        panelShadow.BackColor = RGBColors.Default.FormBG;
        panelDesktop.BackColor = RGBColors.Default.FormBG;
        panelTitelBar.BackColor = RGBColors.Default.FormBG;
        btnHome.BackColor = RGBColors.Default.FormBG;

        btnValheim.BackColor = RGBColors.Default.FormBG;
        btnValheim.IconColor = RGBColors.Default.Icon;
        btnValheim.FlatAppearance.MouseDownBackColor = RGBColors.Default.MouseDown;
        btnValheim.FlatAppearance.MouseOverBackColor = RGBColors.Default.MouseHover;
        btnSettings.BackColor = RGBColors.Default.FormBG;
        btnSettings.IconColor = RGBColors.Default.Icon;
        btnSettings.FlatAppearance.MouseDownBackColor = RGBColors.Default.MouseDown;
        btnSettings.FlatAppearance.MouseOverBackColor = RGBColors.Default.MouseHover;

    }

    // Drag Form
    [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();

    [DllImport("user32.dll", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

    // Methods
    private void ActivateButton(object senderBtn, Color color)
    {
        if (senderBtn != null)
        {
            DisableButton();
            // Button
            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = RGBColors.Default.FormBG;
            currentBtn.ForeColor = RGBColors.Default.Text;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            // Left border button
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            // Icon Current Child Form
            iconCurrentChildForm.IconChar = currentBtn.IconChar;
            iconCurrentChildForm.IconColor = color;
        }
    }

    // Disable button
    private void DisableButton()
    {

        if (currentBtn != null)
        {
            currentBtn.BackColor = RGBColors.Default.FormBG;
            currentBtn.ForeColor = RGBColors.Default.Text;
            currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            currentBtn.IconColor = RGBColors.Default.Icon;
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            leftBorderBtn.Visible = false;
        }
    }

    // Open Child Form
    private void OpenChildForm(Form childForm)
    {
        if (currentChildForm != null)
        {
            // Open only form
            currentChildForm.Hide();
        }
        currentChildForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        panelDesktop.Controls.Add(childForm);
        panelDesktop.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        lblTitleChildForm.Text = childForm.Text;
    }

    // Drag Form from panelTitleBar
    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    // Button Home
    private void btnHome_Click(object sender, EventArgs e)
    {
        // Prüfe ob childForm nicht null ist und schließe es.
        if (currentChildForm != null)
            currentChildForm.Close();
        Reset();
        OpenChildForm(new Forms.FormHome());
    }

    // Reset
    private void Reset()
    {
        DisableButton();
        leftBorderBtn.Visible = false;
        iconCurrentChildForm.IconChar = IconChar.HomeUser;
        iconCurrentChildForm.IconColor = RGBColors.Default.HomeBTN;
        lblTitleChildForm.Text = "Home";
    }

    // Button Dashboard
    private void btnDashboard_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.Default.color1);
        OpenChildForm(new Forms.FormEnshrouded());
    }

    // Button Valheim
    private void btnValheim_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.Default.color2);
        OpenChildForm(new Forms.FormValheim());
    }

    // Button Settings
    private void btnSettings_Click(object sender, EventArgs e)
    {
        ActivateButton(sender, RGBColors.Default.color6);
        OpenChildForm(new Forms.FormSettings());
    }

    private void btnControlboxExit_MouseEnter(object sender, EventArgs e)
    {
        btnControlboxExit.IconColor = RGBColors.Default.ExitBTN;
    }

    private void btnControlboxExit_MouseLeave(object sender, EventArgs e)
    {
        btnControlboxExit.IconColor = Color.White;
    }

    private void btnControlboxExit_Click(object sender, EventArgs e)
    {
        FormExit formExit = new FormExit();
        formExit.ShowDialog();
    }

    private void btnControlboxMinimize_Click(object sender, EventArgs e)
    {
        // Minimize App 
        this.WindowState = FormWindowState.Minimized;
    }
}
