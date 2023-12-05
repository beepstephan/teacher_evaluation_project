﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teacher_evaluation_project.projectClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace teacher_evaluation_project.Forms
{
    public partial class FormLogIn : FormProject
    {
        public FormLogIn()
        {
            InitializeComponent();
            SetTheme();

            loginField.AddPlaceholder("Введіть email");
            passField.AddPlaceholder("Введіть пароль");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormMain.mainForm.formSingUp = new FormSingUp();
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formSingUp);
        }
        public override void SetTheme()
        {
            SetFont();
            if (themeIndex != Theme.themeIndex)
            {
                themeIndex = Theme.themeIndex;
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnLogIn.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }

        public override void SetFont()
        {
            if (fontFamily != Theme.fontFamily || fontSize != Theme.fontSize)
            {
                fontFamily = Theme.fontFamily;
                fontSize = Theme.fontSize;
                foreach (Control control in Controls)
                {
                    control.Font = new Font(Theme.fontFamily, Theme.fontSize, control.Font.Style);
                }
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`WHERE `email` = @uE AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("YES");

            else
                MessageBox.Show("NO");
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                passField.UseSystemPasswordChar = false;
            }
            else
            {
                passField.UseSystemPasswordChar = true;
            }
        }
    }
}
