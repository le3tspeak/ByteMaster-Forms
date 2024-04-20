namespace Game_Server_Manager.Forms.Popups;

partial class FormMessage
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panelTopBar = new Panel();
        lblTextTopBar = new Label();
        panelTopBar.SuspendLayout();
        SuspendLayout();
        // 
        // panelTopBar
        // 
        panelTopBar.BackColor = Color.DimGray;
        panelTopBar.Controls.Add(lblTextTopBar);
        panelTopBar.Dock = DockStyle.Top;
        panelTopBar.Location = new Point(0, 0);
        panelTopBar.Name = "panelTopBar";
        panelTopBar.Size = new Size(440, 30);
        panelTopBar.TabIndex = 0;
        // 
        // lblTextTopBar
        // 
        lblTextTopBar.Dock = DockStyle.Fill;
        lblTextTopBar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblTextTopBar.Location = new Point(0, 0);
        lblTextTopBar.Name = "lblTextTopBar";
        lblTextTopBar.Size = new Size(440, 30);
        lblTextTopBar.TabIndex = 0;
        lblTextTopBar.Text = "Message Box Top Bar";
        lblTextTopBar.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FormMessage
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(440, 184);
        Controls.Add(panelTopBar);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormMessage";
        Text = "FormMessage";
        panelTopBar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelTopBar;
    private Label lblTextTopBar;
}