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
            this.lblAuthor1 = new System.Windows.Forms.Label();
            this.lblAuthor3 = new System.Windows.Forms.Label();
            this.lblAuthor4 = new System.Windows.Forms.Label();
            this.lblAuthor5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuthor1
            // 
            this.lblAuthor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAuthor1.Location = new System.Drawing.Point(3, 188);
            this.lblAuthor1.Name = "lblAuthor1";
            this.lblAuthor1.Size = new System.Drawing.Size(593, 50);
            this.lblAuthor1.TabIndex = 0;
            this.lblAuthor1.Text = "Степанов Ігор -> класи, архітектура";
            this.lblAuthor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor3
            // 
            this.lblAuthor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor3.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAuthor3.Location = new System.Drawing.Point(3, 125);
            this.lblAuthor3.Name = "lblAuthor3";
            this.lblAuthor3.Size = new System.Drawing.Size(593, 50);
            this.lblAuthor3.TabIndex = 2;
            this.lblAuthor3.Text = "Пастушенко Микита -> дані";
            this.lblAuthor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor4
            // 
            this.lblAuthor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor4.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAuthor4.Location = new System.Drawing.Point(3, 64);
            this.lblAuthor4.Name = "lblAuthor4";
            this.lblAuthor4.Size = new System.Drawing.Size(593, 50);
            this.lblAuthor4.TabIndex = 3;
            this.lblAuthor4.Text = "Гоголенко Дмитро -> інтерфейс";
            this.lblAuthor4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor5
            // 
            this.lblAuthor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthor5.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAuthor5.Location = new System.Drawing.Point(3, 0);
            this.lblAuthor5.Name = "lblAuthor5";
            this.lblAuthor5.Size = new System.Drawing.Size(593, 50);
            this.lblAuthor5.TabIndex = 4;
            this.lblAuthor5.Text = "Борисенко Володимир -> Обробка  вин. ситуацій";
            this.lblAuthor5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Федишен Станіслав -> алгоритми";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblAuthor5);
            this.panel1.Controls.Add(this.lblAuthor1);
            this.panel1.Controls.Add(this.lblAuthor4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAuthor3);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 308);
            this.panel1.TabIndex = 5;
            // 
            // FormDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(628, 322);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormDev";
            this.Text = "Розробники";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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