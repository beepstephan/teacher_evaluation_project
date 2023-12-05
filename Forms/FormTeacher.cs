using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project.Forms
{
    public partial class FormTeacher : FormProject
    {
        ListViewItem teacher;
        string teacherSurname, teacherName, teacherMiddlename, teacherPosition, teacherDescription, teacherSubjects, teacherRate;
        int teacherRatePoints, teacherRateCounter;
        TableLayoutPanel tableComments;

        public FormTeacher()
        {
            InitializeComponent();
            SetTheme();
        }
        public FormTeacher(ListViewItem item)
        {
            InitializeComponent();
            // запит з БД або отримання JSON з переданого параметра
            // тільки тоді виведення коментарів
            LoadComments();
            SetTheme();

            teacher = item;
            string id = item.Text;

            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `dep` WHERE `id` = @uID ", database.getConnection());
            command.Parameters.Add("@uID", MySqlDbType.VarChar).Value = id;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow dr = table.Rows[0];
            teacherSurname = dr["surname"].ToString();
            teacherName = dr["name"].ToString();
            teacherMiddlename = dr["middlename"].ToString();
            teacherPosition = dr["pos"].ToString();
            teacherDescription = dr["description"].ToString();
            teacherSubjects = dr["subjects"].ToString();
            teacherRatePoints = Convert.ToInt32(dr["ratepoints"].ToString());
            teacherRateCounter = Convert.ToInt32(dr["ratecounter"].ToString());
            teacherRate = dr["rate"].ToString();

            MySqlDataAdapter da = new MySqlDataAdapter();
            //Retrieve BLOB from database into DataSet.
            MySqlCommand cmd = new MySqlCommand("SELECT image FROM `dep` WHERE `id` = @ID", database.getConnection());
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "dep");
            int c = ds.Tables["dep"].Rows.Count;

            if (c > 0)
            {
                //BLOB is read into Byte array, then used to construct MemoryStream,
                //then passed to PictureBox.
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])(ds.Tables["dep"].Rows[c - 1]["image"]);
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                photoTeacher.Image = Image.FromStream(stmBLOBData);
            }
            database.closeConnection();

            lblName.Text = $"{item.SubItems[1].Text} {item.SubItems[2].Text} {item.SubItems[3].Text}";
            lblPosition.Text = $"Посада: {teacherPosition}";
            lblSubject.Text = $"Дисципліни: {teacherSubjects}";
            lblDescription.Text = $"Опис: {teacherDescription}";
            lblGpa.Text = $"Середня оцінка: {teacherRate}/10";
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            // відкриття форми коментування
            FormMain.mainForm.formComent = new FormComment(teacher);
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formComent);
        }
        public override void SetTheme()
        {
            SetFont();
            if (themeIndex != Theme.themeIndex)
            {
                themeIndex = Theme.themeIndex;
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnComment.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }

        public override void SetFont()
        {
            if (fontFamily != Theme.fontFamily || fontSize != Theme.fontSize)
            {
                fontFamily = Theme.fontFamily;
                fontSize = Theme.fontSize;
                foreach (Control item in Controls)
                {
                    item.Font = new System.Drawing.Font(Theme.fontFamily, Theme.fontSize, item.Font.Style);
                }
                if (tableComments != null)
                {
                    foreach (Control tableItem in tableComments.Controls)
                    {
                        foreach (Control commentLbl in tableItem.Controls)
                        {
                            commentLbl.Font = new System.Drawing.Font(Theme.fontFamily, Theme.fontSize, commentLbl.Font.Style);
                        }
                    }
                }
            }
        }

        public void LoadComments()
        {
            // JSON to List<Comments>
            /*string json;// = dataTable.json;
            List<Comment> commentList = new List<Comment>();
            commentList = JsonConvert.DeserializeObject<List<Comment>>(json);*/

            List<Comment> commentList = new List<Comment>()
            {
                new Comment(1234, "19.07.1763 15:02:00", 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."),
                new Comment(4321, "20.10.2022 01:31:00", 7, "Дев'ять чи десять?")
            };

            // створення таблиці коментарів
            tableComments = new TableLayoutPanel()
            {
                Name = "tableComments",
                Location = new Point(37, 229),
                Size = new Size(535, 80),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,

                ColumnCount = 1,
                RowCount = 0
            };
            tableComments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            // додавання до таблиці коментарів
            for (int i = 0; i < commentList.Count; i++)
            {
                // створення tableItem
                TableLayoutPanel tableItem = new TableLayoutPanel()
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Dock = DockStyle.Fill,

                    ColumnCount = 1,
                    RowCount = 3
                };
                tableItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                // створення lbl
                Label lblTitle = new Label() { AutoSize = true, Text = $"{commentList[i].id}, {commentList[i].time}", ForeColor = Color.Gainsboro, Margin = new Padding(3, 3, 3, 5) };
                Label lblRate = new Label() { AutoSize = true, Text = $"Оцінка: {commentList[i].rate}", ForeColor = Color.Gainsboro, Margin = new Padding(3, 3, 3, 5) };
                Label LblbText = new Label() { AutoSize = true, Text = $"{commentList[i].text}", ForeColor = Color.Gainsboro, Margin = new Padding(3, 3, 3, 20) };

                // додавання lbl в tableItem
                tableItem.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableItem.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableItem.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableItem.Controls.Add(lblTitle, 0, 0);
                tableItem.Controls.Add(lblRate, 0, 1);
                tableItem.Controls.Add(LblbText, 0, 2);

                // додавання рядка
                tableComments.RowCount++;
                tableComments.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // додавання tableItem в рядок
                tableComments.Controls.Add(tableItem, 0, i);
            }

            Controls.Add(tableComments);
        }

        private void FormTeacher_SizeChanged(object sender, EventArgs e)
        {
            if (tableComments != null)
            {
                foreach (Control tableItem in tableComments.Controls)
                {
                    foreach (Control commentItem in tableItem.Controls)
                    {
                        commentItem.MaximumSize = new Size(tableItem.Width, 1000);
                    }
                }
            }
        }
    }
}
