namespace teacher_evaluation_project.Forms {
    partial class FormLogIn {
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
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            btnLogIn = new Button();
            lblAccount = new Label();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(259, 33);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(114, 23);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.Text = "email";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(259, 86);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(114, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.Text = "password";
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.BackColor = Color.FromArgb(30, 30, 65);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.Gainsboro;
            btnLogIn.Location = new Point(257, 129);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(114, 32);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Увійти";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // lblAccount
            // 
            lblAccount.Anchor = AnchorStyles.None;
            lblAccount.AutoSize = true;
            lblAccount.Cursor = Cursors.Hand;
            lblAccount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccount.ForeColor = Color.Gainsboro;
            lblAccount.Location = new Point(213, 182);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(202, 17);
            lblAccount.TabIndex = 3;
            lblAccount.Text = "Ще немає облікового запису?";
            lblAccount.Click += label1_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 322);
            Controls.Add(lblAccount);
            Controls.Add(btnLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormLogIn";
            Text = "Увійти";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button btnLogIn;
        private Label lblAccount;
    }
}