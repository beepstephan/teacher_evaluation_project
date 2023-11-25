using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project.Forms
{
    public partial class FormTeacher : FormProject
    {
        ListViewItem teacher;
        public FormTeacher()
        {
            InitializeComponent();
            SetTheme();
        }
        public FormTeacher(ListViewItem item)
        {
            InitializeComponent();
            SetTheme();
            teacher = item;
            lblName.Text = $"{item.Text} {item.SubItems[1].Text} {item.SubItems[2].Text}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain.mainForm.formComent = new FormComent(teacher);
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formComent);
        }
        public override void SetTheme()
        {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor)
            {
                BackColor = Theme.activeTheme.panelDesktopColor;
                lblName.ForeColor = Theme.activeTheme.textColor;
                lblDepartment.ForeColor = Theme.activeTheme.textColor;
                lblSubject.ForeColor = Theme.activeTheme.textColor;
                lblActivity.ForeColor = Theme.activeTheme.textColor;
                lblGpa.ForeColor = Theme.activeTheme.textColor;
                btnComment.ForeColor = Theme.activeTheme.textColor;
                btnComment.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }
    }
}
