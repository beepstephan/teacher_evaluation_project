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
using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project.Forms
{
    public partial class FormAbout : FormProject
    {
        public FormAbout()
        {
            InitializeComponent();
            SetTheme();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            imgLink.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://www.svgrepo.com/") { UseShellExecute = true });
        }
        public override void SetTheme()
        {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor)
            {
                BackColor = Theme.activeTheme.panelDesktopColor;
            }
        }

        public override void SetFont()
        {
            if (Font.FontFamily.Name != Theme.fontStyle || Font.Size != Theme.textSize)
            {
                foreach (Control btn in Controls)
                {
                    btn.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
