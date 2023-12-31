﻿using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Data;
using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project.Forms
{
    public partial class FormTeacher : FormProject
    {
        List<Comment> commentList = new List<Comment>();

        string jsonComments;
        TableLayoutPanel tableComments;
        int id;
        public FormTeacher()
        {
            InitializeComponent();
            SetTheme();
        }
        public FormTeacher(int id)
        {
            InitializeComponent();

            Teacher.Id = id;
            getInfo();

            lblName.Text = $"{Teacher.Surname} {Teacher.Name} {Teacher.MiddleName}";
            lblPosition.Text = $"Посада: {Teacher.Position}";
            lblSubject.Text = $"Дисципліни: {Teacher.Subjects}";
            lblDescription.Text = $"Опис: {Teacher.Description}";
            lblGpa.Text = $"Середня оцінка: {Teacher.Rate}/10";

            LoadComments();
            SetTheme();
        }

        private void getInfo()
        {
            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `dep` WHERE `id` = @uID", database.getConnection());
            command.Parameters.Add("@uID", MySqlDbType.Int32).Value = Teacher.Id;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow dr = table.Rows[0];

            // заповнення даних викладача з БД 
            Teacher.Surname = dr["surname"].ToString();
            Teacher.Name = dr["name"].ToString();
            Teacher.MiddleName = dr["middlename"].ToString();
            Teacher.Position = dr["pos"].ToString();
            Teacher.Description = dr["description"].ToString();
            Teacher.Subjects = dr["subjects"].ToString();
            Teacher.Rate = dr["rate"].ToString();

            // завантаження коментарів формату JSON з БД
            jsonComments = dr["comments"].ToString();

            // завантаження фото викладача з БД
            byte[] teacherImg = (byte[])dr["image"];
            MemoryStream ms = new MemoryStream(teacherImg);
            photoTeacher.Image = Image.FromStream(ms);
            database.closeConnection();
        }
        private void btnComment_Click(object sender, EventArgs e)
        {
            // відкриття форми коментування
            FormMain.mainForm.formComent = new FormComment(Teacher.Id, commentList, Teacher.Name, Teacher.Surname, Teacher.MiddleName);
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
            if (jsonComments != "null")
            {


                commentList = JsonConvert.DeserializeObject<List<Comment>>(jsonComments);

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
