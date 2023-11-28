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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormMain.mainForm.formSingUp = new FormSingUp();
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formSingUp);
        }
        public override void SetTheme()
        {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor)
            {
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnLogIn.BackColor = Theme.activeTheme.mainMenuColor;
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

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            loginField.AddPlaceholder("Введіть email");
            passField.AddPlaceholder("Введіть пароль");

            //Paint += new PaintEventHandler(Form1_Paint);
        }
        void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //Pen pen = new Pen(Brushes.White, 4);
            //pen.LineJoin = LineJoin.Bevel;//задаем скошенные углы
            //pen.MiterLimit = 4;//задаем ограничение толщины скошенных углов
            //g.DrawRectangle(pen, new Rectangle(loginField.Location.X - 1, loginField.Location.Y - 1, loginField.Width + 3, loginField.Height + 3));
            ////рисуем прямоугольник с параметрами испоьзуемыми выше            
            //// ex Hermein
        }
    }
}
