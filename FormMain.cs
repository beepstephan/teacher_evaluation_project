using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using teacher_evaluation_project.Forms;
using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project
{
    public partial class FormMain : FormProject
    {
        //Fields
        private Button activeButton;
        private FormProject activeForm;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        static public FormMain mainForm;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public User currentUser = new User();
        public bool isConnected = false;

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
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FormMain()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            mainForm = this;
            InitializeComponent();
            ActivateMenuItem(btnHome);
            OpenChildForm(formHome);
        }

        public void ActivateMenuItem(object btnSender)
        {
            if (btnSender != null)
            {
                if (activeButton != (Button)btnSender)
                {
                    DisableMenuItems();
                    activeButton = (Button)btnSender;
                    activeButton.BackColor = Theme.activeTheme.activeButtoneColor;
                    activeButton.Font = new System.Drawing.Font(Theme.fontFamily, Theme.fontSize + 2, System.Drawing.FontStyle.Regular);
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
                    btn.Font = new System.Drawing.Font(Theme.fontFamily, Theme.fontSize, System.Drawing.FontStyle.Regular);
                }
            }

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            activeButton = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
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
            if (fontFamily != Theme.fontFamily || fontSize != Theme.fontSize)
            {
                fontFamily = Theme.fontFamily;
                fontSize = Theme.fontSize;
                foreach (Control btn in panelMenu.Controls)
                {
                    btn.Font = new System.Drawing.Font(Theme.fontFamily, Theme.fontSize, System.Drawing.FontStyle.Regular);
                }
                titleBarText.Font = new System.Drawing.Font(Theme.fontFamily, titleBarText.Font.Size, System.Drawing.FontStyle.Regular);
                lblLogo.Font = new System.Drawing.Font(Theme.fontFamily, lblLogo.Font.Size, System.Drawing.FontStyle.Regular);
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
            if (User.isLogIn == true)
            {
                ActivateMenuItem(sender);
                formSearch = new FormSearch();
                OpenChildForm(formSearch);
            }
            else
            {
                DisableMenuItems();
                OpenChildForm(formLogIn);
                MessageBox.Show("Щоб почати пошук викладачів, виконайте авторизацію", "Потрібна авторизація", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!User.isLogIn)
            {
                formLogIn = new FormLogIn();
                OpenChildForm(formLogIn);
            }
            else
            {
                User.LogOut();

                btnLogIn.BackColor = Color.ForestGreen;
                btnLogIn.Text = "   Увійти";

                OpenChildForm(formHome);
            }
        }
    }
}