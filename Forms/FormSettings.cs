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
    public partial class FormSettings : FormProject
    {
        public FormSettings()
        {
            InitializeComponent();
            SetTheme();
            UpDownFontSize.Value = (int)Theme.fontSize;
            boxFontStyle.Text = Theme.fontStyle;
        }
        public override void SetTheme()
        {
            SetFont();
            if (themeIndex != Theme.themeIndex)
            {
                themeIndex = Theme.themeIndex;
                BackColor = Theme.activeTheme.panelDesktopColor;
            }
        }
        private void UpDownFontSize_ValueChanged(object sender, EventArgs e)
        {
            Theme.fontSize = (float)UpDownFontSize.Value;
            FormMain.mainForm.SetFont();
            SetFont();
        }

        private void comboBoxFont_SelectedValueChanged(object sender, EventArgs e)
        {
            Theme.fontStyle = boxFontStyle.Text;
            if (FormMain.mainForm != null)
            {
                FormMain.mainForm.SetFont();
            }
            SetFont();
        }
        public override void SetFont()
        {
            if (fontStyle != Theme.fontStyle || fontSize != Theme.fontSize)
            {
                fontStyle = Theme.fontStyle;
                fontSize = Theme.fontSize;
                foreach (Control item in Controls)
                {
                    if (item != boxFontStyle)
                    {
                        item.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize, System.Drawing.FontStyle.Regular);
                    }
                    else
                    {
                        item.Font = new System.Drawing.Font("Microsoft Sans Serif", Theme.fontSize, System.Drawing.FontStyle.Regular);
                    }
                }
            }
        }
    }
}