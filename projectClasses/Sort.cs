using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_evaluation_project.projectClasses
{
    internal class Sort
    {

        static List<Teacher> SurnameAscending(List<Teacher> list)
        {
            if (list.Count <= 1)
                return list;

            int pivotIndex = list.Count / 2;
            Teacher pivot = list[pivotIndex];
            List<Teacher> left = new List<Teacher>();
            List<Teacher> right = new List<Teacher>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (String.Compare(list[i].Surname, pivot.Surname) <= 0)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<Teacher> sorted = SurnameAscending(left);
            sorted.Add(pivot);
            sorted.AddRange(SurnameAscending(right));
            return sorted;
        }

        static List<Teacher> SurnameDescending(List<Teacher> list)
        {
            if (list.Count <= 1)
                return list;

            int pivotIndex = list.Count / 2;
            Teacher pivot = list[pivotIndex];
            List<Teacher> left = new List<Teacher>();
            List<Teacher> right = new List<Teacher>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (String.Compare(list[i].Surname, pivot.Surname) > 0)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<Teacher> sorted = SurnameDescending(left);
            sorted.Add(pivot);
            sorted.AddRange(SurnameDescending(right));
            return sorted;
        }

        static List<Teacher> RateAscending(List<Teacher> list)
        {
            if (list.Count <= 1)
                return list;

            int pivotIndex = list.Count / 2;
            Teacher pivot = list[pivotIndex];
            List<Teacher> left = new List<Teacher>();
            List<Teacher> right = new List<Teacher>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (list[i].Rate <= pivot.Rate)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<Teacher> sorted = RateAscending(left);
            sorted.Add(pivot);
            sorted.AddRange(RateAscending(right));
            return sorted;
        }

        static List<Teacher> RateDescending(List<Teacher> list)
        {
            if (list.Count <= 1)
                return list;

            int pivotIndex = list.Count / 2;
            Teacher pivot = list[pivotIndex];
            List<Teacher> left = new List<Teacher>();
            List<Teacher> right = new List<Teacher>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (list[i].Rate >= pivot.Rate)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<Teacher> sorted = RateDescending(left);
            sorted.Add(pivot);
            sorted.AddRange(RateDescending(right));
            return sorted;
        }
    }
}
