namespace teacher_evaluation_project.Forms
{
    partial class FormDev
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
            lblAuthor1 = new Label();
            lblAuthor3 = new Label();
            lblAuthor4 = new Label();
            lblAuthor5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAuthor1
            // 
            lblAuthor1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor1.ForeColor = Color.Gainsboro;
            lblAuthor1.Location = new Point(3, 188);
            lblAuthor1.Name = "lblAuthor1";
            lblAuthor1.Size = new Size(593, 50);
            lblAuthor1.TabIndex = 0;
            lblAuthor1.Text = "Степанов Ігор -> класи, архітектура";
            lblAuthor1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor3
            // 
            lblAuthor3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor3.ForeColor = Color.Gainsboro;
            lblAuthor3.Location = new Point(3, 125);
            lblAuthor3.Name = "lblAuthor3";
            lblAuthor3.Size = new Size(593, 50);
            lblAuthor3.TabIndex = 2;
            lblAuthor3.Text = "Пастушенко Микита -> дані";
            lblAuthor3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor4
            // 
            lblAuthor4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor4.ForeColor = Color.Gainsboro;
            lblAuthor4.Location = new Point(3, 64);
            lblAuthor4.Name = "lblAuthor4";
            lblAuthor4.Size = new Size(593, 50);
            lblAuthor4.TabIndex = 3;
            lblAuthor4.Text = "Гоголенко Дмитро -> інтерфейс";
            lblAuthor4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAuthor5
            // 
            lblAuthor5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor5.ForeColor = Color.Gainsboro;
            lblAuthor5.Location = new Point(3, 0);
            lblAuthor5.Name = "lblAuthor5";
            lblAuthor5.Size = new Size(593, 50);
            lblAuthor5.TabIndex = 4;
            lblAuthor5.Text = "Борисенко Володимир -> Обробка  вин. ситуацій";
            lblAuthor5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(3, 251);
            label1.Name = "label1";
            label1.Size = new Size(593, 50);
            label1.TabIndex = 1;
            label1.Text = "Федишен Станіслав -> алгоритми";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(lblAuthor5);
            panel1.Controls.Add(lblAuthor1);
            panel1.Controls.Add(lblAuthor4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblAuthor3);
            panel1.Location = new Point(17, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 308);
            panel1.TabIndex = 5;
            // 
            // FormDev
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormDev";
            Text = "Розробники";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblAuthor1;
        private Label lblAuthor3;
        private Label lblAuthor4;
        private Label lblAuthor5;
        private Label label1;
        private Panel panel1;
    }
}