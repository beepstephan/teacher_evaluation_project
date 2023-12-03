using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                Regex regex = new Regex(@"(\w+)");
                MatchCollection matches = regex.Matches(input);

                foreach (ListViewItem teacher in list)
                {
                    string fullName = teacher.Text + " " + teacher.SubItems[1].Text + " " + teacher.SubItems[2].Text;
                    if (IsContains(fullName, matches))
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
                Regex regex = new Regex(@"(\w+)");
                MatchCollection matches = regex.Matches(input);

                foreach (ListViewItem teacher in list)
                {
                    string fullName = teacher.Text + " " + teacher.SubItems[1].Text + " " + teacher.SubItems[2].Text;
                    if (IsContains(fullName, matches) && position.Contains(teacher.SubItems[3].Text))
                    {
                        result.Add(teacher);
                    }
                }
            }

            return result;
        }

        private static bool IsContains(string fullName, MatchCollection names)
        {
            foreach (Match name in names)
            {
                if (!fullName.Contains(name.Value, StringComparison.OrdinalIgnoreCase))
                    return false;
            }
            return true;
        }

    }
}
