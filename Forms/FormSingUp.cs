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
            SetThemeColor(FormMain.activeTheme);
        }

        private void label1_Click(object sender, EventArgs e) {
            FormMain.mainMenu.OpenChildForm(new Forms.FormLogIn());
        }
        public override void SetThemeColor(Theme newTheme) {
            BackColor = FormMain.activeTheme.panelDesktopColor;
        }
    }
}
