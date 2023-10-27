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
            SetThemeColor(FormMain.activeTheme);
        }

        public override void SetThemeColor(Theme newTheme) {
            BackColor = FormMain.activeTheme.panelDesktopColor;
            label1.ForeColor = FormMain.activeTheme.textColor;
        }
    }
}
