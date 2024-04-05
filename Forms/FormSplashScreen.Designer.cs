namespace Game_Server_Manager.Forms;

partial class FormSplashScreen
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
        components = new System.ComponentModel.Container();
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplashScreen));
        pictureBox1 = new PictureBox();
        timer1 = new System.Windows.Forms.Timer(components);
        panel1 = new Panel();
        lblCreatetBy = new Label();
        lblVersion = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.Transparent;
        pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
        pictureBox1.Image = Properties.Resources.SplashScreen;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(800, 300);
        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 50;
        timer1.Tick += timer1_Tick;
        // 
        // panel1
        // 
        panel1.BackColor = Color.Cyan;
        panel1.BackgroundImageLayout = ImageLayout.None;
        panel1.ForeColor = Color.Transparent;
        panel1.ImeMode = ImeMode.NoControl;
        panel1.Location = new Point(1, 298);
        panel1.Name = "panel1";
        panel1.Size = new Size(5, 3);
        panel1.TabIndex = 1;
        // 
        // lblCreatetBy
        // 
        lblCreatetBy.AutoSize = true;
        lblCreatetBy.BackColor = Color.Transparent;
        lblCreatetBy.Font = new Font("Cascadia Code SemiBold", 10F, FontStyle.Bold);
        lblCreatetBy.ForeColor = Color.White;
        lblCreatetBy.Location = new Point(12, 271);
        lblCreatetBy.Name = "lblCreatetBy";
        lblCreatetBy.Size = new Size(168, 18);
        lblCreatetBy.TabIndex = 0;
        lblCreatetBy.Text = "Createt by Le3tspeak";
        // 
        // lblVersion
        // 
        lblVersion.AutoSize = true;
        lblVersion.BackColor = Color.Transparent;
        lblVersion.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold);
        lblVersion.ForeColor = Color.White;
        lblVersion.Location = new Point(717, 276);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(71, 13);
        lblVersion.TabIndex = 2;
        lblVersion.Text = "Version 0.1";
        // 
        // FormSplashScreen
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        BackgroundImageLayout = ImageLayout.Zoom;
        ClientSize = new Size(800, 300);
        Controls.Add(lblVersion);
        Controls.Add(lblCreatetBy);
        Controls.Add(panel1);
        Controls.Add(pictureBox1);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "FormSplashScreen";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FormSplashScreen";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private System.Windows.Forms.Timer timer1;
    private Panel panel1;
    private Label lblCreatetBy;
    private Label lblVersion;
}