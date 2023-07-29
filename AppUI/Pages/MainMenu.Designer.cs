namespace AppUI;

partial class MainMenu
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
        PictureBoxLogo = new PictureBox();
        LabelText = new Label();
        ((System.ComponentModel.ISupportInitialize)PictureBoxLogo).BeginInit();
        SuspendLayout();
        // 
        // PictureBoxLogo
        // 
        PictureBoxLogo.Anchor = AnchorStyles.None;
        PictureBoxLogo.Location = new Point(3, 3);
        PictureBoxLogo.Name = "PictureBoxLogo";
        PictureBoxLogo.Size = new Size(128, 128);
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
        PictureBoxLogo.TabIndex = 0;
        PictureBoxLogo.TabStop = false;
        // 
        // LabelText
        // 
        LabelText.Anchor = AnchorStyles.None;
        LabelText.AutoSize = true;
        LabelText.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        LabelText.Location = new Point(137, 3);
        LabelText.Name = "LabelText";
        LabelText.Size = new Size(191, 34);
        LabelText.TabIndex = 1;
        LabelText.Text = "logger text";
        LabelText.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(LabelText);
        Controls.Add(PictureBoxLogo);
        DoubleBuffered = true;
        Margin = new Padding(4);
        Name = "MainMenu";
        Size = new Size(450, 200);
        ((System.ComponentModel.ISupportInitialize)PictureBoxLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox PictureBoxLogo;
    private Label LabelText;
}
