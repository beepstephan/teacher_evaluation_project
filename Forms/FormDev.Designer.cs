namespace teacher_evaluation_project.Forms {
    partial class FormDev {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblAuthor1 = new Label();
            lblAuthor2 = new Label();
            lblAuthor3 = new Label();
            lblAuthor4 = new Label();
            lblAuthor5 = new Label();
            SuspendLayout();
            // 
            // lblAuthor1
            // 
            lblAuthor1.AutoSize = true;
            lblAuthor1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor1.ForeColor = Color.Gainsboro;
            lblAuthor1.Location = new Point(46, 43);
            lblAuthor1.Name = "lblAuthor1";
            lblAuthor1.Size = new Size(99, 17);
            lblAuthor1.TabIndex = 0;
            lblAuthor1.Text = "Степанов Ігор";
            // 
            // lblAuthor2
            // 
            lblAuthor2.AutoSize = true;
            lblAuthor2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor2.ForeColor = Color.Gainsboro;
            lblAuthor2.Location = new Point(46, 85);
            lblAuthor2.Name = "lblAuthor2";
            lblAuthor2.Size = new Size(141, 17);
            lblAuthor2.TabIndex = 1;
            lblAuthor2.Text = "Федишен Станіслав";
            // 
            // lblAuthor3
            // 
            lblAuthor3.AutoSize = true;
            lblAuthor3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor3.ForeColor = Color.Gainsboro;
            lblAuthor3.Location = new Point(46, 128);
            lblAuthor3.Name = "lblAuthor3";
            lblAuthor3.Size = new Size(142, 17);
            lblAuthor3.TabIndex = 2;
            lblAuthor3.Text = "Пастушенко Микита";
            // 
            // lblAuthor4
            // 
            lblAuthor4.AutoSize = true;
            lblAuthor4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor4.ForeColor = Color.Gainsboro;
            lblAuthor4.Location = new Point(46, 171);
            lblAuthor4.Name = "lblAuthor4";
            lblAuthor4.Size = new Size(131, 17);
            lblAuthor4.TabIndex = 3;
            lblAuthor4.Text = "Гоголенко Дмитро";
            // 
            // lblAuthor5
            // 
            lblAuthor5.AutoSize = true;
            lblAuthor5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAuthor5.ForeColor = Color.Gainsboro;
            lblAuthor5.Location = new Point(46, 213);
            lblAuthor5.Name = "lblAuthor5";
            lblAuthor5.Size = new Size(157, 17);
            lblAuthor5.TabIndex = 4;
            lblAuthor5.Text = "Борисенко Володимир";
            // 
            // FormDev
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 322);
            Controls.Add(lblAuthor5);
            Controls.Add(lblAuthor4);
            Controls.Add(lblAuthor3);
            Controls.Add(lblAuthor2);
            Controls.Add(lblAuthor1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormDev";
            Text = "Розробники";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuthor1;
        private Label lblAuthor2;
        private Label lblAuthor3;
        private Label lblAuthor4;
        private Label lblAuthor5;
    }
}