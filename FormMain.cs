using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using teacher_evaluation_project.Forms;

namespace teacher_evaluation_project {
    public partial class FormMain : FormProject {

        private Theme themeColor = new Theme();

        //Fields
        private Button activeButton;
        private FormProject activeForm;
        static public FormMain mainForm;

        //Constructor
        public FormMain() {
            InitializeComponent();
            mainForm = this;
            ActivateMenuItem(btnHome);
            OpenChildForm(new Forms.FormHome());
        }

        private void ActivateMenuItem(object btnSender) {
            if (btnSender != null) {
                if (activeButton != (Button)btnSender) {
                    DisableMenuItems();
                    activeButton = (Button)btnSender;
                    activeButton.BackColor = Theme.activeTheme.activeButtoneColor;
                    activeButton.ForeColor = Theme.activeTheme.textColor;
                    activeButton.Font = new System.Drawing.Font(Theme.activeFont, Theme.textSize + 2, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableMenuItems() {
            foreach (Control btn in panelMenu.Controls) {
                if (btn.GetType() == typeof(Button) && btn != btnLogIn) {
                    btn.BackColor = Theme.activeTheme.mainMenuColor;
                    btn.ForeColor = Theme.activeTheme.textColor;
                    btn.Font = new System.Drawing.Font(Theme.activeFont, Theme.textSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            activeButton = null;
        }
        public void OpenChildForm(FormProject childForm) {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleBarText.Text = childForm.Text;
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

            activeButton.BackColor = Theme.activeTheme.activeButtoneColor;
        }

        private void btnHome_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(new Forms.FormHome());
        }
        private void btnSearch_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(new Forms.FormSearch());
        }
        private void btnTheme_Click(object sender, EventArgs e) {
            themeColor.SetNext();
            SetTheme();
            activeForm.SetTheme();
        }
        private void btnSettings_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(new Forms.FormSettings());
        }
        private void btnFaq_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(new Forms.FormFaq());
        }
        private void btnDev_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(new Forms.FormDev());
        }
        private void brnAbout_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(new Forms.FormAbout());
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            DisableMenuItems();
            OpenChildForm(new Forms.FormLogIn());
        }
    }
}