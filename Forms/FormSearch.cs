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
            SetThemeColor(FormMain.activeTheme);
        }

        private void listView1_ItemActivate(object sender, EventArgs e) {
            ListViewItem item = listView1.SelectedItems[0];
            FormMain.mainMenu.OpenChildForm(new Forms.FormTeacher(item.Text));
        }

        public override void ChangeThemeColor() {
            BackColor = FormMain.activeTheme.panelDesktopColor;
        }
        public override void SetThemeColor(Theme newTheme) {
            BackColor = FormMain.activeTheme.panelDesktopColor;
        }
    }
}
