using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teacher_evaluation_project.projectClasses;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace teacher_evaluation_project.Forms
{
    public partial class FormSearch : FormProject
    {
        List<ListViewItem> AllTeachers = new List<ListViewItem>()
        {
            new ListViewItem(new string[]{"Дейнега", "Лариса", "", "Старший викладач", "9,1"}),
            new ListViewItem(new string[]{"Качан", "Лариса", "", "Професор", "9,4"}),
            new ListViewItem(new string[]{"Ав", "Лариса", "", "Доцент", "8,8"}),
            new ListViewItem(new string[]{"П", "Лариса", "", "Завідувач кафедри", "7,9"}),
            new ListViewItem(new string[]{"О", "Лариса", "", "Старший викладач", "9,5"})
        };
        public FormSearch()
        {
            InitializeComponent();
            SetTheme();

            comboBoxPosition.SelectedItem = comboBoxPosition.Items[0];

            // завантаження викладачів 
            foreach (ListViewItem item in AllTeachers)
            {
                listTeachers.Items.Add(item);
            }
            sortComboBox.SelectedItem = sortComboBox.Items[2];
            
        }

        public override void SetTheme()
        {
            SetFont();
            if (BackColor != Theme.activeTheme.panelDesktopColor)
            {
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnSearch.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }

        //public override void SetFont()
        //{

        //}

        private void listTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listTeachers.SelectedItems.Count > 0)
            {
                ListViewItem item = listTeachers.SelectedItems[0];
                FormMain.mainForm.formTeacher = new FormTeacher(item);
                FormMain.mainForm.OpenChildForm(FormMain.mainForm.formTeacher);
            }
        }

        private void listTeachers_SizeChanged(object sender, EventArgs e)
        {
            listTeachers.Columns[3].Width = listTeachers.Width - 6 - (listTeachers.Columns[0].Width + listTeachers.Columns[1].Width + listTeachers.Columns[2].Width + listTeachers.Columns[4].Width);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ListViewItem> list = new List<ListViewItem>(AllTeachers);
            if (textBoxSurname.Text.Length > 0)
            {
                list = CustomSearch.SearchByName(list, textBoxSurname.Text, comboBoxPosition.Text);

                listTeachers.Items.Clear();

                foreach (ListViewItem item in list)
                {
                    listTeachers.Items.Add(item);
                }
            }
            else
            {
                list = CustomSearch.SearchByName(list, "", comboBoxPosition.Text);

                listTeachers.Items.Clear();

                foreach (ListViewItem item in list)
                {
                    listTeachers.Items.Add(item);
                }
            }

        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ListViewItem> list = new List<ListViewItem>();

            foreach (ListViewItem item in listTeachers.Items)
            {
                list.Add(item);
            }

            if (sortComboBox.SelectedIndex == 0)
            {
                list = CustomSort.RateAscending(list);
            }
            else if (sortComboBox.SelectedIndex == 1)
            {
                list = CustomSort.RateDescending(list);
            }
            else if (sortComboBox.SelectedIndex == 2)
            {
                list = CustomSort.SurnameAscending(list);
            }
            else if (sortComboBox.SelectedIndex == 3)
            {
                list = CustomSort.SurnameDescending(list);
            }

            listTeachers.Items.Clear();

            foreach (ListViewItem item in list)
            {
                listTeachers.Items.Add(item);
            }
        }
       
    }
}
