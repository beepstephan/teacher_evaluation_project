using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teacher_evaluation_project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teacher_evaluation_project.Forms {
    public partial class FormSearch : FormProject {
        public FormSearch() {
            InitializeComponent();
            SetTheme();
        }

        private void listView1_ItemActivate(object sender, EventArgs e) {
            ListViewItem item = listViewTeachers.SelectedItems[0];
            FormMain.mainForm.OpenChildForm(new Forms.FormTeacher(item.Text));
        }
        public override void SetTheme() {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor) {
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnSearch.BackColor = Theme.activeTheme.mainMenuColor;
                btnSearch.ForeColor = Theme.activeTheme.textColor;
            }
        }
    }
}
