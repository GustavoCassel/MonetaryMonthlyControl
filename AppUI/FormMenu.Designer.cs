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
        MainTableLayoutPanel = new TableLayoutPanel();
        LabelTitle = new Label();
        PanelMainContainer = new Panel();
        PanelSideBar = new Panel();
        ButtonDataToCSV = new Button();
        ButtonConfigurations = new Button();
        ButtonReport = new Button();
        ButtonCategories = new Button();
        ButtonEntries = new Button();
        ButtonAbout = new Button();
        MainTableLayoutPanel.SuspendLayout();
        PanelSideBar.SuspendLayout();
        SuspendLayout();
        // 
        // MainTableLayoutPanel
        // 
        MainTableLayoutPanel.ColumnCount = 2;
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        MainTableLayoutPanel.Controls.Add(LabelTitle, 1, 0);
        MainTableLayoutPanel.Controls.Add(PanelMainContainer, 1, 1);
        MainTableLayoutPanel.Controls.Add(PanelSideBar, 0, 1);
        MainTableLayoutPanel.Controls.Add(ButtonAbout, 0, 0);
        MainTableLayoutPanel.Dock = DockStyle.Fill;
        MainTableLayoutPanel.Location = new Point(0, 0);
        MainTableLayoutPanel.Name = "MainTableLayoutPanel";
        MainTableLayoutPanel.RowCount = 2;
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        MainTableLayoutPanel.Size = new Size(1184, 661);
        MainTableLayoutPanel.TabIndex = 8;
        // 
        // LabelTitle
        // 
        LabelTitle.BackColor = Color.FromArgb(210, 233, 233);
        LabelTitle.Dock = DockStyle.Fill;
        LabelTitle.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        LabelTitle.Location = new Point(225, 0);
        LabelTitle.Margin = new Padding(0);
        LabelTitle.Name = "LabelTitle";
        LabelTitle.Size = new Size(959, 65);
        LabelTitle.TabIndex = 3;
        LabelTitle.Text = "Main Menu";
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanelMainContainer
        // 
        PanelMainContainer.BackColor = Color.Transparent;
        PanelMainContainer.Dock = DockStyle.Fill;
        PanelMainContainer.Location = new Point(227, 67);
        PanelMainContainer.Margin = new Padding(2);
        PanelMainContainer.Name = "PanelMainContainer";
        PanelMainContainer.Size = new Size(955, 592);
        PanelMainContainer.TabIndex = 6;
        // 
        // PanelSideBar
        // 
        PanelSideBar.BackColor = Color.FromArgb(210, 233, 233);
        PanelSideBar.Controls.Add(ButtonDataToCSV);
        PanelSideBar.Controls.Add(ButtonConfigurations);
        PanelSideBar.Controls.Add(ButtonReport);
        PanelSideBar.Controls.Add(ButtonCategories);
        PanelSideBar.Controls.Add(ButtonEntries);
        PanelSideBar.Dock = DockStyle.Fill;
        PanelSideBar.Location = new Point(0, 65);
        PanelSideBar.Margin = new Padding(0);
        PanelSideBar.Name = "PanelSideBar";
        PanelSideBar.Size = new Size(225, 596);
        PanelSideBar.TabIndex = 1;
        // 
        // ButtonDataToCSV
        // 
        ButtonDataToCSV.Cursor = Cursors.Hand;
        ButtonDataToCSV.Dock = DockStyle.Bottom;
        ButtonDataToCSV.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonDataToCSV.FlatAppearance.BorderSize = 0;
        ButtonDataToCSV.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonDataToCSV.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonDataToCSV.FlatStyle = FlatStyle.Flat;
        ButtonDataToCSV.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonDataToCSV.Location = new Point(0, 476);
        ButtonDataToCSV.Margin = new Padding(1);
        ButtonDataToCSV.Name = "ButtonDataToCSV";
        ButtonDataToCSV.Size = new Size(225, 60);
        ButtonDataToCSV.TabIndex = 0;
        ButtonDataToCSV.TabStop = false;
        ButtonDataToCSV.Text = "Import / Export\r\nData - CSV";
        ButtonDataToCSV.UseVisualStyleBackColor = true;
        // 
        // ButtonConfigurations
        // 
        ButtonConfigurations.Cursor = Cursors.Hand;
        ButtonConfigurations.Dock = DockStyle.Bottom;
        ButtonConfigurations.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonConfigurations.FlatAppearance.BorderSize = 0;
        ButtonConfigurations.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonConfigurations.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonConfigurations.FlatStyle = FlatStyle.Flat;
        ButtonConfigurations.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonConfigurations.Location = new Point(0, 536);
        ButtonConfigurations.Margin = new Padding(1);
        ButtonConfigurations.Name = "ButtonConfigurations";
        ButtonConfigurations.Size = new Size(225, 60);
        ButtonConfigurations.TabIndex = 0;
        ButtonConfigurations.TabStop = false;
        ButtonConfigurations.Text = "Configurations";
        ButtonConfigurations.UseVisualStyleBackColor = true;
        // 
        // ButtonReport
        // 
        ButtonReport.Cursor = Cursors.Hand;
        ButtonReport.Dock = DockStyle.Top;
        ButtonReport.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonReport.FlatAppearance.BorderSize = 0;
        ButtonReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonReport.FlatStyle = FlatStyle.Flat;
        ButtonReport.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonReport.Location = new Point(0, 120);
        ButtonReport.Margin = new Padding(1);
        ButtonReport.Name = "ButtonReport";
        ButtonReport.Size = new Size(225, 60);
        ButtonReport.TabIndex = 0;
        ButtonReport.TabStop = false;
        ButtonReport.Text = "Generate Report";
        ButtonReport.UseVisualStyleBackColor = true;
        // 
        // ButtonCategories
        // 
        ButtonCategories.Cursor = Cursors.Hand;
        ButtonCategories.Dock = DockStyle.Top;
        ButtonCategories.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonCategories.FlatAppearance.BorderSize = 0;
        ButtonCategories.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonCategories.FlatStyle = FlatStyle.Flat;
        ButtonCategories.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonCategories.Location = new Point(0, 60);
        ButtonCategories.Margin = new Padding(1);
        ButtonCategories.Name = "ButtonCategories";
        ButtonCategories.Size = new Size(225, 60);
        ButtonCategories.TabIndex = 0;
        ButtonCategories.TabStop = false;
        ButtonCategories.Text = "Manage Categories";
        ButtonCategories.UseVisualStyleBackColor = true;
        // 
        // ButtonEntries
        // 
        ButtonEntries.Cursor = Cursors.Hand;
        ButtonEntries.Dock = DockStyle.Top;
        ButtonEntries.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonEntries.FlatAppearance.BorderSize = 0;
        ButtonEntries.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonEntries.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonEntries.FlatStyle = FlatStyle.Flat;
        ButtonEntries.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonEntries.Location = new Point(0, 0);
        ButtonEntries.Margin = new Padding(1);
        ButtonEntries.Name = "ButtonEntries";
        ButtonEntries.Size = new Size(225, 60);
        ButtonEntries.TabIndex = 0;
        ButtonEntries.TabStop = false;
        ButtonEntries.Text = "Manage Entries";
        ButtonEntries.UseVisualStyleBackColor = true;
        // 
        // ButtonAbout
        // 
        ButtonAbout.BackColor = Color.FromArgb(210, 233, 233);
        ButtonAbout.Cursor = Cursors.Hand;
        ButtonAbout.Dock = DockStyle.Fill;
        ButtonAbout.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonAbout.FlatAppearance.BorderSize = 0;
        ButtonAbout.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonAbout.FlatStyle = FlatStyle.Flat;
        ButtonAbout.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonAbout.Image = Properties.Resources.book_48;
        ButtonAbout.ImageAlign = ContentAlignment.MiddleLeft;
        ButtonAbout.Location = new Point(0, 0);
        ButtonAbout.Margin = new Padding(0);
        ButtonAbout.Name = "ButtonAbout";
        ButtonAbout.Padding = new Padding(1);
        ButtonAbout.Size = new Size(225, 65);
        ButtonAbout.TabIndex = 7;
        ButtonAbout.TabStop = false;
        ButtonAbout.Text = "About";
        ButtonAbout.TextImageRelation = TextImageRelation.TextBeforeImage;
        ButtonAbout.UseVisualStyleBackColor = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(227, 244, 244);
        ClientSize = new Size(1184, 661);
        Controls.Add(MainTableLayoutPanel);
        ForeColor = Color.Black;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(800, 405);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Main Menu";
        MainTableLayoutPanel.ResumeLayout(false);
        PanelSideBar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel MainTableLayoutPanel;
    private Label LabelTitle;
    private Panel PanelMainContainer;
    private Panel PanelSideBar;
    private Button ButtonDataToCSV;
    private Button ButtonConfigurations;
    private Button ButtonReport;
    private Button ButtonCategories;
    private Button ButtonEntries;
    private Button ButtonAbout;
}