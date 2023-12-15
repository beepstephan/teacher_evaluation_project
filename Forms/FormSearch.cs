using System.Data;
using teacher_evaluation_project.projectClasses;
using MySql.Data.MySqlClient;


namespace teacher_evaluation_project.Forms
{
    public partial class FormSearch : FormProject
    {
        private List<ListViewItem> AllTeachers = new List<ListViewItem>();

        public FormSearch()
        {
            InitializeComponent();
            SetTheme();

            textBoxSurname.AddPlaceholder("Введіть дані");
            if (FormMain.mainForm != null)
            {
                LoadTeachers();
                comboBoxPosition.SelectedItem = comboBoxPosition.Items[0];
                sortComboBox.SelectedItem = sortComboBox.Items[2];
            }
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


        public MySqlConnection connection;
        public MySqlCommand command;
        const string connect = "server=localhost;port=3306;username=root;password=root;database=teachers";


        public async void LoadTeachers()
        {
            try
            {
                connection = new MySqlConnection(connect);
                connection.Open();

                string script = "SELECT id, surname, name, middlename, pos, rate FROM `dep`";
                MySqlDataAdapter adapter = new MySqlDataAdapter(script, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    //string updatedRate = Convert.ToDouble(dr["rate"]).ToString("#,##");

                    ListViewItem listitem = new ListViewItem(new string[] { dr["id"].ToString(), dr["surname"].ToString(), dr["name"].ToString(), dr["middlename"].ToString(), dr["pos"].ToString(), dr["rate"].ToString(), });

                    AllTeachers.Add(listitem);
                }
                foreach (ListViewItem item in AllTeachers)
                {
                    listTeachers.Items.Add(item);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                await Task.Delay(100);
                FormMain.mainForm.OpenChildForm(FormMain.mainForm.formHome);
                FormMain.mainForm.ActivateMenuItem(FormMain.mainForm.btnHome);
            }
        }
        private void listTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTeachers.SelectedItems.Count > 0)
            {
                ListViewItem item = listTeachers.SelectedItems[0];
                FormMain.mainForm.formTeacher = new FormTeacher(Convert.ToInt32(item.Text));
                FormMain.mainForm.OpenChildForm(FormMain.mainForm.formTeacher);
            }
        }

        private void listTeachers_SizeChanged(object sender, EventArgs e)
        {
            listTeachers.Columns[4].Width = listTeachers.Width - 21 - (listTeachers.Columns[0].Width + listTeachers.Columns[1].Width + listTeachers.Columns[2].Width + listTeachers.Columns[3].Width + listTeachers.Columns[5].Width);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Except SearchException = new Except();
                List<ListViewItem> list = new List<ListViewItem>(AllTeachers);
                if (textBoxSurname.Text != "Введіть дані")
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
                sortComboBox_SelectedIndexChanged(sortComboBox, e);

                if (listTeachers.Items.Count == 0)
                {
                    string msg = "За вашим запитом не знайдено жодного викладача!";
                    throw new Except(msg);
                }
            }
            catch (Except ex)
            {
                MessageBox.Show(ex.Message, "Помилка запиту", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CustomSort.SurnameAscending(list, 0, list.Count() - 1);
            }
            else if (sortComboBox.SelectedIndex == 3)
            {
                CustomSort.SurnameDescending(list, 0, list.Count() - 1);
            }

            listTeachers.Items.Clear();

            foreach (ListViewItem item in list)
            {
                listTeachers.Items.Add(item);
            }
        }

    }
}
