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
            photoTeacher = new PictureBox();
            lblName = new Label();
            lblPosition = new Label();
            lblSubject = new Label();
            lblDescription = new Label();
            btnComment = new Button();
            lblGpa = new Label();
            ((System.ComponentModel.ISupportInitialize)photoTeacher).BeginInit();
            SuspendLayout();
            // 
            // photoTeacher
            // 
            photoTeacher.BackColor = Color.Gainsboro;
            photoTeacher.Location = new Point(37, 27);
            photoTeacher.Name = "photoTeacher";
            photoTeacher.Size = new Size(114, 128);
            photoTeacher.SizeMode = PictureBoxSizeMode.StretchImage;
            photoTeacher.TabIndex = 0;
            photoTeacher.TabStop = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Gainsboro;
            lblName.Location = new Point(178, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(422, 22);
            lblName.TabIndex = 1;
            lblName.Text = "ПІБ: ";
            // 
            // lblPosition
            // 
            lblPosition.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosition.ForeColor = Color.Gainsboro;
            lblPosition.Location = new Point(178, 62);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(422, 22);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "Посада: ";
            // 
            // lblSubject
            // 
            lblSubject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubject.AutoEllipsis = true;
            lblSubject.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.ForeColor = Color.Gainsboro;
            lblSubject.Location = new Point(178, 97);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(422, 22);
            lblSubject.TabIndex = 3;
            lblSubject.Text = "Дисципліни: ";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoEllipsis = true;
            lblDescription.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Gainsboro;
            lblDescription.Location = new Point(178, 137);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(422, 22);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Опис: ";
            // 
            // btnComment
            // 
            btnComment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnComment.BackColor = Color.FromArgb(30, 30, 65);
            btnComment.FlatStyle = FlatStyle.Flat;
            btnComment.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnComment.ForeColor = Color.Gainsboro;
            btnComment.Location = new Point(429, 167);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(171, 41);
            btnComment.TabIndex = 5;
            btnComment.Text = "Дати відгук";
            btnComment.UseVisualStyleBackColor = false;
            btnComment.Click += btnComment_Click;
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGpa.ForeColor = Color.Gainsboro;
            lblGpa.Location = new Point(37, 190);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(154, 17);
            lblGpa.TabIndex = 6;
            lblGpa.Text = "Середні оцінка: 8.4/10";
            // 
            // FormTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(lblGpa);
            Controls.Add(btnComment);
            Controls.Add(lblDescription);
            Controls.Add(lblSubject);
            Controls.Add(lblPosition);
            Controls.Add(lblName);
            Controls.Add(photoTeacher);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormTeacher";
            Text = "Викладач";
            ((System.ComponentModel.ISupportInitialize)photoTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
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