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
            SetTheme();
            lblName.Text = teacherName;
        }

        private void button1_Click(object sender, EventArgs e) {
            FormMain.mainForm.OpenChildForm(new Forms.FormComent(lblName.Text));
        }
        public override void SetTheme() {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor) {
                BackColor = Theme.activeTheme.panelDesktopColor;
                lblName.ForeColor = Theme.activeTheme.textColor;
                lblDepartment.ForeColor = Theme.activeTheme.textColor;
                lblSubject.ForeColor = Theme.activeTheme.textColor;
                lblActivity.ForeColor = Theme.activeTheme.textColor;
                lblGPA.ForeColor = Theme.activeTheme.textColor;
                btnFeedback.ForeColor = Theme.activeTheme.textColor;
                btnFeedback.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }
    }
}
