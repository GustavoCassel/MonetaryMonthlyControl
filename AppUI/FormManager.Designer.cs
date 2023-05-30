namespace AppUI;

partial class FormManager
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
        Label label1;
        Label label2;
        Label label3;
        Label label4;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
        button1 = new Button();
        TextBoxValue = new TextBox();
        TextBoxDate = new TextBox();
        TextBoxDescription = new TextBox();
        ComboBoxCategory = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label1.ForeColor = SystemColors.ActiveCaptionText;
        label1.Location = new Point(77, 31);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(59, 25);
        label1.TabIndex = 1;
        label1.Text = "Value";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = SystemColors.ActiveCaptionText;
        label2.Location = new Point(83, 94);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(53, 25);
        label2.TabIndex = 3;
        label2.Text = "Date";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label3.ForeColor = SystemColors.ActiveCaptionText;
        label3.Location = new Point(52, 157);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(91, 25);
        label3.TabIndex = 5;
        label3.Text = "Category";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        label4.ForeColor = SystemColors.ActiveCaptionText;
        label4.Location = new Point(32, 216);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(110, 25);
        label4.TabIndex = 7;
        label4.Text = "Description";
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        button1.Location = new Point(725, 316);
        button1.Margin = new Padding(4);
        button1.Name = "button1";
        button1.Size = new Size(94, 52);
        button1.TabIndex = 4;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // TextBoxValue
        // 
        TextBoxValue.BackColor = Color.WhiteSmoke;
        TextBoxValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        TextBoxValue.Location = new Point(153, 30);
        TextBoxValue.Margin = new Padding(4);
        TextBoxValue.Name = "TextBoxValue";
        TextBoxValue.Size = new Size(350, 29);
        TextBoxValue.TabIndex = 0;
        TextBoxValue.Enter += TextBoxValue_Enter;
        TextBoxValue.Leave += TextBoxValue_Leave;
        // 
        // TextBoxDate
        // 
        TextBoxDate.BackColor = Color.WhiteSmoke;
        TextBoxDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        TextBoxDate.Location = new Point(153, 80);
        TextBoxDate.Margin = new Padding(4);
        TextBoxDate.Name = "TextBoxDate";
        TextBoxDate.Size = new Size(350, 29);
        TextBoxDate.TabIndex = 1;
        TextBoxDate.Enter += TextBoxDate_Enter;
        TextBoxDate.Leave += TextBoxDate_Leave;
        // 
        // TextBoxDescription
        // 
        TextBoxDescription.BackColor = Color.WhiteSmoke;
        TextBoxDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        TextBoxDescription.Location = new Point(153, 180);
        TextBoxDescription.Margin = new Padding(4);
        TextBoxDescription.Multiline = true;
        TextBoxDescription.Name = "TextBoxDescription";
        TextBoxDescription.Size = new Size(350, 143);
        TextBoxDescription.TabIndex = 3;
        TextBoxDescription.Enter += TextBoxDescription_Enter;
        TextBoxDescription.Leave += TextBoxDescription_Leave;
        // 
        // ComboBoxCategory
        // 
        ComboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        ComboBoxCategory.FormattingEnabled = true;
        ComboBoxCategory.Location = new Point(153, 130);
        ComboBoxCategory.Name = "ComboBoxCategory";
        ComboBoxCategory.Size = new Size(350, 29);
        ComboBoxCategory.TabIndex = 8;
        ComboBoxCategory.Enter += ComboBoxCategory_Enter;
        ComboBoxCategory.Leave += ComboBoxCategory_Leave;
        // 
        // FormManager
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Gray;
        ClientSize = new Size(832, 381);
        Controls.Add(ComboBoxCategory);
        Controls.Add(TextBoxDescription);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(TextBoxDate);
        Controls.Add(label1);
        Controls.Add(TextBoxValue);
        Controls.Add(button1);
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        Name = "FormManager";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FormManager";
        Click += FormManager_Click;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private TextBox TextBoxValue;
    private Label label2;
    private TextBox TextBoxDate;
    private Label label3;
    private Label label4;
    private RichTextBox RichTextBoxDescription;
    private TextBox TextBoxDescription;
    private ComboBox ComboBoxCategory;
}