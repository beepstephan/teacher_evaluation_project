namespace teacher_evaluation_project.Forms
{
    partial class FormHome
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
            pictureBox = new PictureBox();
            lblWelcome = new Label();
            panelCenter = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelCenter.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Image = Properties.Resources.imgLogo;
            pictureBox.InitialImage = null;
            pictureBox.Location = new Point(170, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(211, 189);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.Gainsboro;
            lblWelcome.Location = new Point(15, 213);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(520, 75);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Вітаємо вас у застосунку!\nВи можете дати коментар щодо лекцій викладачів та оцінити їх.";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelCenter
            // 
            panelCenter.Anchor = AnchorStyles.None;
            panelCenter.BackColor = Color.Transparent;
            panelCenter.Controls.Add(lblWelcome);
            panelCenter.Controls.Add(pictureBox);
            panelCenter.Location = new Point(39, 34);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(550, 293);
            panelCenter.TabIndex = 2;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(628, 341);
            Controls.Add(panelCenter);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormHome";
            Text = "Головна";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelCenter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Label lblWelcome;
        private Panel panelCenter;
    }
}