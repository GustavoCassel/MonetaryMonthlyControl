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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageCategory));
        LabelTitle = new Label();
        MainTableLayoutPanel = new TableLayoutPanel();
        ButtonReturn = new Button();
        TextBoxId = new TextBox();
        bsCategory = new BindingSource(components);
        TextBoxName = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        TextBoxDescription = new TextBox();
        TextBoxModified = new TextBox();
        TextBoxCreated = new TextBox();
        ButtonConfirm = new Button();
        MainTableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)bsCategory).BeginInit();
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
        LabelTitle.Size = new Size(359, 65);
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
        MainTableLayoutPanel.Size = new Size(584, 65);
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
        // TextBoxId
        // 
        TextBoxId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TextBoxId.DataBindings.Add(new Binding("Text", bsCategory, "Id", true, DataSourceUpdateMode.OnPropertyChanged));
        TextBoxId.Location = new Point(12, 100);
        TextBoxId.Name = "TextBoxId";
        TextBoxId.ReadOnly = true;
        TextBoxId.Size = new Size(560, 26);
        TextBoxId.TabIndex = 0;
        // 
        // bsCategory
        // 
        bsCategory.DataSource = typeof(AppLib.Models.Category);
        // 
        // TextBoxName
        // 
        TextBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TextBoxName.DataBindings.Add(new Binding("Text", bsCategory, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
        TextBoxName.Location = new Point(12, 160);
        TextBoxName.Name = "TextBoxName";
        TextBoxName.Size = new Size(560, 26);
        TextBoxName.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 76);
        label1.Name = "label1";
        label1.Size = new Size(27, 19);
        label1.TabIndex = 10;
        label1.Text = "Id";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 136);
        label2.Name = "label2";
        label2.Size = new Size(45, 19);
        label2.TabIndex = 11;
        label2.Text = "Name";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 198);
        label3.Name = "label3";
        label3.Size = new Size(108, 19);
        label3.TabIndex = 13;
        label3.Text = "Description";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 371);
        label4.Name = "label4";
        label4.Size = new Size(72, 19);
        label4.TabIndex = 15;
        label4.Text = "Created";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(12, 431);
        label5.Name = "label5";
        label5.Size = new Size(81, 19);
        label5.TabIndex = 17;
        label5.Text = "Modified";
        // 
        // TextBoxDescription
        // 
        TextBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TextBoxDescription.DataBindings.Add(new Binding("Text", bsCategory, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
        TextBoxDescription.Location = new Point(12, 220);
        TextBoxDescription.Multiline = true;
        TextBoxDescription.Name = "TextBoxDescription";
        TextBoxDescription.Size = new Size(560, 132);
        TextBoxDescription.TabIndex = 2;
        // 
        // TextBoxModified
        // 
        TextBoxModified.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TextBoxModified.DataBindings.Add(new Binding("Text", bsCategory, "Modified", true, DataSourceUpdateMode.OnPropertyChanged, null, "G"));
        TextBoxModified.Location = new Point(12, 453);
        TextBoxModified.Name = "TextBoxModified";
        TextBoxModified.ReadOnly = true;
        TextBoxModified.Size = new Size(560, 26);
        TextBoxModified.TabIndex = 4;
        // 
        // TextBoxCreated
        // 
        TextBoxCreated.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        TextBoxCreated.DataBindings.Add(new Binding("Text", bsCategory, "Created", true, DataSourceUpdateMode.OnPropertyChanged, null, "G"));
        TextBoxCreated.Location = new Point(12, 393);
        TextBoxCreated.Name = "TextBoxCreated";
        TextBoxCreated.ReadOnly = true;
        TextBoxCreated.Size = new Size(560, 26);
        TextBoxCreated.TabIndex = 3;
        // 
        // ButtonConfirm
        // 
        ButtonConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        ButtonConfirm.BackColor = Color.FromArgb(210, 233, 233);
        ButtonConfirm.Cursor = Cursors.Hand;
        ButtonConfirm.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonConfirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonConfirm.FlatStyle = FlatStyle.Flat;
        ButtonConfirm.Location = new Point(449, 490);
        ButtonConfirm.Name = "ButtonConfirm";
        ButtonConfirm.Size = new Size(123, 54);
        ButtonConfirm.TabIndex = 18;
        ButtonConfirm.Text = "Confirm";
        ButtonConfirm.UseVisualStyleBackColor = false;
        ButtonConfirm.Click += ButtonConfirm_Click;
        // 
        // FormManageCategory
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(227, 244, 244);
        ClientSize = new Size(584, 556);
        Controls.Add(ButtonConfirm);
        Controls.Add(TextBoxCreated);
        Controls.Add(TextBoxModified);
        Controls.Add(TextBoxDescription);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(TextBoxName);
        Controls.Add(TextBoxId);
        Controls.Add(MainTableLayoutPanel);
        ForeColor = Color.Black;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimumSize = new Size(400, 595);
        Name = "FormManageCategory";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Manage Category";
        MainTableLayoutPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)bsCategory).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label LabelTitle;
    private TableLayoutPanel MainTableLayoutPanel;
    private Button ButtonReturn;
    private TextBox TextBoxId;
    private TextBox TextBoxName;
    private Label label1;
    private Label label2;
    private BindingSource bsCategory;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox TextBoxDescription;
    private TextBox TextBoxModified;
    private TextBox TextBoxCreated;
    private Button ButtonConfirm;
}