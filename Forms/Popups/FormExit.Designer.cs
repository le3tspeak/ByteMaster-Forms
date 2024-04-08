namespace Game_Server_Manager.Forms;

partial class FormExit
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
        btnExitYes = new FontAwesome.Sharp.IconButton();
        btnExitNo = new FontAwesome.Sharp.IconButton();
        panelTopBar = new Panel();
        lblTextTopBar = new Label();
        panelTopBar.SuspendLayout();
        SuspendLayout();
        // 
        // btnExitYes
        // 
        btnExitYes.AutoSize = true;
        btnExitYes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnExitYes.Cursor = Cursors.Hand;
        btnExitYes.FlatAppearance.BorderSize = 0;
        btnExitYes.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 0, 22);
        btnExitYes.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 5, 21);
        btnExitYes.FlatStyle = FlatStyle.Flat;
        btnExitYes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnExitYes.ForeColor = Color.FromArgb(255, 255, 255);
        btnExitYes.IconChar = FontAwesome.Sharp.IconChar.Check;
        btnExitYes.IconColor = Color.FromArgb(255, 255, 255);
        btnExitYes.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnExitYes.Location = new Point(126, 36);
        btnExitYes.Name = "btnExitYes";
        btnExitYes.Size = new Size(54, 75);
        btnExitYes.TabIndex = 0;
        btnExitYes.Text = "Yes";
        btnExitYes.TextAlign = ContentAlignment.BottomCenter;
        btnExitYes.TextImageRelation = TextImageRelation.ImageAboveText;
        btnExitYes.UseVisualStyleBackColor = true;
        btnExitYes.Click += btnExitYes_Click;
        btnExitYes.MouseEnter += btnExitYes_MouseEnter;
        btnExitYes.MouseLeave += btnExitYes_MouseLeave;
        // 
        // btnExitNo
        // 
        btnExitNo.AutoSize = true;
        btnExitNo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        btnExitNo.Cursor = Cursors.Hand;
        btnExitNo.FlatAppearance.BorderSize = 0;
        btnExitNo.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 0, 22);
        btnExitNo.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 5, 21);
        btnExitNo.FlatStyle = FlatStyle.Flat;
        btnExitNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        btnExitNo.ForeColor = Color.FromArgb(255, 255, 255);
        btnExitNo.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
        btnExitNo.IconColor = Color.FromArgb(255, 255, 255);
        btnExitNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnExitNo.Location = new Point(26, 36);
        btnExitNo.Name = "btnExitNo";
        btnExitNo.Size = new Size(54, 75);
        btnExitNo.TabIndex = 1;
        btnExitNo.Text = "No";
        btnExitNo.TextAlign = ContentAlignment.BottomCenter;
        btnExitNo.TextImageRelation = TextImageRelation.ImageAboveText;
        btnExitNo.UseVisualStyleBackColor = true;
        btnExitNo.Click += btnExitNo_Click;
        btnExitNo.MouseEnter += btnExitNo_MouseEnter;
        btnExitNo.MouseLeave += btnExitNo_MouseLeave;
        // 
        // panelTopBar
        // 
        panelTopBar.Controls.Add(lblTextTopBar);
        panelTopBar.Dock = DockStyle.Top;
        panelTopBar.Location = new Point(0, 0);
        panelTopBar.Name = "panelTopBar";
        panelTopBar.Size = new Size(206, 30);
        panelTopBar.TabIndex = 2;
        // 
        // lblTextTopBar
        // 
        lblTextTopBar.BackColor = Color.Gray;
        lblTextTopBar.Dock = DockStyle.Fill;
        lblTextTopBar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblTextTopBar.ForeColor = Color.White;
        lblTextTopBar.Location = new Point(0, 0);
        lblTextTopBar.Name = "lblTextTopBar";
        lblTextTopBar.Size = new Size(206, 30);
        lblTextTopBar.TabIndex = 0;
        lblTextTopBar.Text = "Are you sure you want to exit?";
        lblTextTopBar.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FormExit
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(206, 120);
        ControlBox = false;
        Controls.Add(panelTopBar);
        Controls.Add(btnExitNo);
        Controls.Add(btnExitYes);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FormExit";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Are you sure you want to exit?";
        panelTopBar.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private FontAwesome.Sharp.IconButton btnExitYes;
    private FontAwesome.Sharp.IconButton btnExitNo;
    private Panel panelTopBar;
    private Label lblTextTopBar;
}