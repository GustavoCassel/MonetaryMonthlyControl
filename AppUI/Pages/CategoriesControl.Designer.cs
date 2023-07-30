namespace AppUI.Pages
{
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            DataGridViewCategories = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            ButtonNewCategory = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(DataGridViewCategories, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(838, 552);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // DataGridViewCategories
            // 
            DataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCategories.BackgroundColor = Color.FromArgb(10, 38, 71);
            DataGridViewCategories.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(32, 82, 149);
            dataGridViewCellStyle7.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(32, 82, 149);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(10, 38, 71);
            dataGridViewCellStyle8.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(73, 66, 228);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            DataGridViewCategories.DefaultCellStyle = dataGridViewCellStyle8;
            DataGridViewCategories.Dock = DockStyle.Fill;
            DataGridViewCategories.EnableHeadersVisualStyles = false;
            DataGridViewCategories.GridColor = Color.White;
            DataGridViewCategories.Location = new Point(3, 3);
            DataGridViewCategories.MultiSelect = false;
            DataGridViewCategories.Name = "DataGridViewCategories";
            DataGridViewCategories.ReadOnly = true;
            DataGridViewCategories.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(10, 38, 71);
            dataGridViewCellStyle9.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DataGridViewCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DataGridViewCategories.RowHeadersVisible = false;
            DataGridViewCategories.RowTemplate.Height = 25;
            DataGridViewCategories.RowTemplate.ReadOnly = true;
            DataGridViewCategories.RowTemplate.Resizable = DataGridViewTriState.False;
            DataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCategories.Size = new Size(832, 463);
            DataGridViewCategories.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(ButtonNewCategory, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 472);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(832, 77);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // ButtonNewCategory
            // 
            ButtonNewCategory.Dock = DockStyle.Fill;
            ButtonNewCategory.Location = new Point(3, 3);
            ButtonNewCategory.Name = "ButtonNewCategory";
            ButtonNewCategory.Size = new Size(202, 71);
            ButtonNewCategory.TabIndex = 0;
            ButtonNewCategory.Text = "New Category";
            ButtonNewCategory.UseVisualStyleBackColor = true;
            ButtonNewCategory.Click += ButtonNewCategory_Click;
            // 
            // CategoriesControl
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CategoriesControl";
            Size = new Size(838, 552);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategories).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView DataGridViewCategories;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ButtonNewCategory;
    }
}
