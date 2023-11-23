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
            SetTheme();
        }

        public override void SetTheme() {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor) {
                BackColor = Theme.activeTheme.panelDesktopColor;
                label1.ForeColor = Theme.activeTheme.textColor;
            }
        }
        public override void SetFont() {
            if (Font != new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))) {
                foreach (Control item in panel1.Controls) {
                    item.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
