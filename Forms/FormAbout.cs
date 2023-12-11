using System.Diagnostics;
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

        private void imgLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void imgTeacherLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            imgLink.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://pz.zp.ua/spivrobitnyky/") { UseShellExecute = true });
        }
    }
}
