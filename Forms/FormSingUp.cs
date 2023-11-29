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

            passField.AddPlaceholder("Введіть пароль");
            loginField.AddPlaceholder("Введіть email");
            userNameField.AddPlaceholder("Введіть ім'я");
            userSurnameField.AddPlaceholder("Введіть прізвище");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormMain.mainForm.formLogIn = new FormLogIn();
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formLogIn);
        }
        public override void SetTheme()
        {
            SetFont();
            if (themeIndex != Theme.themeIndex)
            {
                themeIndex = Theme.themeIndex;
                BackColor = Theme.activeTheme.panelDesktopColor;
                buttonSingUp.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }

        public override void SetFont()
        {
            if (fontStyle != Theme.fontStyle || fontSize != Theme.fontSize)
            {
                fontStyle = Theme.fontStyle;
                fontSize = Theme.fontSize;
                loginField.Font = new System.Drawing.Font(Theme.fontStyle + 1, Theme.fontSize, System.Drawing.FontStyle.Regular);
                passField.Font = new System.Drawing.Font(Theme.fontStyle + 1, Theme.fontSize, System.Drawing.FontStyle.Regular);
                userNameField.Font = new System.Drawing.Font(Theme.fontStyle + 1, Theme.fontSize, System.Drawing.FontStyle.Regular);
                userSurnameField.Font = new System.Drawing.Font(Theme.fontStyle + 1, Theme.fontSize, System.Drawing.FontStyle.Regular);
                buttonSingUp.Font = new System.Drawing.Font(Theme.fontStyle + 1, Theme.fontSize, System.Drawing.FontStyle.Bold);
                lblAccount.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize, System.Drawing.FontStyle.Regular);
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
    }
}
