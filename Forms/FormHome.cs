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
    public partial class FormHome : FormProject {
        public FormHome() {
            InitializeComponent();
        }

        public override void ChangeThemeColor() {
            BackColor = FormMainMenu.activeTheme.panelDesktopColor;
            label1.ForeColor = FormMainMenu.activeTheme.textColor;
        }
    }
}
