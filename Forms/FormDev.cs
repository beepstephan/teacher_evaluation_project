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
    public partial class FormDev : FormProject {
        public FormDev() {
            InitializeComponent();
            SetTheme();
        }
        public override void SetTheme() {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor) {
                BackColor = Theme.activeTheme.panelDesktopColor;
                lblAuthor1.ForeColor = Theme.activeTheme.textColor;
                lblAuthor2.ForeColor = Theme.activeTheme.textColor;
                lblAuthor3.ForeColor = Theme.activeTheme.textColor;
                lblAuthor4.ForeColor = Theme.activeTheme.textColor;
                lblAuthor5.ForeColor = Theme.activeTheme.textColor;
            }
        }
    }
}