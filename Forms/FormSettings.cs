using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project.Forms
{
    public partial class FormSettings : FormProject {
        public FormSettings() {
            InitializeComponent();
            SetTheme();
            UpDownFontSize.Value = (int)Theme.textSize;
            comboBoxFont.Text = Theme.fontStyle;
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
            FormMain.mainForm.SetFont();
            SetFont();
        }

        private void comboBoxFont_SelectedValueChanged(object sender, EventArgs e) {
            Theme.fontStyle = comboBoxFont.Text;
            if (FormMain.mainForm != null) {
                FormMain.mainForm.SetFont();
            }
            SetFont();
        }
        public override void SetFont() {
            if (Font != new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular)) {
                foreach (Control item in Controls) {
                    if (item != comboBoxFont) {
                        item.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular);
                    } else {
                        item.Font = new System.Drawing.Font("Microsoft Sans Serif", Theme.textSize, System.Drawing.FontStyle.Regular);
                    }
                }
            }
        }
    }
}