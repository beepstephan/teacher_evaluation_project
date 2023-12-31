﻿namespace teacher_evaluation_project.Forms
{
    partial class FormSingUp
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
            lblAccount = new Label();
            buttonSingUp = new Button();
            passField = new TextBox();
            loginField = new TextBox();
            userNameField = new TextBox();
            userSurnameField = new TextBox();
            checkPass = new CheckBox();
            SuspendLayout();
            // 
            // lblAccount
            // 
            lblAccount.Anchor = AnchorStyles.None;
            lblAccount.Cursor = Cursors.Hand;
            lblAccount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccount.ForeColor = Color.Gainsboro;
            lblAccount.Location = new Point(150, 295);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(326, 30);
            lblAccount.TabIndex = 6;
            lblAccount.Text = "Вже є обліковий запис?";
            lblAccount.TextAlign = ContentAlignment.TopCenter;
            lblAccount.Click += label1_Click;
            // 
            // buttonSingUp
            // 
            buttonSingUp.Anchor = AnchorStyles.None;
            buttonSingUp.BackColor = Color.FromArgb(30, 30, 65);
            buttonSingUp.FlatStyle = FlatStyle.Flat;
            buttonSingUp.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSingUp.ForeColor = Color.Gainsboro;
            buttonSingUp.Location = new Point(252, 245);
            buttonSingUp.Name = "buttonSingUp";
            buttonSingUp.Size = new Size(124, 32);
            buttonSingUp.TabIndex = 5;
            buttonSingUp.Text = "Реєстрація";
            buttonSingUp.UseVisualStyleBackColor = false;
            buttonSingUp.Click += buttonSingUp_Click_1;
            // 
            // passField
            // 
            passField.Anchor = AnchorStyles.None;
            passField.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(213, 81);
            passField.Name = "passField";
            passField.Size = new Size(200, 24);
            passField.TabIndex = 1;
            passField.Tag = "pass";
            passField.Text = "Введіть пароль";
            // 
            // loginField
            // 
            loginField.Anchor = AnchorStyles.None;
            loginField.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(213, 31);
            loginField.Name = "loginField";
            loginField.Size = new Size(200, 24);
            loginField.TabIndex = 0;
            loginField.Text = "Введіть логін";
            // 
            // userNameField
            // 
            userNameField.Anchor = AnchorStyles.None;
            userNameField.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            userNameField.Location = new Point(213, 145);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(200, 24);
            userNameField.TabIndex = 3;
            userNameField.Text = "Введіть ім'я";
            // 
            // userSurnameField
            // 
            userSurnameField.Anchor = AnchorStyles.None;
            userSurnameField.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            userSurnameField.Location = new Point(213, 195);
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new Size(200, 24);
            userSurnameField.TabIndex = 4;
            userSurnameField.Text = "Введіть прізвище";
            // 
            // checkPass
            // 
            checkPass.Anchor = AnchorStyles.None;
            checkPass.AutoSize = true;
            checkPass.ForeColor = Color.Gainsboro;
            checkPass.Location = new Point(273, 111);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(140, 21);
            checkPass.TabIndex = 2;
            checkPass.Text = "Показать пароль";
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // FormSingUp
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 80);
            ClientSize = new Size(628, 341);
            Controls.Add(checkPass);
            Controls.Add(userSurnameField);
            Controls.Add(userNameField);
            Controls.Add(lblAccount);
            Controls.Add(buttonSingUp);
            Controls.Add(passField);
            Controls.Add(loginField);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormSingUp";
            Text = "Реєстрація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccount;
        private Button buttonSingUp;
        private TextBox passField;
        private TextBox loginField;
        private TextBox userNameField;
        private TextBox userSurnameField;
        private CheckBox checkPass;
    }
}