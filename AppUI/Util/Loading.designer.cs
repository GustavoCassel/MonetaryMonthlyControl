using AppUI.Properties;

namespace AppUI.Util;

partial class Loading
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
        LabelLoading = new Label();
        PictureBoxLoading = new PictureBox();
        ButtonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)PictureBoxLoading).BeginInit();
        SuspendLayout();
        // 
        // LabelLoading
        // 
        LabelLoading.Anchor = AnchorStyles.None;
        LabelLoading.AutoSize = true;
        LabelLoading.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        LabelLoading.Location = new Point(113, 41);
        LabelLoading.Margin = new Padding(4, 0, 4, 0);
        LabelLoading.Name = "LabelLoading";
        LabelLoading.Size = new Size(119, 32);
        LabelLoading.TabIndex = 1;
        LabelLoading.Text = "Loading";
        // 
        // PictureBoxLoading
        // 
        PictureBoxLoading.Anchor = AnchorStyles.None;
        PictureBoxLoading.Image = Resources.loading_gif;
        PictureBoxLoading.Location = new Point(5, 5);
        PictureBoxLoading.Margin = new Padding(4);
        PictureBoxLoading.Name = "PictureBoxLoading";
        PictureBoxLoading.Size = new Size(100, 100);
        PictureBoxLoading.SizeMode = PictureBoxSizeMode.StretchImage;
        PictureBoxLoading.TabIndex = 0;
        PictureBoxLoading.TabStop = false;
        // 
        // ButtonCancel
        // 
        ButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        ButtonCancel.BackColor = Color.IndianRed;
        ButtonCancel.Cursor = Cursors.Hand;
        ButtonCancel.FlatAppearance.BorderColor = Color.FromArgb(196, 223, 223);
        ButtonCancel.FlatAppearance.MouseOverBackColor = Color.Red;
        ButtonCancel.FlatStyle = FlatStyle.Flat;
        ButtonCancel.Location = new Point(243, 61);
        ButtonCancel.Name = "ButtonCancel";
        ButtonCancel.Size = new Size(100, 40);
        ButtonCancel.TabIndex = 2;
        ButtonCancel.Text = "Cancel";
        ButtonCancel.UseVisualStyleBackColor = false;
        ButtonCancel.Click += ButtonCancel_Click;
        // 
        // Loading
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Transparent;
        BackgroundImageLayout = ImageLayout.Stretch;
        Controls.Add(ButtonCancel);
        Controls.Add(LabelLoading);
        Controls.Add(PictureBoxLoading);
        DoubleBuffered = true;
        Margin = new Padding(4);
        Name = "Loading";
        Size = new Size(350, 110);
        ((System.ComponentModel.ISupportInitialize)PictureBoxLoading).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox PictureBoxLoading;
    private Label LabelLoading;
    private Button ButtonCancel;
}
