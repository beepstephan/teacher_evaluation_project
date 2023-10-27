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
            SetThemeColor(FormMain.activeTheme);
        }

        private void label1_Click(object sender, EventArgs e) {
            FormMain.mainMenu.OpenChildForm(new Forms.FormSingUp());
        }
        public override void SetThemeColor(Theme newTheme) {
            BackColor = FormMain.activeTheme.panelDesktopColor;
        }
    }
}
