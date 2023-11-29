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
    public partial class FormFaq : FormProject
    {
        public FormFaq()
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
            if (fontStyle != Theme.fontStyle || fontSize != Theme.fontSize)
            {
                fontStyle = Theme.fontStyle;
                fontSize = Theme.fontSize;
                lblTitle.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize + 1, System.Drawing.FontStyle.Bold);
                labelGuide.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize, System.Drawing.FontStyle.Regular);
            }
        }

        private void FormFaq_Paint(object sender, PaintEventArgs e)
        {
            labelGuide.MaximumSize = new System.Drawing.Size(Width - 70, labelGuide.MaximumSize.Height);
            labelGuide.Location = new Point((Width - labelGuide.Width - 18) / 2, labelGuide.Location.Y);
        }
    }
}
