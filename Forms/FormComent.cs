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
    public partial class FormComent : Form {
        FormMainMenu mainMenu;
        public FormComent(FormMainMenu mainMenu, string teacherName) {
            InitializeComponent();
            this.mainMenu = mainMenu;
            label1.Text = teacherName;
        }

        private void button1_Click(object sender, EventArgs e) {
            /*відпралення на сервер*/
            mainMenu.OpenChildForm(new Forms.FormSearch(mainMenu));
        }
    }
}
