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
    public partial class FormComment : FormProject
    {
        ListViewItem teacher;
        public FormComment()
        {
            InitializeComponent();
            SetTheme();
        }
        public FormComment(ListViewItem item)
        {
            InitializeComponent();
            SetTheme();

            teacher = item;

            // додавання даних на форму
            lblName.Text = $"{item.SubItems[1].Text} {item.SubItems[2].Text} {item.SubItems[3].Text}";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // логіка
            // пошук викладача у БД за ID (teacher.Text)

            // оновлення даних

            // повернення до вікна пошуку викладачів
            FormMain.mainForm.formSearch = new FormSearch();
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formSearch);
        }
        public override void SetTheme()
        {
            SetFont();
            if (themeIndex != Theme.themeIndex)
            {
                themeIndex = Theme.themeIndex;
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnDone.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }

        public override void SetFont()
        {
            if (fontFamily != Theme.fontFamily || fontSize != Theme.fontSize)
            {
                fontFamily = Theme.fontFamily;
                fontSize = Theme.fontSize;
                foreach (Control btn in Controls)
                {
                    btn.Font = new System.Drawing.Font(Theme.fontFamily, Theme.fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            lblCounter.Text = "Символів: " + textBoxComment.Text.Length.ToString() + "/250";
            Update();
        }
    }
}
