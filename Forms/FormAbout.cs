using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher_evaluation_project.Forms {
    public partial class FormAbout : FormProject {
        public FormAbout() {
            InitializeComponent();
            SetThemeColor(FormMain.activeTheme);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            linkLabel1.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://www.svgrepo.com/") { UseShellExecute = true });
        }
        public override void SetThemeColor(Theme newTheme) {
            BackColor = FormMain.activeTheme.panelDesktopColor;
        }
        public override void ChangeThemeColor() {
            
        }
    }
}
