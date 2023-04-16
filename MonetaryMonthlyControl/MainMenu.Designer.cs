namespace MonetaryMonthlyControl
{
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
            ButtonLogo = new Button();
            panelTitle = new Panel();
            colorDialog = new ColorDialog();
            panelMenu.SuspendLayout();
            panelChangeColor.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(352, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(73, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Home";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(80, 80, 141);
            panelMenu.Controls.Add(panelChangeColor);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(ButtonVisualize);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 561);
            panelMenu.TabIndex = 0;
            // 
            // panelChangeColor
            // 
            panelChangeColor.Controls.Add(ButtonChangeColor);
            panelChangeColor.Dock = DockStyle.Bottom;
            panelChangeColor.Location = new Point(0, 503);
            panelChangeColor.Name = "panelChangeColor";
            panelChangeColor.Size = new Size(250, 58);
            panelChangeColor.TabIndex = 6;
            // 
            // ButtonChangeColor
            // 
            ButtonChangeColor.BackColor = Color.FromArgb(51, 51, 105);
            ButtonChangeColor.Dock = DockStyle.Fill;
            ButtonChangeColor.FlatAppearance.BorderSize = 0;
            ButtonChangeColor.FlatStyle = FlatStyle.Flat;
            ButtonChangeColor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonChangeColor.ForeColor = Color.Gainsboro;
            ButtonChangeColor.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonChangeColor.Location = new Point(0, 0);
            ButtonChangeColor.Name = "ButtonChangeColor";
            ButtonChangeColor.Padding = new Padding(15, 0, 0, 0);
            ButtonChangeColor.Size = new Size(250, 58);
            ButtonChangeColor.TabIndex = 5;
            ButtonChangeColor.Text = "Dark Theme";
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
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(0, 260);
            button4.Name = "button4";
            button4.Size = new Size(250, 60);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(0, 200);
            button3.Name = "button3";
            button3.Size = new Size(250, 60);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(0, 140);
            button2.Name = "button2";
            button2.Size = new Size(250, 60);
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
            ButtonVisualize.ForeColor = Color.Gainsboro;
            ButtonVisualize.Location = new Point(0, 80);
            ButtonVisualize.Name = "ButtonVisualize";
            ButtonVisualize.Size = new Size(250, 60);
            ButtonVisualize.TabIndex = 1;
            ButtonVisualize.Text = "Visualize Relatory";
            ButtonVisualize.TextAlign = ContentAlignment.MiddleLeft;
            ButtonVisualize.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonVisualize.UseVisualStyleBackColor = true;
            ButtonVisualize.Click += ButtonVisualize_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(51, 51, 105);
            panelLogo.Controls.Add(ButtonLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 80);
            panelLogo.TabIndex = 0;
            // 
            // ButtonLogo
            // 
            ButtonLogo.Dock = DockStyle.Fill;
            ButtonLogo.FlatAppearance.BorderSize = 0;
            ButtonLogo.FlatStyle = FlatStyle.Flat;
            ButtonLogo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogo.ForeColor = Color.Gainsboro;
            ButtonLogo.Image = (Image)resources.GetObject("ButtonLogo.Image");
            ButtonLogo.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonLogo.Location = new Point(0, 0);
            ButtonLogo.Name = "ButtonLogo";
            ButtonLogo.Padding = new Padding(15, 0, 0, 0);
            ButtonLogo.Size = new Size(250, 80);
            ButtonLogo.TabIndex = 5;
            ButtonLogo.Text = "    Monetary Control";
            ButtonLogo.TextAlign = ContentAlignment.MiddleLeft;
            ButtonLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonLogo.UseVisualStyleBackColor = true;
            ButtonLogo.Click += ButtonLogo_Click;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(250, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(834, 80);
            panelTitle.TabIndex = 1;
            // 
            // colorDialog
            // 
            colorDialog.AnyColor = true;
            colorDialog.FullOpen = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
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
        private ColorDialog colorDialog;
        private Panel panelChangeColor;
        protected Button ButtonLogo;
    }
}