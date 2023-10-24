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
    public partial class FormSingUp : Form {
        FormMainMenu mainMenu;
        public FormSingUp(FormMainMenu mainMenu) {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void label1_Click(object sender, EventArgs e) {
            mainMenu.OpenChildForm(new Forms.FormLogin(mainMenu));
        }
    }
}
