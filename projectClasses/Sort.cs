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
                int pivotIndex = PartitionAscending(list, low, high);
                SurnameAscending(list, low, pivotIndex);
                SurnameAscending(list, pivotIndex + 1, high);
            }
        }

        private static int PartitionAscending(List<ListViewItem> list, int low, int high)
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


        public static void SurnameDescending(List<ListViewItem> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionDescending(list, low, high);
                SurnameDescending(list, low, pivotIndex);
                SurnameDescending(list, pivotIndex + 1, high);
            }
        }

        private static int PartitionDescending(List<ListViewItem> list, int low, int high)
        {
            ListViewItem pivot = list[low];
            int left = low + 1;
            int right = high;

            while (left <= right)
            {
                if (String.Compare(list[left].SubItems[1].Text, pivot.SubItems[1].Text) > 0)
                {
                    left++;
                }
                else if (String.Compare(list[right].SubItems[1].Text, pivot.SubItems[1].Text) <= 0)
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


        public static void RateAscending(List<ListViewItem> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionRateAscending(list, low, high);
                RateAscending(list, low, pivotIndex);
                RateAscending(list, pivotIndex + 1, high);
            }
        }

        private static int PartitionRateAscending(List<ListViewItem> list, int low, int high)
        {
            ListViewItem pivot = list[low];
            int left = low + 1;
            int right = high;

            while (left <= right)
            {
                if (Convert.ToDouble(list[left].SubItems[5].Text) <= Convert.ToDouble(pivot.SubItems[5].Text))
                {
                    left++;
                }
                else if (Convert.ToDouble(list[right].SubItems[5].Text) > Convert.ToDouble(pivot.SubItems[5].Text))
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


        public static void RateDescending(List<ListViewItem> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionRateDescending(list, low, high);
                RateDescending(list, low, pivotIndex);
                RateDescending(list, pivotIndex + 1, high);
            }
        }

        private static int PartitionRateDescending(List<ListViewItem> list, int low, int high)
        {
            ListViewItem pivot = list[low];
            int left = low + 1;
            int right = high;

            while (left <= right)
            {
                if (Convert.ToDouble(list[left].SubItems[5].Text) >= Convert.ToDouble(pivot.SubItems[5].Text))
                {
                    left++;
                }
                else if (Convert.ToDouble(list[right].SubItems[5].Text) < Convert.ToDouble(pivot.SubItems[5].Text))
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

    }
}
