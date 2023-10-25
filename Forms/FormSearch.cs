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
    public partial class FormSearch : Form {
        FormMainMenu mainMenu;
        public FormSearch(FormMainMenu mainMenu) {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void listView1_ItemActivate(object sender, EventArgs e) {
            ListViewItem item = listView1.SelectedItems[0];
            mainMenu.OpenChildForm(new Forms.FormTeacher(mainMenu, item.Text));
        }
    }
}
