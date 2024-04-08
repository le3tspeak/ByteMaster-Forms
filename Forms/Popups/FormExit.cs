using Game_Server_Manager.Properties;

namespace Game_Server_Manager.Forms;
public partial class FormExit : Form
{
    public FormExit()
    {
        InitializeComponent();
        // Form Settings
        FormBorderStyle = FormBorderStyle.None;
        ControlBox = false;
        DoubleBuffered = true;
        StartPosition = FormStartPosition.CenterParent;
        lblTextTopBar.TextAlign = ContentAlignment.MiddleCenter;
        lblTextTopBar.Text = "Are you sure you want to exit?";
        // Colors Settigns
        BackColor = RGBColors.Default.FormBGPopup;
        btnExitYes.FlatAppearance.MouseDownBackColor = RGBColors.Default.MouseDown;
        btnExitYes.FlatAppearance.MouseOverBackColor = RGBColors.Default.FormBGPopup;
        btnExitYes.ForeColor = RGBColors.Default.Text;
        btnExitYes.IconColor = RGBColors.Default.ExitBTNConfirm;
        btnExitNo.FlatAppearance.MouseDownBackColor = RGBColors.Default.MouseDown;
        btnExitNo.FlatAppearance.MouseOverBackColor = RGBColors.Default.FormBGPopup;
        btnExitNo.ForeColor = RGBColors.Default.Text;
        btnExitNo.IconColor = RGBColors.Default.ExitBTNCancel;
        lblTextTopBar.ForeColor = RGBColors.Default.Text;
        lblTextTopBar.BackColor = RGBColors.Default.FormBGPopupTopBar;
    }

    // Exit Yes
    private void btnExitYes_Click(object sender, EventArgs e)
    {
        Program.Exit();
    }
    // Mouse Enter
    private void btnExitYes_MouseLeave(object sender, EventArgs e)
    {
        btnExitYes.IconColor = Color.White;
    }
    // Mouse Leave
    private void btnExitYes_MouseEnter(object sender, EventArgs e)
    {
        btnExitYes.IconColor = RGBColors.Default.Confirm;
    }

    // Exit No  
    private void btnExitNo_Click(object sender, EventArgs e)
    {
        Close();
    }
    // Mouse Enter
    private void btnExitNo_MouseLeave(object sender, EventArgs e)
    {
        btnExitNo.IconColor = Color.White;
    }
    // Mouse Leave
    private void btnExitNo_MouseEnter(object sender, EventArgs e)
    {
        btnExitNo.IconColor = RGBColors.Default.Cancel;
    }


}
