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
        Label LabelMain;
        PictureBox PictureMainLogo;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
        button2 = new Button();
        button3 = new Button();
        ButtonConfigurations = new Button();
        ButtonDataToCSV = new Button();
        PictureLogo = new PictureBox();
        PanelWindowButtons = new Panel();
        ButtonMinimize = new Button();
        ButtonMaximize = new Button();
        ButtonClose = new Button();
        PanelSideBar = new Panel();
        button1 = new Button();
        PanelLogo = new Panel();
        LabelVersion = new Label();
        PanelTitle = new Panel();
        LabelTitle = new Label();
        MainTableLayoutPanel = new TableLayoutPanel();
        PanelMainContainer = new Panel();
        LabelMain = new Label();
        PictureMainLogo = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)PictureLogo).BeginInit();
        PanelWindowButtons.SuspendLayout();
        PanelSideBar.SuspendLayout();
        PanelLogo.SuspendLayout();
        PanelTitle.SuspendLayout();
        MainTableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PictureMainLogo).BeginInit();
        PanelMainContainer.SuspendLayout();
        SuspendLayout();
        // 
        // button2
        // 
        button2.Cursor = Cursors.Hand;
        button2.Dock = DockStyle.Top;
        button2.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        button2.Location = new Point(0, 60);
        button2.Margin = new Padding(1);
        button2.Name = "button2";
        button2.Size = new Size(221, 60);
        button2.TabIndex = 0;
        button2.Text = "Exportar Dados";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Cursor = Cursors.Hand;
        button3.Dock = DockStyle.Top;
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
        // ButtonConfigurations
        // 
        ButtonConfigurations.Cursor = Cursors.Hand;
        ButtonConfigurations.Dock = DockStyle.Bottom;
        ButtonConfigurations.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        ButtonConfigurations.FlatAppearance.BorderSize = 0;
        ButtonConfigurations.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        ButtonConfigurations.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        ButtonConfigurations.FlatStyle = FlatStyle.Flat;
        ButtonConfigurations.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonConfigurations.Location = new Point(0, 446);
        ButtonConfigurations.Margin = new Padding(1);
        ButtonConfigurations.Name = "ButtonConfigurations";
        ButtonConfigurations.Size = new Size(221, 60);
        ButtonConfigurations.TabIndex = 0;
        ButtonConfigurations.Text = "Configurações";
        ButtonConfigurations.UseVisualStyleBackColor = true;
        ButtonConfigurations.Click += ButtonConfigurations_Click;
        // 
        // ButtonDataToCSV
        // 
        ButtonDataToCSV.Cursor = Cursors.Hand;
        ButtonDataToCSV.Dock = DockStyle.Bottom;
        ButtonDataToCSV.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        ButtonDataToCSV.FlatAppearance.BorderSize = 0;
        ButtonDataToCSV.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        ButtonDataToCSV.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        ButtonDataToCSV.FlatStyle = FlatStyle.Flat;
        ButtonDataToCSV.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonDataToCSV.Location = new Point(0, 386);
        ButtonDataToCSV.Margin = new Padding(1);
        ButtonDataToCSV.Name = "ButtonDataToCSV";
        ButtonDataToCSV.Size = new Size(221, 60);
        ButtonDataToCSV.TabIndex = 0;
        ButtonDataToCSV.Text = "Importar / Exportar Dados - CSV";
        ButtonDataToCSV.UseVisualStyleBackColor = true;
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
        PanelWindowButtons.MouseDown += PanelWindowButtons_MouseDown;
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
        PanelSideBar.Controls.Add(ButtonDataToCSV);
        PanelSideBar.Controls.Add(ButtonConfigurations);
        PanelSideBar.Controls.Add(button1);
        PanelSideBar.Controls.Add(button2);
        PanelSideBar.Controls.Add(button3);
        PanelSideBar.Dock = DockStyle.Fill;
        PanelSideBar.Location = new Point(2, 67);
        PanelSideBar.Margin = new Padding(2);
        PanelSideBar.Name = "PanelSideBar";
        PanelSideBar.Size = new Size(221, 506);
        PanelSideBar.TabIndex = 1;
        // 
        // button1
        // 
        button1.Cursor = Cursors.Hand;
        button1.Dock = DockStyle.Top;
        button1.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(0, 120);
        button1.Margin = new Padding(1);
        button1.Name = "button1";
        button1.Size = new Size(221, 60);
        button1.TabIndex = 0;
        button1.Text = "Visualizar Situação";
        button1.UseVisualStyleBackColor = true;
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
        // LabelMain
        // 
        LabelMain.Anchor = AnchorStyles.None;
        LabelMain.AutoSize = true;
        LabelMain.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        LabelMain.Location = new Point(378, 214);
        LabelMain.Name = "LabelMain";
        LabelMain.Size = new Size(303, 68);
        LabelMain.TabIndex = 4;
        LabelMain.Text = "Controle Monetário\r\nMensal";
        LabelMain.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PictureMainLogo
        // 
        PictureMainLogo.Anchor = AnchorStyles.None;
        PictureMainLogo.ErrorImage = null;
        PictureMainLogo.Image = Properties.Resources.book_512;
        PictureMainLogo.InitialImage = null;
        PictureMainLogo.Location = new Point(218, 186);
        PictureMainLogo.Name = "PictureMainLogo";
        PictureMainLogo.Size = new Size(128, 128);
        PictureMainLogo.SizeMode = PictureBoxSizeMode.Zoom;
        PictureMainLogo.TabIndex = 5;
        PictureMainLogo.TabStop = false;
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
        PanelWindowButtons.ResumeLayout(false);
        PanelSideBar.ResumeLayout(false);
        PanelLogo.ResumeLayout(false);
        PanelLogo.PerformLayout();
        PanelTitle.ResumeLayout(false);
        MainTableLayoutPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PictureMainLogo).EndInit();
        PanelMainContainer.ResumeLayout(false);
        PanelMainContainer.PerformLayout();
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
    private Button ButtonMinimize;
    private Button ButtonMaximize;
    private Panel PanelWindowButtons;
    private TableLayoutPanel MainTableLayoutPanel;
    private Button button2;
    private Button ButtonConfigurations;
    private Button button3;
    private Button ButtonDataToCSV;
    private Button button1;
    private Panel PanelMainContainer;
}