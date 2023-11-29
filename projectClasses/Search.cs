using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_evaluation_project.projectClasses
{
    static class CustomSearch
    {
        public static List<ListViewItem> SearchByName(List<ListViewItem> list, string input)
        {
            List<ListViewItem> result = new List<ListViewItem>();
            foreach (ListViewItem teacher in list)
            {
                if (teacher.Text.Contains(input, StringComparison.OrdinalIgnoreCase))
                    result.Add(teacher);
            }

            return result;
        }
    }
}
