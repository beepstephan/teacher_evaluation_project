namespace teacher_evaluation_project.Forms
{
    partial class FormLogIn
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
            loginField = new TextBox();
            passField = new TextBox();
            btnLogIn = new Button();
            lblAccount = new Label();
            SuspendLayout();
            // 
            // loginField
            // 
            loginField.Anchor = AnchorStyles.None;
            loginField.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(213, 45);
            loginField.Name = "loginField";
            loginField.Size = new Size(200, 24);
            loginField.TabIndex = 0;
            loginField.Text = "email";
            // 
            // passField
            // 
            passField.Anchor = AnchorStyles.None;
            passField.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(213, 95);
            passField.Name = "passField";
            passField.Size = new Size(200, 24);
            passField.TabIndex = 1;
            passField.Text = "password";
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.BackColor = Color.FromArgb(30, 30, 65);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.Gainsboro;
            btnLogIn.Location = new Point(257, 145);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(114, 32);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Увійти";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblAccount
            // 
            lblAccount.Anchor = AnchorStyles.None;
            lblAccount.Cursor = Cursors.Hand;
            lblAccount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccount.ForeColor = Color.Gainsboro;
            lblAccount.Location = new Point(151, 195);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(326, 35);
            lblAccount.TabIndex = 3;
            lblAccount.Text = "Ще немає облікового запису?";
            lblAccount.TextAlign = ContentAlignment.TopCenter;
            lblAccount.Click += label1_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(lblAccount);
            Controls.Add(btnLogIn);
            Controls.Add(passField);
            Controls.Add(loginField);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormLogIn";
            Text = "Увійти";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginField;
        private TextBox passField;
        private Button btnLogIn;
        private Label lblAccount;
    }
}