namespace AppUI;

partial class Menu
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
        PictureBox pictureBox3;
        Panel PanelWindowButtons;
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        panel1 = new Panel();
        pictureBox1 = new PictureBox();
        label1 = new Label();
        label2 = new Label();
        panel2 = new Panel();
        pictureBox2 = new PictureBox();
        label3 = new Label();
        label4 = new Label();
        panel3 = new Panel();
        panel4 = new Panel();
        LabelVersion = new Label();
        PanelTitle = new Panel();
        LabelTitle = new Label();
        button1 = new Button();
        pictureBox3 = new PictureBox();
        PanelWindowButtons = new Panel();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        PanelTitle.SuspendLayout();
        PanelWindowButtons.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 225F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel1.Controls.Add(panel1, 0, 1);
        tableLayoutPanel1.Controls.Add(label2, 1, 1);
        tableLayoutPanel1.Controls.Add(panel2, 1, 2);
        tableLayoutPanel1.Controls.Add(label4, 0, 2);
        tableLayoutPanel1.Location = new Point(467, 275);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(743, 449);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 6;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(228, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(512, 24);
        tableLayoutPanel2.TabIndex = 4;
        // 
        // panel1
        // 
        panel1.Controls.Add(pictureBox1);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 33);
        panel1.Name = "panel1";
        panel1.Size = new Size(219, 79);
        panel1.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.None;
        pictureBox1.ErrorImage = null;
        pictureBox1.Image = Properties.Resources.book_512;
        pictureBox1.InitialImage = null;
        pictureBox1.Location = new Point(9, 15);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(48, 48);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(45, 21);
        label1.Name = "label1";
        label1.Size = new Size(171, 38);
        label1.TabIndex = 2;
        label1.Text = "Controle Monetário\r\nMensal";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Dock = DockStyle.Fill;
        label2.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(228, 30);
        label2.Name = "label2";
        label2.Size = new Size(512, 85);
        label2.TabIndex = 2;
        label2.Text = "Início";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel2
        // 
        panel2.Controls.Add(pictureBox2);
        panel2.Controls.Add(label3);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(228, 118);
        panel2.Name = "panel2";
        panel2.Size = new Size(512, 328);
        panel2.TabIndex = 3;
        // 
        // pictureBox2
        // 
        pictureBox2.Anchor = AnchorStyles.None;
        pictureBox2.ErrorImage = null;
        pictureBox2.Image = Properties.Resources.book_512;
        pictureBox2.InitialImage = null;
        pictureBox2.Location = new Point(20, 80);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(128, 128);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.None;
        label3.AutoSize = true;
        label3.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(162, 114);
        label3.Name = "label3";
        label3.Size = new Size(303, 68);
        label3.TabIndex = 2;
        label3.Text = "Controle Monetário\r\nMensal";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(3, 115);
        label4.Name = "label4";
        label4.Size = new Size(29, 32);
        label4.TabIndex = 4;
        label4.Text = "X";
        label4.TextAlign = ContentAlignment.MiddleCenter;
        label4.Click += label4_Click;
        // 
        // panel3
        // 
        panel3.Controls.Add(panel4);
        panel3.Dock = DockStyle.Left;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(225, 769);
        panel3.TabIndex = 1;
        // 
        // panel4
        // 
        panel4.Controls.Add(pictureBox3);
        panel4.Controls.Add(LabelVersion);
        panel4.Dock = DockStyle.Top;
        panel4.Location = new Point(0, 0);
        panel4.Name = "panel4";
        panel4.Size = new Size(225, 85);
        panel4.TabIndex = 0;
        // 
        // pictureBox3
        // 
        pictureBox3.Anchor = AnchorStyles.None;
        pictureBox3.ErrorImage = null;
        pictureBox3.Image = Properties.Resources.book_512;
        pictureBox3.InitialImage = null;
        pictureBox3.Location = new Point(13, 18);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(48, 48);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 5;
        pictureBox3.TabStop = false;
        // 
        // LabelVersion
        // 
        LabelVersion.Anchor = AnchorStyles.None;
        LabelVersion.AutoSize = true;
        LabelVersion.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
        LabelVersion.Location = new Point(76, 32);
        LabelVersion.Name = "LabelVersion";
        LabelVersion.Size = new Size(72, 19);
        LabelVersion.TabIndex = 4;
        LabelVersion.Text = "VERSION";
        LabelVersion.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanelTitle
        // 
        PanelTitle.Controls.Add(LabelTitle);
        PanelTitle.Dock = DockStyle.Top;
        PanelTitle.Location = new Point(225, 30);
        PanelTitle.Name = "PanelTitle";
        PanelTitle.Size = new Size(1058, 55);
        PanelTitle.TabIndex = 2;
        // 
        // LabelTitle
        // 
        LabelTitle.Dock = DockStyle.Fill;
        LabelTitle.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
        LabelTitle.Location = new Point(0, 0);
        LabelTitle.Name = "LabelTitle";
        LabelTitle.Size = new Size(1058, 55);
        LabelTitle.TabIndex = 3;
        LabelTitle.Text = "Início";
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanelWindowButtons
        // 
        PanelWindowButtons.Controls.Add(button1);
        PanelWindowButtons.Dock = DockStyle.Top;
        PanelWindowButtons.Location = new Point(225, 0);
        PanelWindowButtons.Name = "PanelWindowButtons";
        PanelWindowButtons.Size = new Size(1058, 30);
        PanelWindowButtons.TabIndex = 0;
        // 
        // button1
        // 
        button1.BackColor = Color.Red;
        button1.Cursor = Cursors.Hand;
        button1.DialogResult = DialogResult.OK;
        button1.Dock = DockStyle.Right;
        button1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        button1.ForeColor = Color.Black;
        button1.Location = new Point(988, 0);
        button1.Name = "button1";
        button1.Size = new Size(70, 30);
        button1.TabIndex = 3;
        button1.Text = "X";
        button1.UseVisualStyleBackColor = false;
        // 
        // Menu
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(31, 30, 68);
        ClientSize = new Size(1283, 769);
        Controls.Add(PanelTitle);
        Controls.Add(PanelWindowButtons);
        Controls.Add(panel3);
        Controls.Add(tableLayoutPanel1);
        DoubleBuffered = true;
        Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Margin = new Padding(4);
        Name = "Menu";
        SizeGripStyle = SizeGripStyle.Show;
        StartPosition = FormStartPosition.CenterScreen;
        KeyDown += Menu_KeyDown;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        panel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        PanelTitle.ResumeLayout(false);
        PanelWindowButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private Label label1;
    private Label label2;
    private Panel panel2;
    private PictureBox pictureBox2;
    private Label label3;
    private PictureBox pictureBox1;
    private Label label4;
    private TableLayoutPanel tableLayoutPanel2;
    private Panel panel3;
    private Panel panel4;
    private PictureBox pictureBox3;
    private Label LabelVersion;
    private Panel PanelTitle;
    private Label LabelTitle;
    private Button button1;
}