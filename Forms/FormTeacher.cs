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
    public partial class FormTeacher : FormProject {
        public FormTeacher(string teacherName) {
            InitializeComponent();
            SetThemeColor(FormMain.activeTheme);
            label1.Text = teacherName;
        }

        private void button1_Click(object sender, EventArgs e) {
            FormMain.mainMenu.OpenChildForm(new Forms.FormComent(label1.Text));
        }
        public override void SetThemeColor(Theme newTheme) {
            BackColor = FormMain.activeTheme.panelDesktopColor;
        }
    }
}
