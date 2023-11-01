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
    public partial class FormSettings : FormProject {
        public FormSettings() {
            InitializeComponent();
            SetTheme();
            UpDownFontSize.Value = (int)Theme.textSize;
        }
        public override void SetTheme() {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor) {
                BackColor = Theme.activeTheme.panelDesktopColor;
                lblFont.ForeColor = Theme.activeTheme.textColor;
                lblFontSize.ForeColor = Theme.activeTheme.textColor;
            }
        }
        private void UpDownFontSize_ValueChanged(object sender, EventArgs e) {
            Theme.textSize = (float)UpDownFontSize.Value;
            Theme.activeFont = comboBoxFont.Text;
            FormMain.mainForm.SetFont();
            SetFont();
        }
    }
}