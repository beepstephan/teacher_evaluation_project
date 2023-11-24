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
    public partial class FormComent : FormProject {
        public FormComent() {
            InitializeComponent();
            SetTheme();
        }
        public FormComent(ListViewItem item) {
            InitializeComponent();
            SetTheme();
            lblName.Text = $"{item.Text} {item.SubItems[1].Text} {item.SubItems[2].Text}";
        }

        private void button1_Click(object sender, EventArgs e) {
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formSearch);
        }
        public override void SetTheme() {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor) {
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnDone.BackColor = Theme.activeTheme.mainMenuColor;
                lblCounter.ForeColor = Theme.activeTheme.textColor;
                lblName.ForeColor = Theme.activeTheme.textColor;
            }
        }

        public override void SetFont() {
            if (Font != new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))) {
                foreach (Control btn in Controls) {
                    btn.Font = new System.Drawing.Font(Theme.fontStyle, Theme.textSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            lblCounter.Text = "Символів: " + TextBoxComent.Text.Length.ToString() + "/250";
            Update();
        }
    }
}
