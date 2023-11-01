namespace teacher_evaluation_project.Forms {
    partial class FormSingUp {
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
            lblAccount = new Label();
            btnSingUp = new Button();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            SuspendLayout();
            // 
            // lblAccount
            // 
            lblAccount.Anchor = AnchorStyles.None;
            lblAccount.AutoSize = true;
            lblAccount.Cursor = Cursors.Hand;
            lblAccount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccount.ForeColor = Color.Gainsboro;
            lblAccount.Location = new Point(232, 299);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(164, 17);
            lblAccount.TabIndex = 7;
            lblAccount.Text = "Вже є обліковий запис?";
            lblAccount.Click += label1_Click;
            // 
            // btnSingUp
            // 
            btnSingUp.Anchor = AnchorStyles.None;
            btnSingUp.BackColor = Color.FromArgb(30, 30, 65);
            btnSingUp.FlatStyle = FlatStyle.Flat;
            btnSingUp.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSingUp.ForeColor = Color.Gainsboro;
            btnSingUp.Location = new Point(257, 246);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.Size = new Size(114, 32);
            btnSingUp.TabIndex = 6;
            btnSingUp.Text = "Реєстрація";
            btnSingUp.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(257, 86);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(114, 23);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.Text = "password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(257, 33);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(114, 23);
            textBoxEmail.TabIndex = 4;
            textBoxEmail.Text = "email";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(257, 139);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(114, 23);
            textBoxName.TabIndex = 8;
            textBoxName.Text = "Ім'я";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.None;
            textBoxSurname.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.Location = new Point(257, 193);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(114, 23);
            textBoxSurname.TabIndex = 9;
            textBoxSurname.Text = "Прізвище";
            // 
            // FormSingUp
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 322);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(lblAccount);
            Controls.Add(btnSingUp);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormSingUp";
            Text = "Реєстрація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccount;
        private Button btnSingUp;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
    }
}