﻿namespace AppUI;

partial class FormInsertEntry
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
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(161, 185);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(252, 26);
        textBox1.TabIndex = 0;
        // 
        // FormInsertEntry
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(textBox1);
        DoubleBuffered = true;
        Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4);
        Name = "FormInsertEntry";
        Size = new Size(808, 471);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBox1;
}
