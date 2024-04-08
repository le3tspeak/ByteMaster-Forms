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

namespace Game_Server_Manager.Forms;

public partial class FormThemeDesigner : Form
{
    public FormThemeDesigner()
    {
        InitializeComponent();
        StartUp();
    }

    // Startroutine
    private void StartUp()
    {
        // Form Einstellungen
        LoadFormSettings();
        // Farb Einstellungen
        LoadColorSettings();
    }

    // Laden der Form Einstellungen
    private void LoadFormSettings()
    {
        ControlBox = false;
        DoubleBuffered = true;
    }

    private void LoadColorSettings()
    {
        // Form
        BackColor = ColorTheme.Default.FormBG;
        // Buttons

        // Textboxen

    }

    private void btnBackGround_Click(object sender, EventArgs e)
    {
        // Open Color Dialog
        ColorDialog colorDialog = new ColorDialog();
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {

            // Set the BackColor of the Form
            this.BackColor = colorDialog.Color;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Close();
    }
}
