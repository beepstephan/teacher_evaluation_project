using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_evaluation_project.projectClasses
{
    static class CustomSearch
    {
        public static List<ListViewItem> SearchByName(List<ListViewItem> list, string input, string position)
        {
            List<ListViewItem> result = new List<ListViewItem>();
            if (position == "Усі посади")
            {
                foreach (ListViewItem teacher in list)
                {
                    if (teacher.Text.Contains(input, StringComparison.OrdinalIgnoreCase))
                        result.Add(teacher);
                }
            }
            else if (input.Length == 0)
            {
                foreach (ListViewItem teacher in list)
                {
                    if (position.Contains(teacher.SubItems[3].Text))
                    {
                        result.Add(teacher);
                    }
                }
            }
            else
            {
                foreach (ListViewItem teacher in list)
                {
                    if (teacher.Text.Contains(input, StringComparison.OrdinalIgnoreCase) &&
                        position.Contains(teacher.SubItems[3].Text))
                    {
                        result.Add(teacher);
                    }
                }
            }

            return result;
        }

    }
}
