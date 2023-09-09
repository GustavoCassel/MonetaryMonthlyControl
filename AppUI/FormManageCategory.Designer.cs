namespace AppUI;

partial class FormManageCategory
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageCategory));
        LabelTitle = new Label();
        MainTableLayoutPanel = new TableLayoutPanel();
        ButtonReturn = new Button();
        MainTableLayoutPanel.SuspendLayout();
        SuspendLayout();
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
        LabelTitle.Text = "Manage Category";
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainTableLayoutPanel
        // 
        MainTableLayoutPanel.ColumnCount = 2;
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
        MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        MainTableLayoutPanel.Controls.Add(LabelTitle, 1, 0);
        MainTableLayoutPanel.Controls.Add(ButtonReturn, 0, 0);
        MainTableLayoutPanel.Dock = DockStyle.Top;
        MainTableLayoutPanel.Location = new Point(0, 0);
        MainTableLayoutPanel.Margin = new Padding(2);
        MainTableLayoutPanel.Name = "MainTableLayoutPanel";
        MainTableLayoutPanel.RowCount = 1;
        MainTableLayoutPanel.RowStyles.Add(new RowStyle());
        MainTableLayoutPanel.Size = new Size(1184, 65);
        MainTableLayoutPanel.TabIndex = 7;
        // 
        // ButtonReturn
        // 
        ButtonReturn.BackColor = Color.FromArgb(210, 233, 233);
        ButtonReturn.Cursor = Cursors.Hand;
        ButtonReturn.Dock = DockStyle.Fill;
        ButtonReturn.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonReturn.FlatAppearance.BorderSize = 0;
        ButtonReturn.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonReturn.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonReturn.FlatStyle = FlatStyle.Flat;
        ButtonReturn.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonReturn.Image = Properties.Resources.book_48;
        ButtonReturn.ImageAlign = ContentAlignment.MiddleLeft;
        ButtonReturn.Location = new Point(0, 0);
        ButtonReturn.Margin = new Padding(0);
        ButtonReturn.Name = "ButtonReturn";
        ButtonReturn.Size = new Size(225, 65);
        ButtonReturn.TabIndex = 7;
        ButtonReturn.TabStop = false;
        ButtonReturn.Text = "Return";
        ButtonReturn.TextImageRelation = TextImageRelation.TextBeforeImage;
        ButtonReturn.UseVisualStyleBackColor = false;
        ButtonReturn.Click += ButtonReturn_Click;
        // 
        // FormManageCategory
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(227, 244, 244);
        ClientSize = new Size(1184, 661);
        Controls.Add(MainTableLayoutPanel);
        ForeColor = Color.Black;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimumSize = new Size(800, 405);
        Name = "FormManageCategory";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Manage Category";
        MainTableLayoutPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Label LabelTitle;
    private TableLayoutPanel MainTableLayoutPanel;
    private Button ButtonReturn;
}