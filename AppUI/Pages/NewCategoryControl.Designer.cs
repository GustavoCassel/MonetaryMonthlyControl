namespace AppUI.Pages;

partial class NewCategoryControl
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
        Label label1;
        Label label2;
        TextBoxName = new TextBox();
        RichTextBoxDescription = new RichTextBox();
        panel1 = new Panel();
        ButtonConfirm = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        label1 = new Label();
        label2 = new Label();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Fill;
        label1.Location = new Point(3, 60);
        label1.Name = "label1";
        label1.Size = new Size(594, 30);
        label1.TabIndex = 3;
        label1.Text = "Category Description";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Fill;
        label2.Location = new Point(3, 0);
        label2.Name = "label2";
        label2.Size = new Size(594, 30);
        label2.TabIndex = 4;
        label2.Text = "Category Name";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TextBoxName
        // 
        TextBoxName.Dock = DockStyle.Fill;
        TextBoxName.Location = new Point(3, 33);
        TextBoxName.MaxLength = 20;
        TextBoxName.Name = "TextBoxName";
        TextBoxName.Size = new Size(594, 26);
        TextBoxName.TabIndex = 0;
        // 
        // RichTextBoxDescription
        // 
        RichTextBoxDescription.Dock = DockStyle.Fill;
        RichTextBoxDescription.Location = new Point(3, 93);
        RichTextBoxDescription.MaxLength = 150;
        RichTextBoxDescription.Name = "RichTextBoxDescription";
        RichTextBoxDescription.Size = new Size(594, 244);
        RichTextBoxDescription.TabIndex = 2;
        RichTextBoxDescription.Text = "";
        // 
        // panel1
        // 
        panel1.Controls.Add(ButtonConfirm);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 340);
        panel1.Name = "panel1";
        panel1.Size = new Size(600, 60);
        panel1.TabIndex = 5;
        // 
        // ButtonConfirm
        // 
        ButtonConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        ButtonConfirm.Location = new Point(470, 10);
        ButtonConfirm.Name = "ButtonConfirm";
        ButtonConfirm.Size = new Size(120, 40);
        ButtonConfirm.TabIndex = 0;
        ButtonConfirm.Text = "Confirm";
        ButtonConfirm.UseVisualStyleBackColor = true;
        ButtonConfirm.Click += ButtonConfirm_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(label1, 0, 2);
        tableLayoutPanel1.Controls.Add(RichTextBoxDescription, 0, 3);
        tableLayoutPanel1.Controls.Add(label2, 0, 0);
        tableLayoutPanel1.Controls.Add(TextBoxName, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(600, 340);
        tableLayoutPanel1.TabIndex = 6;
        // 
        // NewCategoryControl
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Controls.Add(panel1);
        DoubleBuffered = true;
        Name = "NewCategoryControl";
        Size = new Size(600, 400);
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TextBox TextBoxName;
    private RichTextBox RichTextBoxDescription;
    private Panel panel1;
    private Button ButtonConfirm;
    private TableLayoutPanel tableLayoutPanel1;
}
