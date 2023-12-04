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
        List<ListViewItem> AllTeachers = new List<ListViewItem>();
        public FormSearch()
        {
            InitializeComponent();
        }
        public FormSearch(List<ListViewItem> AllTeachers)
        {
            InitializeComponent();
            SetTheme();
            
            this.AllTeachers = AllTeachers;
            textBoxSurname.AddPlaceholder("Введіть прізвище");
            
            foreach (ListViewItem item in AllTeachers)
            {
                ListViewItem i = item;
                listTeachers.Items.Add(i);
            }
            comboBoxPosition.SelectedItem = comboBoxPosition.Items[0];
            sortComboBox.SelectedItem = sortComboBox.Items[2];
        }
        public override void SetTheme()
        {
            SetFont();
            if (themeIndex != Theme.themeIndex)
            {
                themeIndex = Theme.themeIndex;
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnSearch.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }

  
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
            listTeachers.Columns[4].Width = listTeachers.Width - 21 - (listTeachers.Columns[0].Width + listTeachers.Columns[1].Width + listTeachers.Columns[2].Width + listTeachers.Columns[3].Width + listTeachers.Columns[5].Width);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ListViewItem> list = new List<ListViewItem>(AllTeachers);
            if (textBoxSurname.Text != "Введіть прізвище")
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

                foreach (ListViewItem item in AllTeachers)
                {
                    listTeachers.Items.Add(item);
                }
            }
            sortComboBox_SelectedIndexChanged(sortComboBox, e);
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
