namespace AppUI;

partial class FormMenu
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
        ButtonCategories = new Button();
        ButtonEntries = new Button();
        ButtonConfigurations = new Button();
        ButtonDataToCSV = new Button();
        PanelWindowButtons = new Panel();
        ButtonMinimize = new Button();
        ButtonMaximize = new Button();
        ButtonClose = new Button();
        PanelSideBar = new Panel();
        ButtonReport = new Button();
        PanelTitle = new Panel();
        LabelTitle = new Label();
        MainTableLayoutPanel = new TableLayoutPanel();
        PanelMainContainer = new Panel();
        ButtonMainMenu = new Button();
        PanelWindowButtons.SuspendLayout();
        PanelSideBar.SuspendLayout();
        PanelTitle.SuspendLayout();
        MainTableLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // ButtonCategories
        // 
        ButtonCategories.Cursor = Cursors.Hand;
        ButtonCategories.Dock = DockStyle.Top;
        ButtonCategories.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        ButtonCategories.FlatAppearance.BorderSize = 0;
        ButtonCategories.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        ButtonCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        ButtonCategories.FlatStyle = FlatStyle.Flat;
        ButtonCategories.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonCategories.Location = new Point(0, 60);
        ButtonCategories.Margin = new Padding(1);
        ButtonCategories.Name = "ButtonCategories";
        ButtonCategories.Size = new Size(221, 60);
        ButtonCategories.TabIndex = 0;
        ButtonCategories.TabStop = false;
        ButtonCategories.Text = "Manage Categories";
        ButtonCategories.UseVisualStyleBackColor = true;
        ButtonCategories.Click += ButtonCategories_Click;
        // 
        // ButtonEntries
        // 
        ButtonEntries.Cursor = Cursors.Hand;
        ButtonEntries.Dock = DockStyle.Top;
        ButtonEntries.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        ButtonEntries.FlatAppearance.BorderSize = 0;
        ButtonEntries.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        ButtonEntries.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        ButtonEntries.FlatStyle = FlatStyle.Flat;
        ButtonEntries.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonEntries.Location = new Point(0, 0);
        ButtonEntries.Margin = new Padding(1);
        ButtonEntries.Name = "ButtonEntries";
        ButtonEntries.Size = new Size(221, 60);
        ButtonEntries.TabIndex = 0;
        ButtonEntries.TabStop = false;
        ButtonEntries.Text = "Manage Entries";
        ButtonEntries.UseVisualStyleBackColor = true;
        ButtonEntries.Click += ButtonEntries_Click;
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
        ButtonConfigurations.Location = new Point(0, 546);
        ButtonConfigurations.Margin = new Padding(1);
        ButtonConfigurations.Name = "ButtonConfigurations";
        ButtonConfigurations.Size = new Size(221, 60);
        ButtonConfigurations.TabIndex = 0;
        ButtonConfigurations.TabStop = false;
        ButtonConfigurations.Text = "Configurations";
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
        ButtonDataToCSV.Location = new Point(0, 486);
        ButtonDataToCSV.Margin = new Padding(1);
        ButtonDataToCSV.Name = "ButtonDataToCSV";
        ButtonDataToCSV.Size = new Size(221, 60);
        ButtonDataToCSV.TabIndex = 0;
        ButtonDataToCSV.TabStop = false;
        ButtonDataToCSV.Text = "Import / Export\r\nData - CSV";
        ButtonDataToCSV.UseVisualStyleBackColor = true;
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
        PanelWindowButtons.Size = new Size(1200, 25);
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
        ButtonMinimize.Location = new Point(1110, 0);
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
        ButtonMaximize.Location = new Point(1140, 0);
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
        ButtonClose.Location = new Point(1170, 0);
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
        PanelSideBar.Controls.Add(ButtonReport);
        PanelSideBar.Controls.Add(ButtonCategories);
        PanelSideBar.Controls.Add(ButtonEntries);
        PanelSideBar.Dock = DockStyle.Fill;
        PanelSideBar.Location = new Point(2, 67);
        PanelSideBar.Margin = new Padding(2);
        PanelSideBar.Name = "PanelSideBar";
        PanelSideBar.Size = new Size(221, 606);
        PanelSideBar.TabIndex = 1;
        // 
        // ButtonReport
        // 
        ButtonReport.Cursor = Cursors.Hand;
        ButtonReport.Dock = DockStyle.Top;
        ButtonReport.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        ButtonReport.FlatAppearance.BorderSize = 0;
        ButtonReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        ButtonReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        ButtonReport.FlatStyle = FlatStyle.Flat;
        ButtonReport.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonReport.Location = new Point(0, 120);
        ButtonReport.Margin = new Padding(1);
        ButtonReport.Name = "ButtonReport";
        ButtonReport.Size = new Size(221, 60);
        ButtonReport.TabIndex = 0;
        ButtonReport.TabStop = false;
        ButtonReport.Text = "Generate Report";
        ButtonReport.UseVisualStyleBackColor = true;
        ButtonReport.Click += ButtonReport_Click;
        // 
        // PanelTitle
        // 
        PanelTitle.BackColor = Color.Transparent;
        PanelTitle.Controls.Add(LabelTitle);
        PanelTitle.Dock = DockStyle.Fill;
        PanelTitle.Location = new Point(227, 2);
        PanelTitle.Margin = new Padding(2);
        PanelTitle.Name = "PanelTitle";
        PanelTitle.Size = new Size(971, 61);
        PanelTitle.TabIndex = 2;
        // 
        // LabelTitle
        // 
        LabelTitle.Dock = DockStyle.Fill;
        LabelTitle.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        LabelTitle.Location = new Point(0, 0);
        LabelTitle.Name = "LabelTitle";
        LabelTitle.Size = new Size(971, 61);
        LabelTitle.TabIndex = 3;
        LabelTitle.Text = "Main Menu";
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainTableLayoutPanel
        // 
        MainTableLayoutPanel.ColumnCount = 2;
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        MainTableLayoutPanel.Controls.Add(PanelTitle, 1, 0);
        MainTableLayoutPanel.Controls.Add(PanelMainContainer, 1, 1);
        MainTableLayoutPanel.Controls.Add(PanelSideBar, 0, 1);
        MainTableLayoutPanel.Controls.Add(ButtonMainMenu, 0, 0);
        MainTableLayoutPanel.Dock = DockStyle.Fill;
        MainTableLayoutPanel.Location = new Point(0, 25);
        MainTableLayoutPanel.Margin = new Padding(2);
        MainTableLayoutPanel.Name = "MainTableLayoutPanel";
        MainTableLayoutPanel.RowCount = 2;
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        MainTableLayoutPanel.Size = new Size(1200, 675);
        MainTableLayoutPanel.TabIndex = 7;
        // 
        // PanelMainContainer
        // 
        PanelMainContainer.BackColor = Color.Transparent;
        PanelMainContainer.Dock = DockStyle.Fill;
        PanelMainContainer.Location = new Point(227, 67);
        PanelMainContainer.Margin = new Padding(2);
        PanelMainContainer.Name = "PanelMainContainer";
        PanelMainContainer.Size = new Size(971, 606);
        PanelMainContainer.TabIndex = 6;
        // 
        // ButtonMainMenu
        // 
        ButtonMainMenu.BackColor = Color.Transparent;
        ButtonMainMenu.Cursor = Cursors.Hand;
        ButtonMainMenu.Dock = DockStyle.Fill;
        ButtonMainMenu.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        ButtonMainMenu.FlatAppearance.BorderSize = 0;
        ButtonMainMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        ButtonMainMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        ButtonMainMenu.FlatStyle = FlatStyle.Flat;
        ButtonMainMenu.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonMainMenu.Image = Properties.Resources.book_48;
        ButtonMainMenu.ImageAlign = ContentAlignment.MiddleLeft;
        ButtonMainMenu.Location = new Point(3, 3);
        ButtonMainMenu.Name = "ButtonMainMenu";
        ButtonMainMenu.Size = new Size(219, 59);
        ButtonMainMenu.TabIndex = 7;
        ButtonMainMenu.TabStop = false;
        ButtonMainMenu.Text = "Main Menu";
        ButtonMainMenu.UseVisualStyleBackColor = true;
        ButtonMainMenu.Visible = false;
        ButtonMainMenu.Click += ButtonMainMenu_Click;
        // 
        // FormMenu
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(10, 38, 71);
        ClientSize = new Size(1200, 700);
        Controls.Add(MainTableLayoutPanel);
        Controls.Add(PanelWindowButtons);
        DoubleBuffered = true;
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimumSize = new Size(1200, 700);
        Name = "FormMenu";
        SizeGripStyle = SizeGripStyle.Show;
        StartPosition = FormStartPosition.CenterScreen;
        PanelWindowButtons.ResumeLayout(false);
        PanelSideBar.ResumeLayout(false);
        PanelTitle.ResumeLayout(false);
        MainTableLayoutPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Panel PanelSideBar;
    private PictureBox PictureLogo;
    private Panel PanelTitle;
    private Label LabelTitle;
    private Button ButtonClose;
    private Button ButtonMinimize;
    private Button ButtonMaximize;
    private Panel PanelWindowButtons;
    private TableLayoutPanel MainTableLayoutPanel;
    private Button ButtonCategories;
    private Button ButtonConfigurations;
    private Button ButtonEntries;
    private Button ButtonDataToCSV;
    private Button ButtonReport;
    private Panel PanelMainContainer;
    private Button ButtonMainMenu;
}