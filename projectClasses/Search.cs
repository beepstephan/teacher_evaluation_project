﻿using System.Text.RegularExpressions;

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
                    string fullName = teacher.SubItems[1].Text + " " + teacher.SubItems[2].Text + " " + teacher.SubItems[3].Text;
                    if (IsContains(fullName, matches))
                        result.Add(teacher);
                }
            }
            else if (input.Length == 0)
            {
                foreach (ListViewItem teacher in list)
                {
                    if (position.Contains(teacher.SubItems[4].Text, StringComparison.OrdinalIgnoreCase))
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
                    string fullName = teacher.SubItems[1].Text + " " + teacher.SubItems[2].Text + " " + teacher.SubItems[3].Text;
                    if (IsContains(fullName, matches) && position.Contains(teacher.SubItems[4].Text, StringComparison.OrdinalIgnoreCase))
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
