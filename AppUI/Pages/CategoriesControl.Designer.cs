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
            ListViewCategories = new ListView();
            ColumnName = new ColumnHeader();
            ColumnDescription = new ColumnHeader();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ListViewCategories
            // 
            ListViewCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListViewCategories.Columns.AddRange(new ColumnHeader[] { ColumnName, ColumnDescription });
            ListViewCategories.FullRowSelect = true;
            ListViewCategories.GridLines = true;
            ListViewCategories.Location = new Point(0, 3);
            ListViewCategories.Name = "ListViewCategories";
            ListViewCategories.Size = new Size(437, 546);
            ListViewCategories.TabIndex = 1;
            ListViewCategories.UseCompatibleStateImageBehavior = false;
            ListViewCategories.View = View.Details;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Name";
            ColumnName.Width = 120;
            // 
            // ColumnDescription
            // 
            ColumnDescription.Text = "Description";
            ColumnDescription.Width = 300;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(502, 306);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.TabStop = false;
            // 
            // CategoriesControl
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(ListViewCategories);
            Name = "CategoriesControl";
            Size = new Size(838, 552);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListView ListViewCategories;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnDescription;
        private DataGridView dataGridView1;
    }
}
