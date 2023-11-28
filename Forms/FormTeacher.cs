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

        private void btnComment_Click(object sender, EventArgs e)
        {
            // відкриття форми коментування
            FormMain.mainForm.formComent = new FormComment(teacher);
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formComent);
        }
        public override void SetTheme()
        {
            SetFont();
            if (themeIndex != Theme.themeIndex)
            {
                themeIndex = Theme.themeIndex;
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnComment.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }
    }
}
