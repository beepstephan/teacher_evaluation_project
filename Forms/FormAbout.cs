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
            SetTheme();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            linkLabel1.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://www.svgrepo.com/") { UseShellExecute = true });
        }
        public override void SetTheme() {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor) {
                BackColor = Theme.activeTheme.panelDesktopColor;
                label1.ForeColor = Theme.activeTheme.textColor;
                linkLabel1.ForeColor = Theme.activeTheme.textColor;
            }
        }

        public override void SetFont() {
            if (Font != new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))) {
                foreach (Control btn in Controls) {
                    btn.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
