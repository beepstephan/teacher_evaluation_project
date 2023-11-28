using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_evaluation_project.projectClasses
{
    public static class PlaceholderManager
    {
        public static void AddPlaceholder(this TextBox field, string textPlaceholder)
        {
            field.Text = textPlaceholder;
            field.ForeColor = Color.Gray;

            field.Enter += (s, e) =>
            {
                if (field.Text == textPlaceholder)
                {
                    field.Text = "";
                    field.ForeColor = Color.Black;
                }
            };

            field.Leave += (s, e) =>
            {
                if (field.Text == "")
                {
                    field.Text = textPlaceholder;
                    field.ForeColor = Color.Gray;
                }
            };
        }
    }
}
