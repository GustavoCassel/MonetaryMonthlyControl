namespace MonetaryMonthlyControl;

partial class MainMenu
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
        labelTitle = new Label();
        panelMenu = new Panel();
        panelChangeColor = new Panel();
        ButtonChangeColor = new Button();
        button4 = new Button();
        button3 = new Button();
        button2 = new Button();
        ButtonVisualize = new Button();
        panelLogo = new Panel();
        pictureBox1 = new PictureBox();
        label1 = new Label();
        panelTitle = new Panel();
        panelContent = new Panel();
        panelMenu.SuspendLayout();
        panelChangeColor.SuspendLayout();
        panelLogo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panelTitle.SuspendLayout();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.Anchor = AnchorStyles.None;
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        labelTitle.Location = new Point(296, 27);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(73, 30);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Home";
        // 
        // panelMenu
        // 
        panelMenu.Controls.Add(panelChangeColor);
        panelMenu.Controls.Add(button4);
        panelMenu.Controls.Add(button3);
        panelMenu.Controls.Add(button2);
        panelMenu.Controls.Add(ButtonVisualize);
        panelMenu.Controls.Add(panelLogo);
        panelMenu.Dock = DockStyle.Left;
        panelMenu.Location = new Point(0, 0);
        panelMenu.Name = "panelMenu";
        panelMenu.Size = new Size(309, 578);
        panelMenu.TabIndex = 0;
        // 
        // panelChangeColor
        // 
        panelChangeColor.Controls.Add(ButtonChangeColor);
        panelChangeColor.Dock = DockStyle.Bottom;
        panelChangeColor.Location = new Point(0, 520);
        panelChangeColor.Name = "panelChangeColor";
        panelChangeColor.Size = new Size(309, 58);
        panelChangeColor.TabIndex = 6;
        // 
        // ButtonChangeColor
        // 
        ButtonChangeColor.Dock = DockStyle.Fill;
        ButtonChangeColor.FlatAppearance.BorderSize = 0;
        ButtonChangeColor.FlatStyle = FlatStyle.Flat;
        ButtonChangeColor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        ButtonChangeColor.ImageAlign = ContentAlignment.MiddleLeft;
        ButtonChangeColor.Location = new Point(0, 0);
        ButtonChangeColor.Name = "ButtonChangeColor";
        ButtonChangeColor.Padding = new Padding(15, 0, 0, 0);
        ButtonChangeColor.Size = new Size(309, 58);
        ButtonChangeColor.TabIndex = 5;
        ButtonChangeColor.Text = "Light Theme";
        ButtonChangeColor.TextAlign = ContentAlignment.MiddleLeft;
        ButtonChangeColor.TextImageRelation = TextImageRelation.ImageBeforeText;
        ButtonChangeColor.UseVisualStyleBackColor = false;
        ButtonChangeColor.Click += ButtonChangeColor_Click;
        // 
        // button4
        // 
        button4.Dock = DockStyle.Top;
        button4.FlatAppearance.BorderSize = 0;
        button4.FlatStyle = FlatStyle.Flat;
        button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        button4.Location = new Point(0, 260);
        button4.Name = "button4";
        button4.Size = new Size(309, 60);
        button4.TabIndex = 4;
        button4.Text = "button4";
        button4.TextAlign = ContentAlignment.MiddleLeft;
        button4.TextImageRelation = TextImageRelation.ImageBeforeText;
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button3
        // 
        button3.Dock = DockStyle.Top;
        button3.FlatAppearance.BorderSize = 0;
        button3.FlatStyle = FlatStyle.Flat;
        button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        button3.Location = new Point(0, 200);
        button3.Name = "button3";
        button3.Size = new Size(309, 60);
        button3.TabIndex = 3;
        button3.Text = "button3";
        button3.TextAlign = ContentAlignment.MiddleLeft;
        button3.TextImageRelation = TextImageRelation.ImageBeforeText;
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.Dock = DockStyle.Top;
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = FlatStyle.Flat;
        button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        button2.Location = new Point(0, 140);
        button2.Name = "button2";
        button2.Size = new Size(309, 60);
        button2.TabIndex = 2;
        button2.Text = "button2";
        button2.TextAlign = ContentAlignment.MiddleLeft;
        button2.TextImageRelation = TextImageRelation.ImageBeforeText;
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // ButtonVisualize
        // 
        ButtonVisualize.Dock = DockStyle.Top;
        ButtonVisualize.FlatAppearance.BorderSize = 0;
        ButtonVisualize.FlatStyle = FlatStyle.Flat;
        ButtonVisualize.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        ButtonVisualize.Location = new Point(0, 80);
        ButtonVisualize.Name = "ButtonVisualize";
        ButtonVisualize.Size = new Size(309, 60);
        ButtonVisualize.TabIndex = 1;
        ButtonVisualize.Text = "Visualize Relatory";
        ButtonVisualize.TextAlign = ContentAlignment.MiddleLeft;
        ButtonVisualize.TextImageRelation = TextImageRelation.ImageBeforeText;
        ButtonVisualize.UseVisualStyleBackColor = true;
        ButtonVisualize.Click += ButtonVisualize_Click;
        // 
        // panelLogo
        // 
        panelLogo.Controls.Add(pictureBox1);
        panelLogo.Controls.Add(label1);
        panelLogo.Dock = DockStyle.Top;
        panelLogo.Location = new Point(0, 0);
        panelLogo.Name = "panelLogo";
        panelLogo.Size = new Size(309, 80);
        panelLogo.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.None;
        pictureBox1.ErrorImage = null;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.InitialImage = null;
        pictureBox1.Location = new Point(22, 15);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(48, 48);
        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(87, 27);
        label1.Name = "label1";
        label1.Size = new Size(141, 21);
        label1.TabIndex = 0;
        label1.Text = "Monetary Control";
        // 
        // panelTitle
        // 
        panelTitle.Controls.Add(labelTitle);
        panelTitle.Dock = DockStyle.Top;
        panelTitle.Location = new Point(309, 0);
        panelTitle.Name = "panelTitle";
        panelTitle.Size = new Size(745, 80);
        panelTitle.TabIndex = 1;
        // 
        // panelContent
        // 
        panelContent.Dock = DockStyle.Fill;
        panelContent.Location = new Point(309, 80);
        panelContent.Name = "panelContent";
        panelContent.Size = new Size(745, 498);
        panelContent.TabIndex = 2;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1054, 578);
        Controls.Add(panelContent);
        Controls.Add(panelTitle);
        Controls.Add(panelMenu);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MainMenu";
        SizeGripStyle = SizeGripStyle.Show;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Monetary Monthly Control";
        panelMenu.ResumeLayout(false);
        panelChangeColor.ResumeLayout(false);
        panelLogo.ResumeLayout(false);
        panelLogo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panelTitle.ResumeLayout(false);
        panelTitle.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panelMenu;
    private Panel panelLogo;
    private Button ButtonVisualize;
    private Button ButtonChangeColor;
    private Button button4;
    private Button button3;
    private Button button2;
    private Panel panelTitle;
    private Label labelTitle;
    private Panel panelChangeColor;
    private PictureBox pictureBox1;
    private Label label1;
    private Panel panelContent;
}