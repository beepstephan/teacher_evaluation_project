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
    public partial class FormLogin : Form {
        FormMainMenu mainMenu;
        public FormLogin(FormMainMenu mainMenu) {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void label1_Click(object sender, EventArgs e) {
            mainMenu.OpenChildForm(new Forms.FormSingUp(mainMenu));
        }
    }
}
