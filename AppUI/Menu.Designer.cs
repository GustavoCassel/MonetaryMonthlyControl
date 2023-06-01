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
        PictureBox PictureMainLogo;
        Label LabelMain;
        Panel panel1;
        Panel panel2;
        Panel panel3;
        Panel panel4;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        PanelWindowButtons = new Panel();
        ButtonMinimize = new Button();
        ButtonMaximize = new Button();
        ButtonClose = new Button();
        PanelSideBar = new Panel();
        PanelLogo = new Panel();
        LabelVersion = new Label();
        PanelTitle = new Panel();
        LabelTitle = new Label();
        PanelMainContainer = new Panel();
        MainTableLayoutPanel = new TableLayoutPanel();
        PictureLogo = new PictureBox();
        PictureMainLogo = new PictureBox();
        LabelMain = new Label();
        panel1 = new Panel();
        panel2 = new Panel();
        panel3 = new Panel();
        panel4 = new Panel();
        ((System.ComponentModel.ISupportInitialize)PictureLogo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PictureMainLogo).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        PanelWindowButtons.SuspendLayout();
        PanelSideBar.SuspendLayout();
        PanelLogo.SuspendLayout();
        PanelTitle.SuspendLayout();
        PanelMainContainer.SuspendLayout();
        MainTableLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // PictureLogo
        // 
        PictureLogo.Anchor = AnchorStyles.None;
        PictureLogo.ErrorImage = null;
        PictureLogo.Image = Properties.Resources.book_512;
        PictureLogo.InitialImage = null;
        PictureLogo.Location = new Point(11, 6);
        PictureLogo.Name = "PictureLogo";
        PictureLogo.Size = new Size(48, 48);
        PictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
        PictureLogo.TabIndex = 5;
        PictureLogo.TabStop = false;
        PictureLogo.Click += ReturnToHomeScreen;
        // 
        // PictureMainLogo
        // 
        PictureMainLogo.Anchor = AnchorStyles.None;
        PictureMainLogo.ErrorImage = null;
        PictureMainLogo.Image = Properties.Resources.book_512;
        PictureMainLogo.InitialImage = null;
        PictureMainLogo.Location = new Point(168, 188);
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
        LabelMain.Location = new Point(308, 223);
        LabelMain.Name = "LabelMain";
        LabelMain.Size = new Size(303, 68);
        LabelMain.TabIndex = 4;
        LabelMain.Text = "Controle Monetário\r\nMensal";
        LabelMain.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel1
        // 
        panel1.Controls.Add(button1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Size = new Size(221, 60);
        panel1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Cursor = Cursors.Hand;
        button1.Dock = DockStyle.Fill;
        button1.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(0, 0);
        button1.Margin = new Padding(1);
        button1.Name = "button1";
        button1.Size = new Size(221, 60);
        button1.TabIndex = 0;
        button1.Text = "Visualizar Situação";
        button1.UseVisualStyleBackColor = true;
        // 
        // panel2
        // 
        panel2.Controls.Add(button2);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 60);
        panel2.Margin = new Padding(0);
        panel2.Name = "panel2";
        panel2.Size = new Size(221, 60);
        panel2.TabIndex = 1;
        // 
        // button2
        // 
        button2.Cursor = Cursors.Hand;
        button2.Dock = DockStyle.Fill;
        button2.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        button2.Location = new Point(0, 0);
        button2.Margin = new Padding(1);
        button2.Name = "button2";
        button2.Size = new Size(221, 60);
        button2.TabIndex = 0;
        button2.Text = "Exportar Dados";
        button2.UseVisualStyleBackColor = true;
        // 
        // panel3
        // 
        panel3.Controls.Add(button3);
        panel3.Dock = DockStyle.Top;
        panel3.Location = new Point(0, 120);
        panel3.Margin = new Padding(0);
        panel3.Name = "panel3";
        panel3.Size = new Size(221, 60);
        panel3.TabIndex = 2;
        // 
        // button3
        // 
        button3.Cursor = Cursors.Hand;
        button3.Dock = DockStyle.Fill;
        button3.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        button3.FlatAppearance.BorderSize = 0;
        button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        button3.FlatStyle = FlatStyle.Flat;
        button3.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        button3.Location = new Point(0, 0);
        button3.Margin = new Padding(1);
        button3.Name = "button3";
        button3.Size = new Size(221, 60);
        button3.TabIndex = 0;
        button3.Text = "Adicionar";
        button3.UseVisualStyleBackColor = true;
        // 
        // panel4
        // 
        panel4.Controls.Add(button4);
        panel4.Dock = DockStyle.Bottom;
        panel4.Location = new Point(0, 446);
        panel4.Margin = new Padding(0);
        panel4.Name = "panel4";
        panel4.Size = new Size(221, 60);
        panel4.TabIndex = 3;
        // 
        // button4
        // 
        button4.Cursor = Cursors.Hand;
        button4.Dock = DockStyle.Fill;
        button4.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        button4.FlatAppearance.BorderSize = 0;
        button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        button4.FlatStyle = FlatStyle.Flat;
        button4.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        button4.Location = new Point(0, 0);
        button4.Margin = new Padding(1);
        button4.Name = "button4";
        button4.Size = new Size(221, 60);
        button4.TabIndex = 0;
        button4.Text = "Importar / Exportar Dados - CSV";
        button4.UseVisualStyleBackColor = true;
        // 
        // PanelWindowButtons
        // 
        PanelWindowButtons.BackColor = Color.FromArgb(20, 66, 114);
        PanelWindowButtons.Controls.Add(ButtonMinimize);
        PanelWindowButtons.Controls.Add(ButtonMaximize);
        PanelWindowButtons.Controls.Add(ButtonClose);
        PanelWindowButtons.Dock = DockStyle.Top;
        PanelWindowButtons.Location = new Point(0, 0);
        PanelWindowButtons.Name = "PanelWindowButtons";
        PanelWindowButtons.Size = new Size(1000, 25);
        PanelWindowButtons.TabIndex = 0;
        // 
        // ButtonMinimize
        // 
        ButtonMinimize.BackColor = Color.Transparent;
        ButtonMinimize.BackgroundImage = Properties.Resources.minimize_window_512;
        ButtonMinimize.BackgroundImageLayout = ImageLayout.Zoom;
        ButtonMinimize.Cursor = Cursors.Hand;
        ButtonMinimize.Dock = DockStyle.Right;
        ButtonMinimize.FlatAppearance.BorderSize = 0;
        ButtonMinimize.FlatAppearance.CheckedBackColor = Color.Transparent;
        ButtonMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
        ButtonMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        ButtonMinimize.FlatStyle = FlatStyle.Flat;
        ButtonMinimize.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonMinimize.Location = new Point(910, 0);
        ButtonMinimize.Margin = new Padding(0);
        ButtonMinimize.Name = "ButtonMinimize";
        ButtonMinimize.Size = new Size(30, 25);
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
        ButtonMaximize.Dock = DockStyle.Right;
        ButtonMaximize.FlatAppearance.BorderSize = 0;
        ButtonMaximize.FlatAppearance.CheckedBackColor = Color.Transparent;
        ButtonMaximize.FlatAppearance.MouseDownBackColor = Color.Transparent;
        ButtonMaximize.FlatAppearance.MouseOverBackColor = Color.Transparent;
        ButtonMaximize.FlatStyle = FlatStyle.Flat;
        ButtonMaximize.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonMaximize.Location = new Point(940, 0);
        ButtonMaximize.Margin = new Padding(0);
        ButtonMaximize.Name = "ButtonMaximize";
        ButtonMaximize.Size = new Size(30, 25);
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
        ButtonClose.Dock = DockStyle.Right;
        ButtonClose.FlatAppearance.BorderSize = 0;
        ButtonClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
        ButtonClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        ButtonClose.FlatStyle = FlatStyle.Flat;
        ButtonClose.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonClose.Location = new Point(970, 0);
        ButtonClose.Margin = new Padding(0);
        ButtonClose.Name = "ButtonClose";
        ButtonClose.Size = new Size(30, 25);
        ButtonClose.TabIndex = 0;
        ButtonClose.TabStop = false;
        ButtonClose.UseVisualStyleBackColor = false;
        ButtonClose.Click += ButtonClose_Click;
        // 
        // PanelSideBar
        // 
        PanelSideBar.BackColor = Color.Transparent;
        PanelSideBar.Controls.Add(panel4);
        PanelSideBar.Controls.Add(panel3);
        PanelSideBar.Controls.Add(panel2);
        PanelSideBar.Controls.Add(panel1);
        PanelSideBar.Dock = DockStyle.Fill;
        PanelSideBar.Location = new Point(2, 67);
        PanelSideBar.Margin = new Padding(2);
        PanelSideBar.Name = "PanelSideBar";
        PanelSideBar.Size = new Size(221, 506);
        PanelSideBar.TabIndex = 1;
        // 
        // PanelLogo
        // 
        PanelLogo.BackColor = Color.Transparent;
        PanelLogo.Controls.Add(LabelVersion);
        PanelLogo.Controls.Add(PictureLogo);
        PanelLogo.Cursor = Cursors.Hand;
        PanelLogo.Dock = DockStyle.Fill;
        PanelLogo.Location = new Point(2, 2);
        PanelLogo.Margin = new Padding(2);
        PanelLogo.Name = "PanelLogo";
        PanelLogo.Size = new Size(221, 61);
        PanelLogo.TabIndex = 0;
        PanelLogo.Click += ReturnToHomeScreen;
        // 
        // LabelVersion
        // 
        LabelVersion.Anchor = AnchorStyles.None;
        LabelVersion.AutoSize = true;
        LabelVersion.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
        LabelVersion.Location = new Point(74, 20);
        LabelVersion.Name = "LabelVersion";
        LabelVersion.Size = new Size(72, 19);
        LabelVersion.TabIndex = 4;
        LabelVersion.Text = "VERSION";
        LabelVersion.TextAlign = ContentAlignment.MiddleCenter;
        LabelVersion.Click += ReturnToHomeScreen;
        // 
        // PanelTitle
        // 
        PanelTitle.BackColor = Color.Transparent;
        PanelTitle.Controls.Add(LabelTitle);
        PanelTitle.Dock = DockStyle.Fill;
        PanelTitle.Location = new Point(227, 2);
        PanelTitle.Margin = new Padding(2);
        PanelTitle.Name = "PanelTitle";
        PanelTitle.Size = new Size(771, 61);
        PanelTitle.TabIndex = 2;
        // 
        // LabelTitle
        // 
        LabelTitle.Dock = DockStyle.Fill;
        LabelTitle.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        LabelTitle.Location = new Point(0, 0);
        LabelTitle.Name = "LabelTitle";
        LabelTitle.Size = new Size(771, 61);
        LabelTitle.TabIndex = 3;
        LabelTitle.Text = "Início";
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanelMainContainer
        // 
        PanelMainContainer.BackColor = Color.Transparent;
        PanelMainContainer.Controls.Add(PictureMainLogo);
        PanelMainContainer.Controls.Add(LabelMain);
        PanelMainContainer.Dock = DockStyle.Fill;
        PanelMainContainer.Location = new Point(227, 67);
        PanelMainContainer.Margin = new Padding(2);
        PanelMainContainer.Name = "PanelMainContainer";
        PanelMainContainer.Size = new Size(771, 506);
        PanelMainContainer.TabIndex = 6;
        // 
        // MainTableLayoutPanel
        // 
        MainTableLayoutPanel.ColumnCount = 2;
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        MainTableLayoutPanel.Controls.Add(PanelLogo, 0, 0);
        MainTableLayoutPanel.Controls.Add(PanelTitle, 1, 0);
        MainTableLayoutPanel.Controls.Add(PanelMainContainer, 1, 1);
        MainTableLayoutPanel.Controls.Add(PanelSideBar, 0, 1);
        MainTableLayoutPanel.Dock = DockStyle.Fill;
        MainTableLayoutPanel.Location = new Point(0, 25);
        MainTableLayoutPanel.Margin = new Padding(2);
        MainTableLayoutPanel.Name = "MainTableLayoutPanel";
        MainTableLayoutPanel.RowCount = 2;
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        MainTableLayoutPanel.Size = new Size(1000, 575);
        MainTableLayoutPanel.TabIndex = 7;
        // 
        // Menu
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(10, 38, 71);
        ClientSize = new Size(1000, 600);
        Controls.Add(MainTableLayoutPanel);
        Controls.Add(PanelWindowButtons);
        DoubleBuffered = true;
        Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        Margin = new Padding(4);
        MinimumSize = new Size(1000, 600);
        Name = "Menu";
        SizeGripStyle = SizeGripStyle.Show;
        StartPosition = FormStartPosition.CenterScreen;
        KeyDown += Menu_KeyDown;
        ((System.ComponentModel.ISupportInitialize)PictureLogo).EndInit();
        ((System.ComponentModel.ISupportInitialize)PictureMainLogo).EndInit();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
        PanelWindowButtons.ResumeLayout(false);
        PanelSideBar.ResumeLayout(false);
        PanelLogo.ResumeLayout(false);
        PanelLogo.PerformLayout();
        PanelTitle.ResumeLayout(false);
        PanelMainContainer.ResumeLayout(false);
        PanelMainContainer.PerformLayout();
        MainTableLayoutPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Panel PanelSideBar;
    private Panel PanelLogo;
    private PictureBox PictureLogo;
    private Label LabelVersion;
    private Panel PanelTitle;
    private Label LabelTitle;
    private Button ButtonClose;
    private PictureBox PictureMainLogo;
    private Label LabelMain;
    private Button ButtonMinimize;
    private Button ButtonMaximize;
    private Panel PanelMainContainer;
    private Panel PanelWindowButtons;
    private TableLayoutPanel MainTableLayoutPanel;
    private Button button1;
    private Panel panel1;
    private Button button2;
    private Button button4;
    private Button button3;
}