namespace AppUI;

partial class Menu
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
        PictureBox PictureLogo;
        Panel PanelWindowButtons;
        PictureBox PictureMainLogo;
        Label LabelMain;
        ButtonMinimize = new Button();
        ButtonMaximize = new Button();
        ButtonClose = new Button();
        PanelSideBar = new Panel();
        panel4 = new Panel();
        LabelVersion = new Label();
        PanelTitle = new Panel();
        LabelTitle = new Label();
        PaneMainContainer = new Panel();
        PictureLogo = new PictureBox();
        PanelWindowButtons = new Panel();
        PictureMainLogo = new PictureBox();
        LabelMain = new Label();
        ((System.ComponentModel.ISupportInitialize)PictureLogo).BeginInit();
        PanelWindowButtons.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PictureMainLogo).BeginInit();
        PanelSideBar.SuspendLayout();
        panel4.SuspendLayout();
        PanelTitle.SuspendLayout();
        PaneMainContainer.SuspendLayout();
        SuspendLayout();
        // 
        // PictureLogo
        // 
        PictureLogo.Anchor = AnchorStyles.None;
        PictureLogo.ErrorImage = null;
        PictureLogo.Image = Properties.Resources.book_512;
        PictureLogo.InitialImage = null;
        PictureLogo.Location = new Point(13, 18);
        PictureLogo.Name = "PictureLogo";
        PictureLogo.Size = new Size(48, 48);
        PictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
        PictureLogo.TabIndex = 5;
        PictureLogo.TabStop = false;
        // 
        // PanelWindowButtons
        // 
        PanelWindowButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        PanelWindowButtons.Controls.Add(ButtonMinimize);
        PanelWindowButtons.Controls.Add(ButtonMaximize);
        PanelWindowButtons.Controls.Add(ButtonClose);
        PanelWindowButtons.Location = new Point(237, 12);
        PanelWindowButtons.Name = "PanelWindowButtons";
        PanelWindowButtons.Size = new Size(750, 30);
        PanelWindowButtons.TabIndex = 0;
        // 
        // ButtonMinimize
        // 
        ButtonMinimize.BackColor = Color.Transparent;
        ButtonMinimize.BackgroundImage = Properties.Resources.minimize_window_512;
        ButtonMinimize.BackgroundImageLayout = ImageLayout.Zoom;
        ButtonMinimize.Cursor = Cursors.Hand;
        ButtonMinimize.DialogResult = DialogResult.OK;
        ButtonMinimize.Dock = DockStyle.Right;
        ButtonMinimize.FlatAppearance.BorderSize = 0;
        ButtonMinimize.FlatAppearance.CheckedBackColor = Color.Transparent;
        ButtonMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
        ButtonMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        ButtonMinimize.FlatStyle = FlatStyle.Flat;
        ButtonMinimize.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonMinimize.Location = new Point(645, 0);
        ButtonMinimize.Margin = new Padding(0);
        ButtonMinimize.Name = "ButtonMinimize";
        ButtonMinimize.Size = new Size(35, 30);
        ButtonMinimize.TabIndex = 7;
        ButtonMinimize.TabStop = false;
        ButtonMinimize.UseVisualStyleBackColor = false;
        ButtonMinimize.Click += ButtonMinimize_Click;
        // 
        // ButtonMaximize
        // 
        ButtonMaximize.BackColor = Color.Transparent;
        ButtonMaximize.BackgroundImage = Properties.Resources.maximize_window_512;
        ButtonMaximize.BackgroundImageLayout = ImageLayout.Zoom;
        ButtonMaximize.Cursor = Cursors.Hand;
        ButtonMaximize.DialogResult = DialogResult.OK;
        ButtonMaximize.Dock = DockStyle.Right;
        ButtonMaximize.FlatAppearance.BorderSize = 0;
        ButtonMaximize.FlatAppearance.CheckedBackColor = Color.Transparent;
        ButtonMaximize.FlatAppearance.MouseDownBackColor = Color.Transparent;
        ButtonMaximize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        ButtonMaximize.FlatStyle = FlatStyle.Flat;
        ButtonMaximize.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonMaximize.Location = new Point(680, 0);
        ButtonMaximize.Margin = new Padding(0);
        ButtonMaximize.Name = "ButtonMaximize";
        ButtonMaximize.Size = new Size(35, 30);
        ButtonMaximize.TabIndex = 6;
        ButtonMaximize.TabStop = false;
        ButtonMaximize.UseVisualStyleBackColor = false;
        ButtonMaximize.Click += ButtonMaximize_Click;
        // 
        // ButtonClose
        // 
        ButtonClose.BackColor = Color.Transparent;
        ButtonClose.BackgroundImage = Properties.Resources.close_window_512;
        ButtonClose.BackgroundImageLayout = ImageLayout.Zoom;
        ButtonClose.Cursor = Cursors.Hand;
        ButtonClose.DialogResult = DialogResult.OK;
        ButtonClose.Dock = DockStyle.Right;
        ButtonClose.FlatAppearance.BorderSize = 0;
        ButtonClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
        ButtonClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        ButtonClose.FlatStyle = FlatStyle.Flat;
        ButtonClose.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonClose.Location = new Point(715, 0);
        ButtonClose.Margin = new Padding(0);
        ButtonClose.Name = "ButtonClose";
        ButtonClose.Size = new Size(35, 30);
        ButtonClose.TabIndex = 0;
        ButtonClose.TabStop = false;
        ButtonClose.UseVisualStyleBackColor = false;
        ButtonClose.Click += ButtonClose_Click;
        // 
        // PictureMainLogo
        // 
        PictureMainLogo.Anchor = AnchorStyles.None;
        PictureMainLogo.ErrorImage = null;
        PictureMainLogo.Image = Properties.Resources.book_512;
        PictureMainLogo.InitialImage = null;
        PictureMainLogo.Location = new Point(158, 180);
        PictureMainLogo.Name = "PictureMainLogo";
        PictureMainLogo.Size = new Size(128, 128);
        PictureMainLogo.SizeMode = PictureBoxSizeMode.Zoom;
        PictureMainLogo.TabIndex = 5;
        PictureMainLogo.TabStop = false;
        // 
        // LabelMain
        // 
        LabelMain.Anchor = AnchorStyles.None;
        LabelMain.AutoSize = true;
        LabelMain.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        LabelMain.Location = new Point(298, 215);
        LabelMain.Name = "LabelMain";
        LabelMain.Size = new Size(303, 68);
        LabelMain.TabIndex = 4;
        LabelMain.Text = "Controle Monetário\r\nMensal";
        LabelMain.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanelSideBar
        // 
        PanelSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        PanelSideBar.Controls.Add(panel4);
        PanelSideBar.Location = new Point(12, 12);
        PanelSideBar.Name = "PanelSideBar";
        PanelSideBar.Size = new Size(225, 576);
        PanelSideBar.TabIndex = 1;
        // 
        // panel4
        // 
        panel4.Controls.Add(PictureLogo);
        panel4.Controls.Add(LabelVersion);
        panel4.Dock = DockStyle.Top;
        panel4.Location = new Point(0, 0);
        panel4.Name = "panel4";
        panel4.Size = new Size(225, 85);
        panel4.TabIndex = 0;
        // 
        // LabelVersion
        // 
        LabelVersion.Anchor = AnchorStyles.None;
        LabelVersion.AutoSize = true;
        LabelVersion.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
        LabelVersion.Location = new Point(76, 32);
        LabelVersion.Name = "LabelVersion";
        LabelVersion.Size = new Size(72, 19);
        LabelVersion.TabIndex = 4;
        LabelVersion.Text = "VERSION";
        LabelVersion.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanelTitle
        // 
        PanelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        PanelTitle.Controls.Add(LabelTitle);
        PanelTitle.Location = new Point(237, 42);
        PanelTitle.Name = "PanelTitle";
        PanelTitle.Size = new Size(750, 55);
        PanelTitle.TabIndex = 2;
        // 
        // LabelTitle
        // 
        LabelTitle.Dock = DockStyle.Fill;
        LabelTitle.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        LabelTitle.Location = new Point(0, 0);
        LabelTitle.Name = "LabelTitle";
        LabelTitle.Size = new Size(750, 55);
        LabelTitle.TabIndex = 3;
        LabelTitle.Text = "Início";
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PaneMainContainer
        // 
        PaneMainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        PaneMainContainer.Controls.Add(PictureMainLogo);
        PaneMainContainer.Controls.Add(LabelMain);
        PaneMainContainer.Location = new Point(237, 97);
        PaneMainContainer.Name = "PaneMainContainer";
        PaneMainContainer.Size = new Size(750, 491);
        PaneMainContainer.TabIndex = 6;
        // 
        // Menu
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(31, 30, 68);
        ClientSize = new Size(1000, 600);
        Controls.Add(PaneMainContainer);
        Controls.Add(PanelTitle);
        Controls.Add(PanelWindowButtons);
        Controls.Add(PanelSideBar);
        DoubleBuffered = true;
        Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Margin = new Padding(4);
        Name = "Menu";
        SizeGripStyle = SizeGripStyle.Show;
        StartPosition = FormStartPosition.CenterScreen;
        KeyDown += Menu_KeyDown;
        ((System.ComponentModel.ISupportInitialize)PictureLogo).EndInit();
        PanelWindowButtons.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PictureMainLogo).EndInit();
        PanelSideBar.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        PanelTitle.ResumeLayout(false);
        PaneMainContainer.ResumeLayout(false);
        PaneMainContainer.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Panel PanelSideBar;
    private Panel panel4;
    private PictureBox PictureLogo;
    private Label LabelVersion;
    private Panel PanelTitle;
    private Label LabelTitle;
    private Button ButtonClose;
    private PictureBox PictureMainLogo;
    private Label LabelMain;
    private Button ButtonMinimize;
    private Button ButtonMaximize;
    private Panel PaneMainContainer;
}