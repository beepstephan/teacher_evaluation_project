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
    public partial class FormFaq : FormProject
    {
        public FormFaq()
        {
            InitializeComponent();
            SetTheme();
            //labelGuide.Text = "Крок 1: \n Авторизуйтесь у вікні \"Увійти\", " +
            //    "якщо у вас немає акаунту, зареєструйтесь, натиснувши " +
            //    "на текст \"Ще немає облікового запису?\" \n Крок 2: \n Перейдіть" +
            //    " до головного меню і натисніть на вікно \"Пошук викладачів\" \n Крок 3: \n";
        }
        public override void SetTheme()
        {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor)
            {
                BackColor = Theme.activeTheme.panelDesktopColor;
            }
        }
    }
}
