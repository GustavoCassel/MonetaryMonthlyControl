namespace AppUI;

partial class FormCategories
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategories));
        LabelTitle = new Label();
        MainTableLayoutPanel = new TableLayoutPanel();
        ButtonReturn = new Button();
        DataGridViewCategories = new DataGridView();
        PanelSideBar = new Panel();
        ButtonDelete = new Button();
        ButtonEdit = new Button();
        ButtonAdd = new Button();
        ButtonSave = new Button();
        MainTableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).BeginInit();
        PanelSideBar.SuspendLayout();
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
        LabelTitle.Text = "Categories";
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
        // DataGridViewCategories
        // 
        DataGridViewCategories.AllowUserToAddRows = false;
        DataGridViewCategories.AllowUserToDeleteRows = false;
        DataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        DataGridViewCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        DataGridViewCategories.BackgroundColor = Color.FromArgb(227, 244, 244);
        DataGridViewCategories.BorderStyle = BorderStyle.None;
        DataGridViewCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(166, 208, 221);
        dataGridViewCellStyle1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = Color.Black;
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(166, 208, 221);
        dataGridViewCellStyle1.SelectionForeColor = Color.Black;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        DataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        DataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(210, 233, 233);
        dataGridViewCellStyle2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = Color.Black;
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(150, 182, 197);
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        DataGridViewCategories.DefaultCellStyle = dataGridViewCellStyle2;
        DataGridViewCategories.Dock = DockStyle.Fill;
        DataGridViewCategories.EnableHeadersVisualStyles = false;
        DataGridViewCategories.GridColor = Color.White;
        DataGridViewCategories.Location = new Point(225, 65);
        DataGridViewCategories.Margin = new Padding(0);
        DataGridViewCategories.MultiSelect = false;
        DataGridViewCategories.Name = "DataGridViewCategories";
        DataGridViewCategories.ReadOnly = true;
        DataGridViewCategories.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(10, 38, 71);
        dataGridViewCellStyle3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle3.ForeColor = Color.White;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        DataGridViewCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        DataGridViewCategories.RowHeadersVisible = false;
        DataGridViewCategories.RowTemplate.Height = 25;
        DataGridViewCategories.RowTemplate.ReadOnly = true;
        DataGridViewCategories.RowTemplate.Resizable = DataGridViewTriState.False;
        DataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DataGridViewCategories.Size = new Size(959, 596);
        DataGridViewCategories.TabIndex = 17;
        // 
        // PanelSideBar
        // 
        PanelSideBar.BackColor = Color.FromArgb(210, 233, 233);
        PanelSideBar.Controls.Add(ButtonSave);
        PanelSideBar.Controls.Add(ButtonDelete);
        PanelSideBar.Controls.Add(ButtonEdit);
        PanelSideBar.Controls.Add(ButtonAdd);
        PanelSideBar.Dock = DockStyle.Left;
        PanelSideBar.Location = new Point(0, 65);
        PanelSideBar.Margin = new Padding(0);
        PanelSideBar.Name = "PanelSideBar";
        PanelSideBar.Size = new Size(225, 596);
        PanelSideBar.TabIndex = 21;
        // 
        // ButtonDelete
        // 
        ButtonDelete.Cursor = Cursors.Hand;
        ButtonDelete.Dock = DockStyle.Top;
        ButtonDelete.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonDelete.FlatAppearance.BorderSize = 0;
        ButtonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonDelete.FlatStyle = FlatStyle.Flat;
        ButtonDelete.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonDelete.Location = new Point(0, 120);
        ButtonDelete.Margin = new Padding(1);
        ButtonDelete.Name = "ButtonDelete";
        ButtonDelete.Size = new Size(225, 60);
        ButtonDelete.TabIndex = 0;
        ButtonDelete.TabStop = false;
        ButtonDelete.Text = "Delete Category";
        ButtonDelete.UseVisualStyleBackColor = true;
        ButtonDelete.Visible = false;
        ButtonDelete.Click += ButtonDelete_Click;
        // 
        // ButtonEdit
        // 
        ButtonEdit.Cursor = Cursors.Hand;
        ButtonEdit.Dock = DockStyle.Top;
        ButtonEdit.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonEdit.FlatAppearance.BorderSize = 0;
        ButtonEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonEdit.FlatStyle = FlatStyle.Flat;
        ButtonEdit.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonEdit.Location = new Point(0, 60);
        ButtonEdit.Margin = new Padding(1);
        ButtonEdit.Name = "ButtonEdit";
        ButtonEdit.Size = new Size(225, 60);
        ButtonEdit.TabIndex = 0;
        ButtonEdit.TabStop = false;
        ButtonEdit.Text = "Edit Category";
        ButtonEdit.UseVisualStyleBackColor = true;
        ButtonEdit.Visible = false;
        ButtonEdit.Click += ButtonEdit_Click;
        // 
        // ButtonAdd
        // 
        ButtonAdd.Cursor = Cursors.Hand;
        ButtonAdd.Dock = DockStyle.Top;
        ButtonAdd.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonAdd.FlatAppearance.BorderSize = 0;
        ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonAdd.FlatStyle = FlatStyle.Flat;
        ButtonAdd.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonAdd.Location = new Point(0, 0);
        ButtonAdd.Margin = new Padding(1);
        ButtonAdd.Name = "ButtonAdd";
        ButtonAdd.Size = new Size(225, 60);
        ButtonAdd.TabIndex = 0;
        ButtonAdd.TabStop = false;
        ButtonAdd.Text = "Add New Category";
        ButtonAdd.UseVisualStyleBackColor = true;
        ButtonAdd.Click += ButtonAdd_Click;
        // 
        // ButtonSave
        // 
        ButtonSave.Cursor = Cursors.Hand;
        ButtonSave.Dock = DockStyle.Bottom;
        ButtonSave.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonSave.FlatAppearance.BorderSize = 0;
        ButtonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        ButtonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        ButtonSave.FlatStyle = FlatStyle.Flat;
        ButtonSave.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        ButtonSave.Location = new Point(0, 536);
        ButtonSave.Margin = new Padding(1);
        ButtonSave.Name = "ButtonSave";
        ButtonSave.Size = new Size(225, 60);
        ButtonSave.TabIndex = 1;
        ButtonSave.TabStop = false;
        ButtonSave.Text = "Save and Exit";
        ButtonSave.UseVisualStyleBackColor = true;
        ButtonSave.Click += ButtonSave_Click;
        // 
        // FormCategories
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(227, 244, 244);
        ClientSize = new Size(1184, 661);
        Controls.Add(DataGridViewCategories);
        Controls.Add(PanelSideBar);
        Controls.Add(MainTableLayoutPanel);
        ForeColor = Color.Black;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimumSize = new Size(800, 405);
        Name = "FormCategories";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Categories";
        MainTableLayoutPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).EndInit();
        PanelSideBar.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Label LabelTitle;
    private TableLayoutPanel MainTableLayoutPanel;
    private Button ButtonReturn;
    private DataGridView DataGridViewCategories;
    private Panel PanelSideBar;
    private Button ButtonDelete;
    private Button ButtonEdit;
    private Button ButtonAdd;
    private Button ButtonSave;
}