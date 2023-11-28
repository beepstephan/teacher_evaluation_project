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
        protected int themeIndex = 0;
        protected float fontSize = 10;
        protected string fontStyle = "Microsoft Sans Serif";

        public FormProject() {
            InitializeComponent();
        }

        public virtual void SetTheme() {}
        public virtual void SetFont() {
            if (fontStyle != Theme.fontStyle || fontSize != Theme.fontSize)
            {
                fontStyle = Theme.fontStyle;
                fontSize = Theme.fontSize;
                foreach (Control item in Controls)
                {
                    item.Font = new System.Drawing.Font(Theme.fontStyle, Theme.fontSize, System.Drawing.FontStyle.Regular);
                }
            }
        }
    }
}