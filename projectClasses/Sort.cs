using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_evaluation_project.projectClasses
{
    internal class Sort
    {
        static List<string> QuickSort(List<string> list)
        {
            if (list.Count <= 1)
                return list;

            int pivotIndex = list.Count / 2;
            string pivot = list[pivotIndex];
            List<string> left = new List<string>();
            List<string> right = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (String.Compare(list[i], pivot) <= 0)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<string> sorted = QuickSort(left);
            sorted.Add(pivot);
            sorted.AddRange(QuickSort(right));
            return sorted;
        }
    }
}
