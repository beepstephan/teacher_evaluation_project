﻿using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project.Forms
{
    public partial class FormSettings : FormProject
    {
        public FormSettings()
        {
            InitializeComponent();
            SetTheme();
            UpDownFontSize.Value = (int)Theme.fontSize;
            boxFontStyle.SelectedIndex = boxFontStyle.FindStringExact(Theme.fontFamily);
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
            Theme.fontFamily = boxFontStyle.Text;
            if (FormMain.mainForm != null)
            {
                FormMain.mainForm.SetFont();
            }
            SetFont();
        }
        public override void SetFont()
        {
            if (fontFamily != Theme.fontFamily || fontSize != Theme.fontSize)
            {
                fontFamily = Theme.fontFamily;
                fontSize = Theme.fontSize;
                foreach (Control item in Controls)
                {
                    if (item != boxFontStyle)
                    {
                        item.Font = new System.Drawing.Font(Theme.fontFamily, Theme.fontSize, System.Drawing.FontStyle.Regular);
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