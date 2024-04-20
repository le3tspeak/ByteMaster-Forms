using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Server_Manager.Properties;

namespace Game_Server_Manager.Forms.Popups;
public partial class FormMessage : Form
{
    public FormMessage()
    {
        InitializeComponent();
        // Form Settings
        FormBorderStyle = FormBorderStyle.None;
        ControlBox = false;
        DoubleBuffered = true;
        StartPosition = FormStartPosition.CenterParent;
        lblTextTopBar.TextAlign = ContentAlignment.MiddleCenter;
        lblTextTopBar.Text = "Are you sure ....?";
        // Colors Settigns
        BackColor = RGBColors.Default.FormBGPopup;
        lblTextTopBar.ForeColor = RGBColors.Default.Text;
        lblTextTopBar.BackColor = RGBColors.Default.FormBGPopupTopBar;
    }
}
