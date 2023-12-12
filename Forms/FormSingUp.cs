using System.Data;
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

        public Boolean isUsersExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @uE ", db.getConnection());
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
            DataBase db = new DataBase();
            Except ConnectionException = new Except();
            bool isConnected = ConnectionException.IsValidConnection("server=localhost;port=3306;username=root;password=root;database=teachers");
            if (isConnected) {
                Except signUpException = new Except();
                try
                {
                    if (!signUpException.IsValidUsername(userNameField.Text) || !signUpException.IsValidPassword(passField.Text) || !signUpException.IsValidEmail(loginField.Text) || !signUpException.IsValidSurname(userSurnameField.Text))
                    {
                        throw new Except(userNameField.Text, userSurnameField.Text, loginField.Text, passField.Text);
                    }
                    
                    if (userNameField.Text == "Введіть ім'я")
                    {
                        MessageBox.Show("Введіть ім'я");
                        return;
                    }

                    if (userSurnameField.Text == "")
                    {
                        MessageBox.Show("Введіть прізвище");
                        return;
                    }

                    if (isUsersExists())
                        return;

                    MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `email`, `pass`, `name`, `surname`) VALUES ( @email, @pass, @name, @surname)", db.getConnection());

                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = loginField.Text;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
                    command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Реєстрація успішна", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // авторизація
                        DataTable table = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand cmdGet = new MySqlCommand("SELECT id FROM `users` WHERE `email` = @uE", db.getConnection());
                        cmdGet.Parameters.Add("@uE", MySqlDbType.VarChar).Value = loginField.Text;

                        adapter.SelectCommand = cmdGet;
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            DataRow userData = table.Rows[0];
                            User.Id = Convert.ToInt32(userData["id"].ToString());
                            User.Email = loginField.Text;
                            User.Surname = userSurnameField.Text;
                            User.Name = userNameField.Text;
                            User.isLogIn = true;

                            FormMain.mainForm.btnLogIn.BackColor = Color.Brown;
                            FormMain.mainForm.btnLogIn.Text = "   Вийти";

                            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formHome);
                        }
                        // =======

                        FormMain.mainForm.formLogIn = new FormLogIn();
                        FormMain.mainForm.OpenChildForm(FormMain.mainForm.formLogIn);
                    }
                    db.closeConnection();
                    
                }
                catch (Except ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
      
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
