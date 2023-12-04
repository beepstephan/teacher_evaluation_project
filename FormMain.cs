using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using teacher_evaluation_project.Forms;
using teacher_evaluation_project.projectClasses;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace teacher_evaluation_project
{
    public partial class FormMain : FormProject
    {
        //Fields
        private Button activeButton;
        private FormProject activeForm;
        static public FormMain mainForm;
        public MySqlConnection connection;
        public MySqlCommand command;
        const string connect = "server=localhost;port=3306;username=root;password=root;database=teachers";
        public List<ListViewItem> AllTeachers = new List<ListViewItem>();
        public User currentUser = new User();

        //child forms
        public FormHome formHome = new FormHome();
        public FormSearch formSearch = new FormSearch();
        public FormSettings formSettings = new FormSettings();
        public FormTeacher formTeacher = new FormTeacher();
        public FormComment formComent = new FormComment();
        public FormLogIn formLogIn = new FormLogIn();
        public FormSingUp formSingUp = new FormSingUp();
        public FormFaq formFaq = new FormFaq();
        public FormDev formDev = new FormDev();
        public FormAbout formAbout = new FormAbout();

        //Constructor
        public FormMain()
        {
            mainForm = this;
            InitializeComponent();
            ActivateMenuItem(btnHome);
            OpenChildForm(formHome);
            LoadTeachers();
        }

        public void LoadTeachers()
        {

            try
            {
                connection = new MySqlConnection(connect);
                connection.Open();

                string script = "SELECT id, surname, name, middlename, pos, rate FROM `dep`";
                MySqlDataAdapter adapter = new MySqlDataAdapter(script, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(new string[] { dr["id"].ToString(), dr["surname"].ToString(), dr["name"].ToString(), dr["middlename"].ToString(), dr["pos"].ToString(), dr["rate"].ToString() });
                    AllTeachers.Add(listitem);
                }

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Connection lost");
            }
        }
        private void ActivateMenuItem(object btnSender)
        {
            if (btnSender != null)
            {
                if (activeButton != (Button)btnSender)
                {
                    DisableMenuItems();
                    activeButton = (Button)btnSender;
                    activeButton.BackColor = Theme.activeTheme.activeButtoneColor;
                    activeButton.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize + 2, System.Drawing.FontStyle.Regular);
                }
            }
        }
        private void DisableMenuItems()
        {
            foreach (Control btn in panelMenu.Controls)
            {
                if (btn.GetType() == typeof(Button) && btn != btnLogIn)
                {
                    btn.BackColor = Theme.activeTheme.mainMenuColor;
                    btn.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize, System.Drawing.FontStyle.Regular);
                }
            }

            activeButton = null;
        }

        public override void SetTheme()
        {
            SetFont();
            if (themeIndex != Theme.themeIndex)
            {
                themeIndex = Theme.themeIndex;
                panelTitleBar.BackColor = Theme.activeTheme.panelTitleBar;
                panelLogo.BackColor = Theme.activeTheme.mainMenuColor;
                panelMenu.BackColor = Theme.activeTheme.mainMenuColor;

                foreach (Control btn in panelMenu.Controls)
                {
                    if (btn.GetType() == typeof(Button) && btn != btnLogIn)
                    {
                        btn.BackColor = Theme.activeTheme.mainMenuColor;
                    }
                }
                if (activeButton != null)
                {
                    activeButton.BackColor = Theme.activeTheme.activeButtoneColor;
                }
            }
        }
        public override void SetFont()
        {
            if (fontStyle != Theme.fontStyle || fontSize != Theme.fontSize)
            {
                fontStyle = Theme.fontStyle;
                fontSize = Theme.fontSize;
                foreach (Control btn in panelMenu.Controls)
                {
                    btn.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize, System.Drawing.FontStyle.Regular);
                }
                titleBarText.Font = new System.Drawing.Font(Theme.fontStyle, titleBarText.Font.Size, System.Drawing.FontStyle.Regular);
                lblLogo.Font = new System.Drawing.Font(Theme.fontStyle, lblLogo.Font.Size, System.Drawing.FontStyle.Regular);
            }
        }

        public void OpenChildForm(FormProject childForm)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
                panelDesktop.Controls.Remove(activeForm);
            }
            activeForm = childForm;
            activeForm.SetTheme();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            titleBarText.Text = childForm.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateMenuItem(sender);
            OpenChildForm(formHome);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (currentUser.isLogIn == true)
            {
                ActivateMenuItem(sender);
                formSearch = new FormSearch(AllTeachers);
                OpenChildForm(formSearch);
            }
            else
            {
                ActivateMenuItem(btnLogIn);
                OpenChildForm(formLogIn);
                MessageBox.Show("��� ������ ����� ����������, ��������� �����������", "������� �����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnTheme_Click(object sender, EventArgs e)
        {
            Theme.SetNext();
            SetTheme();
            activeForm.SetTheme();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateMenuItem(sender);
            OpenChildForm(formSettings);
        }
        private void btnFaq_Click(object sender, EventArgs e)
        {
            ActivateMenuItem(sender);
            OpenChildForm(formFaq);
        }
        private void btnDev_Click(object sender, EventArgs e)
        {
            ActivateMenuItem(sender);
            OpenChildForm(formDev);
        }
        private void brnAbout_Click(object sender, EventArgs e)
        {
            ActivateMenuItem(sender);
            OpenChildForm(formAbout);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DisableMenuItems();
            OpenChildForm(formLogIn);
            //if (currentUser.isLogIn == false)
            //{
            //    // ���� ���������� �� ������������� - �������� FormLogIn
            //    DisableMenuItems();
            //    OpenChildForm(formLogIn);
            //}
            //else
            //{
            //    // ���� ���������� ������������� - ����� � ��������
            //
            //    // ��������� ����� currentUser
            //    // ���������� ����� �� ����������� �����
            //}
        }
    }
}