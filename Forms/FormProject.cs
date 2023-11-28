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
    public partial class FormProject : Form {
        public FormProject() {
            InitializeComponent();
        }

        public virtual void SetTheme() {}
        public virtual void SetFont() {
            if (Font.FontFamily.Name != Theme.fontStyle || Font.Size != Theme.textSize)
            {
                foreach (Control item in Controls) {
                    item.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular);
                }
            }
        }
    }
}