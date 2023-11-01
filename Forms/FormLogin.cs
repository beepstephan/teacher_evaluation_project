using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teacher_evaluation_project.Forms {
    public partial class FormLogIn : FormProject {
        public FormLogIn() {
            InitializeComponent();
            SetTheme();
        }

        private void label1_Click(object sender, EventArgs e) {
            FormMain.mainForm.OpenChildForm(new Forms.FormSingUp());
        }
        public override void SetTheme() {
            if (BackColor != Theme.activeTheme.panelDesktopColor) {
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnLogIn.BackColor = Theme.activeTheme.mainMenuColor;
                btnLogIn.ForeColor = Theme.activeTheme.textColor;
                lblAccount.ForeColor = Theme.activeTheme.textColor;
            }
        }
    }
}
