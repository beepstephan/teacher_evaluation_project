using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_evaluation_project.projectClasses
{
    internal class Search
    {
        static List<Teacher> SearchByName(List<Teacher> list, string input)
        {
            List<Teacher> result = new List<Teacher>();
            foreach (Teacher teacher in list)
            {
                if (teacher.Surname.Contains(input, StringComparison.OrdinalIgnoreCase))
                    result.Add(teacher);
            }

            return result;
        }
    }
}
