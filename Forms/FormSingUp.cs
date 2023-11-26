using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teacher_evaluation_project.projectClasses;
using MySql.Data.MySqlClient;

namespace teacher_evaluation_project.Forms
{
    public partial class FormSingUp : FormProject
    {
        public FormSingUp()
        {
            InitializeComponent();
            SetTheme();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormMain.mainForm.formLogIn = new FormLogIn();
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formLogIn);
        }
        public override void SetTheme()
        {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor)
            {
                BackColor = Theme.activeTheme.panelDesktopColor;
                buttonSingUp.BackColor = Theme.activeTheme.mainMenuColor;

            }
        }

        public Boolean isUsersExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`WHERE `email` = @uE ", db.getConnection());
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("У вас вже є акаунт, спробуйте інший логін", "Помилка реєстрації", MessageBoxButtons.OK);
                return true;
            }

            else
                return false;
        }

        private void buttonSingUp_Click_1(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введіть ім'я")
            {
                MessageBox.Show("Введіть ім'я");
                return;
            }

            if (userSurnameField.Text == "")
            {
                MessageBox.Show("Введіть фамілію");
                return;
            }

            if (isUsersExists())
                return;

            DataBase db = new DataBase();// Створення бази даних 
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `email`, `pass`, `name`, `surname`) VALUES ( @email, @pass, @name, @surname)", db.getConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Акаунт був створений");
            else
                MessageBox.Show("Акаунт не був створений");

            db.closeConnection();
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введіть логін")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;

            }
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введіть пароль")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;

            }
        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введіть ім'я")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;

            }
        }

        private void userSurnameField_TextChanged(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введіть прізвище")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;

            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {

            if (passField.Text == "Введіть пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;

            }
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {

            if (userNameField.Text == "Введіть ім'я")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;

            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {

            if (userSurnameField.Text == "Введіть прізвище")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;

            }
        }
    }
}
