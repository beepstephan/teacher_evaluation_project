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
            foreach (Control previousBtn in panelMenu.Controls) {
                if (previousBtn.GetType() == typeof(Button) && previousBtn != btnLogin) {
                    previousBtn.BackColor = activeTheme.mainMenuColor;
                    previousBtn.ForeColor = activeTheme.textColor;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        public override void SetThemeColor(Theme newTheme) {

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
            activeForm.ChangeThemeColor();
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