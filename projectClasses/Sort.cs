using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher_evaluation_project.projectClasses
{
    internal class CustomSort
    {

        public static void SurnameAscending(List<ListViewItem> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(list, low, high);
                SurnameAscending(list, low, pivotIndex);
                SurnameAscending(list, pivotIndex + 1, high);
            }
        }

        private static int Partition(List<ListViewItem> list, int low, int high)
        {
            ListViewItem pivot = list[low];
            int left = low + 1;
            int right = high;

            while (left <= right)
            {
                if (String.Compare(list[left].SubItems[1].Text, pivot.SubItems[1].Text) <= 0)
                {
                    left++;
                }
                else if (String.Compare(list[right].SubItems[1].Text, pivot.SubItems[1].Text) > 0)
                {
                    right--;
                }
                else
                {
                    ListViewItem temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;

                    left++;
                    right--;
                }
            }

            ListViewItem temp2 = list[low];
            list[low] = list[right];
            list[right] = temp2;

            return right;
        }


        public static List<ListViewItem> SurnameDescending(List<ListViewItem> list)
        {
            if (list.Count <= 1)
                return list;

            int pivotIndex = list.Count / 2;
            ListViewItem pivot = list[pivotIndex];
            List<ListViewItem> left = new List<ListViewItem>();
            List<ListViewItem> right = new List<ListViewItem>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (String.Compare(list[i].SubItems[1].Text, pivot.SubItems[1].Text) > 0)
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<ListViewItem> sorted = SurnameDescending(left);
            sorted.Add(pivot);
            sorted.AddRange(SurnameDescending(right));
            return sorted;
        }

        public static List<ListViewItem> RateAscending(List<ListViewItem> list)
        {
            if (list.Count <= 1)
                return list;

            int pivotIndex = list.Count / 2;
            ListViewItem pivot = list[pivotIndex];
            List<ListViewItem> left = new List<ListViewItem>();
            List<ListViewItem> right = new List<ListViewItem>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (Convert.ToDouble(list[i].SubItems[5].Text) <= Convert.ToDouble(pivot.SubItems[5].Text))
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<ListViewItem> sorted = RateAscending(left);
            sorted.Add(pivot);
            sorted.AddRange(RateAscending(right));
            return sorted;
        }

        public static List<ListViewItem> RateDescending(List<ListViewItem> list)
        {
            if (list.Count <= 1)
                return list;

            int pivotIndex = list.Count / 2;
            ListViewItem pivot = list[pivotIndex];
            List<ListViewItem> left = new List<ListViewItem>();
            List<ListViewItem> right = new List<ListViewItem>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (Convert.ToDouble(list[i].SubItems[5].Text) >= Convert.ToDouble(pivot.SubItems[5].Text))
                {
                    left.Add(list[i]);
                }
                else
                {
                    right.Add(list[i]);
                }
            }

            List<ListViewItem> sorted = RateDescending(left);
            sorted.Add(pivot);
            sorted.AddRange(RateDescending(right));
            return sorted;
        }
    }
}
