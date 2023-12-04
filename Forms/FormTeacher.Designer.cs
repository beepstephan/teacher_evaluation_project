namespace teacher_evaluation_project.Forms
{
    partial class FormTeacher
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
            this.photoTeacher = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnComment = new System.Windows.Forms.Button();
            this.lblGpa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // photoTeacher
            // 
            this.photoTeacher.BackColor = System.Drawing.Color.Gainsboro;
            this.photoTeacher.Location = new System.Drawing.Point(37, 27);
            this.photoTeacher.Name = "photoTeacher";
            this.photoTeacher.Size = new System.Drawing.Size(114, 128);
            this.photoTeacher.TabIndex = 0;
            this.photoTeacher.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(178, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ПІБ: ";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPosition.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPosition.Location = new System.Drawing.Point(178, 62);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 17);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Посада: ";
            // 
            // lblSubject
            // 
            this.lblSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubject.AutoEllipsis = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubject.Location = new System.Drawing.Point(178, 97);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(422, 20);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Дисципліни: ";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.Location = new System.Drawing.Point(178, 137);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(422, 17);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Опис: ";
            // 
            // btnComment
            // 
            this.btnComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnComment.Location = new System.Drawing.Point(429, 167);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(171, 41);
            this.btnComment.TabIndex = 5;
            this.btnComment.Text = "Дати відгук";
            this.btnComment.UseVisualStyleBackColor = false;
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGpa.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGpa.Location = new System.Drawing.Point(37, 190);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(154, 17);
            this.lblGpa.TabIndex = 6;
            this.lblGpa.Text = "Середні оцінка: 8.4/10";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(628, 341);
            this.Controls.Add(this.lblGpa);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.photoTeacher);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormTeacher";
            this.Text = "Викладач";
            ((System.ComponentModel.ISupportInitialize)(this.photoTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox photoTeacher;
        private Label lblName;
        private Label lblPosition;
        private Label lblSubject;
        private Label lblDescription;
        private Button btnComment;
        private Label lblGpa;
    }
}