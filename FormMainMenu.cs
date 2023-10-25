using System.Runtime.InteropServices;

namespace teacher_evaluation_project {
    public partial class FormMainMenu : Form {
        //Fields
        private Button activeButton;
        private Form activeForm;

        //Constructor
        public FormMainMenu() {
            InitializeComponent();
            ActivateMenuItem(btnHome);
            OpenChildForm(new Forms.FormHome());
        }

        private void ActivateMenuItem(object btnSender) {
            if (btnSender != null) {
                if (activeButton != (Button)btnSender) {
                    DisableMenuItems();
                    activeButton = (Button)btnSender;
                    activeButton.BackColor = Color.FromArgb(0, 176, 176);
                    activeButton.ForeColor = Color.White;
                    activeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableMenuItems() {
            foreach (Control previousBtn in panelMenu.Controls) {
                if (previousBtn.GetType() == typeof(Button) && previousBtn != btnLogin) {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            activeButton = null;
        }

        public void OpenChildForm(Form childForm) {
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

        private void btnHome_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(new Forms.FormHome());
        }
        private void btnSearch_Click(object sender, EventArgs e) {
            ActivateMenuItem(sender);
            OpenChildForm(new Forms.FormSearch(this));
        }
        private void btnTheme_Click(object sender, EventArgs e) {
            // зміна теми застосунку
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
            OpenChildForm(new Forms.FormLogin(this));
        }
    }
}