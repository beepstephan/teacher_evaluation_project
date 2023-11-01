namespace teacher_evaluation_project.Forms {
    partial class FormTeacher {
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
            pictureBox = new PictureBox();
            lblName = new Label();
            lblDepartment = new Label();
            lblSubject = new Label();
            lblActivity = new Label();
            btnFeedback = new Button();
            lblGPA = new Label();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Gainsboro;
            pictureBox.Location = new Point(37, 27);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(114, 128);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
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
            // btnFeedback
            // 
            btnFeedback.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFeedback.BackColor = Color.FromArgb(30, 30, 65);
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFeedback.ForeColor = Color.Gainsboro;
            btnFeedback.Location = new Point(429, 167);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(171, 41);
            btnFeedback.TabIndex = 5;
            btnFeedback.Text = "Дати відгук";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += button1_Click;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGPA.ForeColor = Color.Gainsboro;
            lblGPA.Location = new Point(37, 190);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(154, 17);
            lblGPA.TabIndex = 6;
            lblGPA.Text = "Середні оцінка: 8.4/10";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(37, 226);
            listView1.Name = "listView1";
            listView1.Size = new Size(563, 83);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 322);
            Controls.Add(listView1);
            Controls.Add(lblGPA);
            Controls.Add(btnFeedback);
            Controls.Add(lblActivity);
            Controls.Add(lblSubject);
            Controls.Add(lblDepartment);
            Controls.Add(lblName);
            Controls.Add(pictureBox);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormTeacher";
            Text = "Викладач";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label lblName;
        private Label lblDepartment;
        private Label lblSubject;
        private Label lblActivity;
        private Button btnFeedback;
        private Label lblGPA;
        private ListView listView1;
    }
}