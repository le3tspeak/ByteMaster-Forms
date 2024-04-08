namespace Game_Server_Manager.Forms;

partial class FormThemeDesigner
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
        colorDialog1 = new ColorDialog();
        btnBackGround = new FontAwesome.Sharp.IconButton();
        btnSave = new FontAwesome.Sharp.IconButton();
        SuspendLayout();
        // 
        // btnBackGround
        // 
        btnBackGround.BackColor = Color.Transparent;
        btnBackGround.BackgroundImageLayout = ImageLayout.Zoom;
        btnBackGround.FlatAppearance.BorderSize = 0;
        btnBackGround.FlatStyle = FlatStyle.Flat;
        btnBackGround.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnBackGround.ForeColor = Color.White;
        btnBackGround.IconChar = FontAwesome.Sharp.IconChar.Brush;
        btnBackGround.IconColor = Color.White;
        btnBackGround.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnBackGround.IconSize = 25;
        btnBackGround.ImageAlign = ContentAlignment.MiddleLeft;
        btnBackGround.Location = new Point(12, 12);
        btnBackGround.Name = "btnBackGround";
        btnBackGround.Size = new Size(161, 32);
        btnBackGround.TabIndex = 15;
        btnBackGround.Text = "Hintergrund";
        btnBackGround.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnBackGround.UseVisualStyleBackColor = false;
        btnBackGround.Click += btnBackGround_Click;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.Transparent;
        btnSave.BackgroundImageLayout = ImageLayout.Zoom;
        btnSave.FlatAppearance.BorderSize = 0;
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnSave.ForeColor = Color.White;
        btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
        btnSave.IconColor = Color.White;
        btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnSave.IconSize = 25;
        btnSave.ImageAlign = ContentAlignment.MiddleLeft;
        btnSave.Location = new Point(658, 295);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(112, 32);
        btnSave.TabIndex = 16;
        btnSave.Text = "Speichern";
        btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // FormThemeDesigner
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(782, 339);
        Controls.Add(btnSave);
        Controls.Add(btnBackGround);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormThemeDesigner";
        StartPosition = FormStartPosition.CenterParent;
        Text = "FormThemeDesigner";
        ResumeLayout(false);
    }

    #endregion

    private ColorDialog colorDialog1;
    private FontAwesome.Sharp.IconButton btnBackGround;
    private FontAwesome.Sharp.IconButton btnSave;
}