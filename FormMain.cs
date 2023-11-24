using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using teacher_evaluation_project.Forms;
using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project
{
    public partial class FormMain : FormProject {

        private Theme themeColor = new Theme();

        //Fields
        private Button activeButton;
        private FormProject activeForm;
        static public FormMain mainForm;

        //child forms
        public FormHome formHome = new FormHome();
        public FormSearch formSearch = new FormSearch();
        public FormSettings formSettings = new FormSettings();
        public FormTeacher formTeacher = new FormTeacher();
        public FormComent formComent = new FormComent();
        public FormLogIn formLogIn = new FormLogIn();
        public FormSingUp formSingUp = new FormSingUp();
        public FormFaq formFaq = new FormFaq();
        public FormDev formDev = new FormDev();
        public FormAbout formAbout = new FormAbout();

        //Constructor
        public FormMain() {
            mainForm = this;
            InitializeComponent();
            ActivateMenuItem(btnHome);
            OpenChildForm(formHome);
        }

        private void ActivateMenuItem(object btnSender) {
            if (btnSender != null) {
                if (activeButton != (Button)btnSender) {
                    DisableMenuItems();
                    activeButton = (Button)btnSender;
                    activeButton.BackColor = Theme.activeTheme.activeButtoneColor;
                    activeButton.ForeColor = Theme.activeTheme.textColor;
                    activeButton.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize + 2, System.Drawing.FontStyle.Regular);
                }
            }
        }
        private void DisableMenuItems() {
            foreach (Control btn in panelMenu.Controls) {
                if (btn.GetType() == typeof(Button) && btn != btnLogIn) {
                    btn.BackColor = Theme.activeTheme.mainMenuColor;
                    btn.ForeColor = Theme.activeTheme.textColor;
                    btn.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular);
                }
            }
            activeButton = null;
        }
        
        public override void SetTheme() {
            SetFont();
            panelTitleBar.BackColor = Theme.activeTheme.panelTitleBar;
            titleBarText.ForeColor = Theme.activeTheme.textColor;
            panelLogo.BackColor = Theme.activeTheme.mainMenuColor;
            logoTxt.ForeColor = Theme.activeTheme.textColor;
            panelMenu.BackColor = Theme.activeTheme.mainMenuColor;

            foreach (Control btn in panelMenu.Controls) {
                if (btn.GetType() == typeof(Button)) {
                    btn.ForeColor = Theme.activeTheme.textColor;
                    btn.BackColor = Theme.activeTheme.mainMenuColor;
                    if (((Button)btn).Image != null) {
                        Image img = ((Button)btn).Image;
                        Bitmap bmp = new Bitmap(img);
                        for (int y = 0; y < bmp.Height; y++) {
                            for (int x = 0; x < bmp.Width; x++) {
                                Color pixel = bmp.GetPixel(x, y);
                                int a = pixel.A;
                                int r = Theme.activeTheme.imgColor.R;
                                int g = Theme.activeTheme.imgColor.G;
                                int b = Theme.activeTheme.imgColor.B;
                                bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                            }
                        }
                        ((Button)btn).Image = bmp;
                    }
                }
            }
            if (activeButton != null) {
                activeButton.BackColor = Theme.activeTheme.activeButtoneColor;
            }
        }
        public override void SetFont() {
            if (Font != new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular)) {
                foreach (Control btn in panelMenu.Controls) {
                    btn.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular);
                }
                titleBarText.Font = new System.Drawing.Font(Theme.fontStyle, 20, System.Drawing.FontStyle.Regular);
            }
        }

        public void OpenChildForm(FormProject childForm) {
            if (activeForm != null) {
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

        private void btnHome_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(formHome);
        }
        private void btnSearch_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(formSearch);
        }
        private void btnTheme_Click(object sender, EventArgs e) {
            themeColor.SetNext();
            SetTheme();
            activeForm.SetTheme();
        }
        private void btnSettings_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(formSettings);
        }
        private void btnFaq_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(formFaq);
        }
        private void btnDev_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(formDev);
        }
        private void brnAbout_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(formAbout);
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            DisableMenuItems();
            OpenChildForm(formLogIn);
        }
    }
}