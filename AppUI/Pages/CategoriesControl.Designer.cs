namespace AppUI.Pages;

partial class CategoriesControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        TableLayoutPanelFooter = new TableLayoutPanel();
        ButtonNewCategory = new Button();
        DataGridViewCategories = new DataGridView();
        TableLayoutPanelFooter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).BeginInit();
        SuspendLayout();
        // 
        // TableLayoutPanelFooter
        // 
        TableLayoutPanelFooter.ColumnCount = 4;
        TableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        TableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        TableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        TableLayoutPanelFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        TableLayoutPanelFooter.Controls.Add(ButtonNewCategory, 0, 0);
        TableLayoutPanelFooter.Dock = DockStyle.Bottom;
        TableLayoutPanelFooter.Location = new Point(0, 340);
        TableLayoutPanelFooter.Name = "TableLayoutPanelFooter";
        TableLayoutPanelFooter.RowCount = 1;
        TableLayoutPanelFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TableLayoutPanelFooter.Size = new Size(600, 60);
        TableLayoutPanelFooter.TabIndex = 3;
        // 
        // ButtonNewCategory
        // 
        ButtonNewCategory.Dock = DockStyle.Fill;
        ButtonNewCategory.ForeColor = Color.White;
        ButtonNewCategory.Location = new Point(3, 3);
        ButtonNewCategory.Name = "ButtonNewCategory";
        ButtonNewCategory.Size = new Size(114, 54);
        ButtonNewCategory.TabIndex = 0;
        ButtonNewCategory.Text = "Add New Category";
        ButtonNewCategory.UseVisualStyleBackColor = true;
        ButtonNewCategory.Click += ButtonNewCategory_Click;
        // 
        // DataGridViewCategories
        // 
        DataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        DataGridViewCategories.BackgroundColor = Color.FromArgb(10, 38, 71);
        DataGridViewCategories.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(32, 82, 149);
        dataGridViewCellStyle1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = Color.White;
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(32, 82, 149);
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        DataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        DataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 38, 71);
        dataGridViewCellStyle2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(73, 66, 228);
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        DataGridViewCategories.DefaultCellStyle = dataGridViewCellStyle2;
        DataGridViewCategories.Dock = DockStyle.Fill;
        DataGridViewCategories.EnableHeadersVisualStyles = false;
        DataGridViewCategories.GridColor = Color.White;
        DataGridViewCategories.Location = new Point(0, 0);
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
        DataGridViewCategories.Size = new Size(600, 340);
        DataGridViewCategories.TabIndex = 2;
        // 
        // CategoriesControl
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(10, 38, 71);
        Controls.Add(DataGridViewCategories);
        Controls.Add(TableLayoutPanelFooter);
        DoubleBuffered = true;
        Name = "CategoriesControl";
        Size = new Size(600, 400);
        TableLayoutPanelFooter.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private DataGridView DataGridViewCategories;
    private TableLayoutPanel TableLayoutPanelFooter;
    private Button ButtonNewCategory;
}
