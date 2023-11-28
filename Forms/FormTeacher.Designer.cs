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
            lblDepartment = new Label();
            lblSubject = new Label();
            lblActivity = new Label();
            btnComment = new Button();
            lblGpa = new Label();
            listComments = new ListView();
            ((System.ComponentModel.ISupportInitialize)photoTeacher).BeginInit();
            SuspendLayout();
            // 
            // photoTeacher
            // 
            photoTeacher.BackColor = Color.Gainsboro;
            photoTeacher.Location = new Point(37, 27);
            photoTeacher.Name = "photoTeacher";
            photoTeacher.Size = new Size(114, 128);
            photoTeacher.TabIndex = 0;
            photoTeacher.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Gainsboro;
            lblName.Location = new Point(178, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(30, 17);
            lblName.TabIndex = 1;
            lblName.Text = "ПІБ";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartment.ForeColor = Color.Gainsboro;
            lblDepartment.Location = new Point(178, 62);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(68, 17);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Кафедра";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.ForeColor = Color.Gainsboro;
            lblSubject.Location = new Point(178, 100);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(78, 17);
            lblSubject.TabIndex = 3;
            lblSubject.Text = "Диципліни";
            // 
            // lblActivity
            // 
            lblActivity.AutoSize = true;
            lblActivity.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivity.ForeColor = Color.Gainsboro;
            lblActivity.Location = new Point(178, 137);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(77, 17);
            lblActivity.TabIndex = 4;
            lblActivity.Text = "Діяльність";
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
            // listComments
            // 
            listComments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listComments.Location = new Point(37, 226);
            listComments.Name = "listComments";
            listComments.Size = new Size(563, 102);
            listComments.TabIndex = 7;
            listComments.UseCompatibleStateImageBehavior = false;
            // 
            // FormTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(listComments);
            Controls.Add(lblGpa);
            Controls.Add(btnComment);
            Controls.Add(lblActivity);
            Controls.Add(lblSubject);
            Controls.Add(lblDepartment);
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
        private Label lblDepartment;
        private Label lblSubject;
        private Label lblActivity;
        private Button btnComment;
        private Label lblGpa;
        private ListView listComments;
    }
}