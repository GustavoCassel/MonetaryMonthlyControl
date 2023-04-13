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
            ButtonCreateDB = new Button();
            PictureBoxLoading = new PictureBox();
            LabelLoading = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            MainContainer = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLoading).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainContainer).BeginInit();
            MainContainer.Panel1.SuspendLayout();
            MainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonCreateDB
            // 
            ButtonCreateDB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonCreateDB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCreateDB.Location = new Point(127, 476);
            ButtonCreateDB.Name = "ButtonCreateDB";
            ButtonCreateDB.Size = new Size(139, 53);
            ButtonCreateDB.TabIndex = 0;
            ButtonCreateDB.Text = "Configurar Banco";
            ButtonCreateDB.UseVisualStyleBackColor = true;
            ButtonCreateDB.Click += ButtonCreateDB_Click;
            // 
            // PictureBoxLoading
            // 
            PictureBoxLoading.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PictureBoxLoading.Image = Properties.Resources.loading;
            PictureBoxLoading.Location = new Point(6, 476);
            PictureBoxLoading.Name = "PictureBoxLoading";
            PictureBoxLoading.Size = new Size(100, 100);
            PictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxLoading.TabIndex = 1;
            PictureBoxLoading.TabStop = false;
            PictureBoxLoading.Visible = false;
            // 
            // LabelLoading
            // 
            LabelLoading.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelLoading.AutoSize = true;
            LabelLoading.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLoading.Location = new Point(127, 551);
            LabelLoading.Name = "LabelLoading";
            LabelLoading.Size = new Size(92, 25);
            LabelLoading.TabIndex = 2;
            LabelLoading.Text = "Loading...";
            LabelLoading.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(138, 47);
            button1.TabIndex = 3;
            button1.Text = "open manager";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(PictureBoxLoading);
            groupBox1.Controls.Add(LabelLoading);
            groupBox1.Controls.Add(ButtonCreateDB);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(28, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 582);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(55, 91);
            button2.Name = "button2";
            button2.Size = new Size(211, 77);
            button2.TabIndex = 4;
            button2.Text = "sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainContainer
            // 
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.Location = new Point(0, 0);
            MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            MainContainer.Panel1.Controls.Add(groupBox1);
            MainContainer.Size = new Size(1093, 615);
            MainContainer.SplitterDistance = 534;
            MainContainer.TabIndex = 5;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1093, 615);
            Controls.Add(MainContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monetary Monthly Control";
            ((System.ComponentModel.ISupportInitialize)PictureBoxLoading).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            MainContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainContainer).EndInit();
            MainContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonCreateDB;
        private PictureBox PictureBoxLoading;
        private Label LabelLoading;
        private Button button1;
        private GroupBox groupBox1;
        private SplitContainer MainContainer;
        private Button button2;
    }
}