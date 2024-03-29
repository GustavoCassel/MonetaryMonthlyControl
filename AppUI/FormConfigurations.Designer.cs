﻿namespace AppUI;

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
        LabelTitle = new Label();
        MainTableLayoutPanel = new TableLayoutPanel();
        ButtonReturn = new Button();
        ComboBoxLanguages = new ComboBox();
        ComboBoxThemes = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        button1 = new Button();
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
        LabelTitle.Text = "Configurations";
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
        button1.BackColor = Color.FromArgb(210, 233, 233);
        button1.Cursor = Cursors.Hand;
        button1.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(202, 237, 255);
        button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 223, 223);
        button1.FlatStyle = FlatStyle.Flat;
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
        BackColor = Color.FromArgb(227, 244, 244);
        ClientSize = new Size(1184, 661);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(ComboBoxThemes);
        Controls.Add(ComboBoxLanguages);
        Controls.Add(MainTableLayoutPanel);
        ForeColor = Color.Black;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        MinimumSize = new Size(800, 405);
        Name = "FormConfigurations";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Configurations";
        MainTableLayoutPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label LabelTitle;
    private TableLayoutPanel MainTableLayoutPanel;
    private Button ButtonReturn;
    private ComboBox ComboBoxLanguages;
    private ComboBox ComboBoxThemes;
    private Label label1;
    private Label label2;
    private Button button1;
}