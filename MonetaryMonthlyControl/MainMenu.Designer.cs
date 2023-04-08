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
            ((System.ComponentModel.ISupportInitialize)PictureBoxLoading).BeginInit();
            SuspendLayout();
            // 
            // ButtonCreateDB
            // 
            ButtonCreateDB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCreateDB.Location = new Point(381, 197);
            ButtonCreateDB.Name = "ButtonCreateDB";
            ButtonCreateDB.Size = new Size(139, 53);
            ButtonCreateDB.TabIndex = 0;
            ButtonCreateDB.Text = "Configurar Banco";
            ButtonCreateDB.UseVisualStyleBackColor = true;
            ButtonCreateDB.Click += ButtonCreateDB_Click;
            // 
            // PictureBoxLoading
            // 
            PictureBoxLoading.Image = Properties.Resources.loading;
            PictureBoxLoading.Location = new Point(12, 458);
            PictureBoxLoading.Name = "PictureBoxLoading";
            PictureBoxLoading.Size = new Size(100, 100);
            PictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxLoading.TabIndex = 1;
            PictureBoxLoading.TabStop = false;
            PictureBoxLoading.Visible = false;
            // 
            // LabelLoading
            // 
            LabelLoading.AutoSize = true;
            LabelLoading.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLoading.Location = new Point(118, 491);
            LabelLoading.Name = "LabelLoading";
            LabelLoading.Size = new Size(92, 25);
            LabelLoading.TabIndex = 2;
            LabelLoading.Text = "Loading...";
            LabelLoading.Visible = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 570);
            Controls.Add(LabelLoading);
            Controls.Add(PictureBoxLoading);
            Controls.Add(ButtonCreateDB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureBoxLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCreateDB;
        private PictureBox PictureBoxLoading;
        private Label LabelLoading;
    }
}