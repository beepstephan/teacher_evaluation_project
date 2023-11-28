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
    public partial class FormDev : FormProject
    {
        public FormDev()
        {
            InitializeComponent();
            SetTheme();
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
        public override void SetFont()
        {
            if(fontStyle != Theme.fontStyle || fontSize != Theme.fontSize)
            {
                fontStyle = Theme.fontStyle;
                fontSize = Theme.fontSize;
                foreach (Control item in panel1.Controls)
                {
                    item.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize, System.Drawing.FontStyle.Regular);
                }
            }
        }


    }
}