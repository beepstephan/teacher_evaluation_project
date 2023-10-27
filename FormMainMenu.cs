using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using teacher_evaluation_project.Forms;

namespace teacher_evaluation_project {
    public partial class FormMainMenu : FormProject {
        private ThemeColor themeColor = new ThemeColor();

        //Fields
        private Button activeButton;
        private FormProject activeForm;
        static public Theme activeTheme;
        static public FormMainMenu mainMenu;

        //Constructor
        public FormMainMenu() {
            mainMenu = this;
            activeTheme = themeColor.GetDefaultTheme();
            InitializeComponent();
            ActivateMenuItem(btnHome);
            OpenChildForm(new Forms.FormHome());
        }

        private void ActivateMenuItem(object btnSender) {
            if (btnSender != null) {
                if (activeButton != (Button)btnSender) {
                    DisableMenuItems();
                    activeButton = (Button)btnSender;
                    activeButton.BackColor = activeTheme.activeButtoneColor;
                    activeButton.ForeColor = activeTheme.textColor;
                    activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableMenuItems() {
            foreach (Control btn in panelMenu.Controls) {
                if (btn.GetType() == typeof(Button) && btn != btnLogin) {
                    btn.BackColor = activeTheme.mainMenuColor;
                    btn.ForeColor = activeTheme.textColor;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            lblTitle.Text = childForm.Text;
        }

        public override void ChangeThemeColor() {
            Theme tempTheme = themeColor.GetTheme();
            while (activeTheme == tempTheme) {
                tempTheme = themeColor.GetTheme();
            }
            activeTheme = tempTheme;
            panelTitleBar.BackColor = activeTheme.panelTitleBar;
            panelMenu.BackColor = activeTheme.mainMenuColor;
            foreach (Control btn in panelMenu.Controls) {
                if (btn.GetType() == typeof(Button) && btn != btnLogin) {
                    btn.ForeColor = activeTheme.textColor;
                }
            }

            foreach (Control btn in panelMenu.Controls) {
                if (btn.GetType() == typeof(Button)) {
                    if (((Button)btn).Image != null) {
                        Image img = ((Button)btn).Image;
                        Bitmap bmp = new Bitmap(img);
                        for (int y = 0; y < bmp.Height; y++) {
                            for (int x = 0; x < bmp.Width; x++) {
                                Color pixel = bmp.GetPixel(x, y);
                                int a = pixel.A;
                                int r = activeTheme.imgColor.R;
                                int g = activeTheme.imgColor.G;
                                int b = activeTheme.imgColor.B;
                                bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                            }
                        }
                        ((Button)btn).Image = bmp;
                    }
                }
                activeForm.ChangeThemeColor();
            }
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
            ChangeThemeColor();
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