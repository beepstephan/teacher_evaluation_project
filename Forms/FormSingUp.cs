using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher_evaluation_project.Forms {
    public partial class FormSingUp : FormProject {
        public FormSingUp() {
            InitializeComponent();
            SetTheme();
        }

        private void label1_Click(object sender, EventArgs e) {
            FormMain.mainForm.OpenChildForm(new Forms.FormLogIn());
        }
        public override void SetTheme() {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor) {
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnSingUp.BackColor = Theme.activeTheme.mainMenuColor;
                btnSingUp.ForeColor = Theme.activeTheme.textColor;
                lblAccount.ForeColor = Theme.activeTheme.textColor;
            }
        }
    }
}
