using System.Data;
using teacher_evaluation_project.projectClasses;
using MySql.Data.MySqlClient;


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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            Except ConnectionException = new Except();
            bool isConnected = ConnectionException.IsValidConnection("server=localhost;port=3306;username=root;password=root;database=teachers");

            if (isConnected == true)
            {
                try
                {
                    Except LoginException = new Except();
                    if (!LoginException.IsValidPassword(passField.Text) || !LoginException.IsValidEmail(loginField.Text))
                    {
                        throw new Except(loginField.Text, passField.Text);
                    }

                    string loginUser = loginField.Text;
                    string passUser = passField.Text;

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @uE AND `pass` = @uP", db.getConnection());
                    command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = loginUser;
                    command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    string msg = "Акаунт не знайдений!";

                    if (table.Rows.Count > 0)
                    {
                        DataRow userData = table.Rows[0];
                        User.Id = Convert.ToInt32(userData["id"].ToString());
                        User.Email = userData["email"].ToString();
                        User.Surname = userData["surname"].ToString();
                        User.Name = userData["name"].ToString();
                        User.isLogIn = true;

                        FormMain.mainForm.btnLogIn.BackColor = Color.Brown;
                        FormMain.mainForm.btnLogIn.Text = "   Вийти";

                        FormMain.mainForm.OpenChildForm(FormMain.mainForm.formHome);
                    }
                    else throw new Except(msg);
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