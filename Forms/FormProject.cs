using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher_evaluation_project.Forms {
    public partial class FormProject : Form {
        public FormProject() {
            InitializeComponent();
        }

        public virtual void SetTheme() {}
        public virtual void SetFont() {
            if (Font != new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular)) {
                foreach (Control item in Controls) {
                    item.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular);
                }
            }
        }
    }
}