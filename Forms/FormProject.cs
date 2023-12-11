using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project.Forms
{
    public partial class FormProject : Form {
        protected int themeIndex = 0;
        protected float fontSize = 10;
        protected string fontFamily = "Microsoft Sans Serif";

        public FormProject() {
            InitializeComponent();
        }

        public virtual void SetTheme() {}
        public virtual void SetFont() {
            if (fontFamily != Theme.fontFamily || fontSize != Theme.fontSize)
            {
                fontFamily = Theme.fontFamily;
                fontSize = Theme.fontSize;
                foreach (Control item in Controls)
                {
                    item.Font = new Font(Theme.fontFamily, Theme.fontSize, item.Font.Style);
                }
            }
        }
    }
}