namespace AppUI;

partial class Configurations
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
        label1 = new Label();
        ButtonApplyChanges = new Button();
        label2 = new Label();
        ComboBoxLanguage = new ComboBox();
        ComboBoxThemes = new ComboBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(39, 31);
        label1.Name = "label1";
        label1.Size = new Size(63, 19);
        label1.TabIndex = 2;
        label1.Text = "Idioma";
        // 
        // ButtonApplyChanges
        // 
        ButtonApplyChanges.Location = new Point(303, 243);
        ButtonApplyChanges.Name = "ButtonApplyChanges";
        ButtonApplyChanges.Size = new Size(180, 40);
        ButtonApplyChanges.TabIndex = 4;
        ButtonApplyChanges.Text = "Aplicar Alterações";
        ButtonApplyChanges.UseVisualStyleBackColor = true;
        ButtonApplyChanges.Click += ButtonApplyChanges_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(39, 126);
        label2.Name = "label2";
        label2.Size = new Size(45, 19);
        label2.TabIndex = 5;
        label2.Text = "Tema";
        // 
        // ComboBoxLanguage
        // 
        ComboBoxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
        ComboBoxLanguage.FormattingEnabled = true;
        ComboBoxLanguage.Location = new Point(39, 76);
        ComboBoxLanguage.Name = "ComboBoxLanguage";
        ComboBoxLanguage.Size = new Size(293, 27);
        ComboBoxLanguage.TabIndex = 6;
        // 
        // ComboBoxThemes
        // 
        ComboBoxThemes.DropDownStyle = ComboBoxStyle.DropDownList;
        ComboBoxThemes.FormattingEnabled = true;
        ComboBoxThemes.Location = new Point(39, 171);
        ComboBoxThemes.Name = "ComboBoxThemes";
        ComboBoxThemes.Size = new Size(293, 27);
        ComboBoxThemes.TabIndex = 7;
        // 
        // Configurations
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(ComboBoxThemes);
        Controls.Add(ComboBoxLanguage);
        Controls.Add(label2);
        Controls.Add(ButtonApplyChanges);
        Controls.Add(label1);
        DoubleBuffered = true;
        Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4);
        Name = "Configurations";
        Size = new Size(500, 300);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Label label1;
    private Button ButtonLightTheme;
    private Button ButtonApplyChanges;
    private Label label2;
    private ComboBox ComboBoxLanguage;
    private ComboBox ComboBoxThemes;
}
