﻿using System;
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
                foreach (Control btn in Controls)
                {
                    btn.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
