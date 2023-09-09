namespace AppUI;

partial class FormConfigurations
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigurations));
        PanelWindowButtons = new Panel();
        ButtonMinimize = new Button();
        ButtonMaximize = new Button();
        ButtonClose = new Button();
        PanelTitle = new Panel();
        LabelTitle = new Label();
        MainTableLayoutPanel = new TableLayoutPanel();
        ButtonReturn = new Button();
        ComboBoxLanguages = new ComboBox();
        ComboBoxThemes = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        button1 = new Button();
        PanelWindowButtons.SuspendLayout();
        PanelTitle.SuspendLayout();
        MainTableLayoutPanel.SuspendLayout();
        SuspendLayout();
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
        LabelTitle.Text = "Configurations";
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainTableLayoutPanel
        // 
        MainTableLayoutPanel.ColumnCount = 2;
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        MainTableLayoutPanel.Controls.Add(PanelTitle, 1, 0);
        MainTableLayoutPanel.Controls.Add(ButtonReturn, 0, 0);
        MainTableLayoutPanel.Dock = DockStyle.Top;
        MainTableLayoutPanel.Location = new Point(0, 25);
        MainTableLayoutPanel.Margin = new Padding(2);
        MainTableLayoutPanel.Name = "MainTableLayoutPanel";
        MainTableLayoutPanel.RowCount = 1;
        MainTableLayoutPanel.RowStyles.Add(new RowStyle());
        MainTableLayoutPanel.Size = new Size(1200, 65);
        MainTableLayoutPanel.TabIndex = 7;
        // 
        // ButtonReturn
        // 
        ButtonReturn.BackColor = Color.Transparent;
        ButtonReturn.Cursor = Cursors.Hand;
        ButtonReturn.Dock = DockStyle.Fill;
        ButtonReturn.FlatAppearance.BorderColor = Color.FromArgb(32, 82, 149);
        ButtonReturn.FlatAppearance.BorderSize = 0;
        ButtonReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 66, 228);
        ButtonReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 82, 149);
        ButtonReturn.FlatStyle = FlatStyle.Flat;
        ButtonReturn.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonReturn.Image = Properties.Resources.book_48;
        ButtonReturn.ImageAlign = ContentAlignment.MiddleLeft;
        ButtonReturn.Location = new Point(3, 3);
        ButtonReturn.Name = "ButtonReturn";
        ButtonReturn.Size = new Size(219, 59);
        ButtonReturn.TabIndex = 7;
        ButtonReturn.TabStop = false;
        ButtonReturn.Text = "Return";
        ButtonReturn.TextImageRelation = TextImageRelation.TextBeforeImage;
        ButtonReturn.UseVisualStyleBackColor = true;
        ButtonReturn.Visible = false;
        ButtonReturn.Click += ButtonReturn_Click;
        // 
        // ComboBoxLanguages
        // 
        ComboBoxLanguages.DropDownStyle = ComboBoxStyle.DropDownList;
        ComboBoxLanguages.FormattingEnabled = true;
        ComboBoxLanguages.Location = new Point(58, 182);
        ComboBoxLanguages.Name = "ComboBoxLanguages";
        ComboBoxLanguages.Size = new Size(209, 27);
        ComboBoxLanguages.TabIndex = 9;
        // 
        // ComboBoxThemes
        // 
        ComboBoxThemes.DropDownStyle = ComboBoxStyle.DropDownList;
        ComboBoxThemes.FormattingEnabled = true;
        ComboBoxThemes.Location = new Point(58, 248);
        ComboBoxThemes.Name = "ComboBoxThemes";
        ComboBoxThemes.Size = new Size(209, 27);
        ComboBoxThemes.TabIndex = 10;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(58, 158);
        label1.Name = "label1";
        label1.Size = new Size(90, 19);
        label1.TabIndex = 11;
        label1.Text = "Language:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(58, 224);
        label2.Name = "label2";
        label2.Size = new Size(63, 19);
        label2.TabIndex = 12;
        label2.Text = "Theme:";
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(20, 66, 114);
        button1.Location = new Point(400, 311);
        button1.Name = "button1";
        button1.Size = new Size(123, 54);
        button1.TabIndex = 13;
        button1.Text = "Save";
        button1.UseVisualStyleBackColor = false;
        // 
        // FormConfigurations
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(10, 38, 71);
        ClientSize = new Size(1200, 700);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(ComboBoxThemes);
        Controls.Add(ComboBoxLanguages);
        Controls.Add(MainTableLayoutPanel);
        Controls.Add(PanelWindowButtons);
        DoubleBuffered = true;
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimumSize = new Size(1200, 700);
        Name = "FormConfigurations";
        SizeGripStyle = SizeGripStyle.Show;
        StartPosition = FormStartPosition.CenterScreen;
        PanelWindowButtons.ResumeLayout(false);
        PanelTitle.ResumeLayout(false);
        MainTableLayoutPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Panel PanelTitle;
    private Label LabelTitle;
    private Button ButtonClose;
    private Button ButtonMinimize;
    private Button ButtonMaximize;
    private Panel PanelWindowButtons;
    private TableLayoutPanel MainTableLayoutPanel;
    private Button ButtonReturn;
    private ComboBox ComboBoxLanguages;
    private ComboBox ComboBoxThemes;
    private Label label1;
    private Label label2;
    private Button button1;
}