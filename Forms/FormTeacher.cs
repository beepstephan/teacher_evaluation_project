﻿using Microsoft.Data.SqlClient;
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
using System.Xml.Linq;
using teacher_evaluation_project.projectClasses;

namespace teacher_evaluation_project.Forms
{
    public partial class FormTeacher : FormProject
    {
        List<Comment> commentList = new List<Comment>();
        string teacherSurname, teacherName, teacherMiddlename, teacherPosition, teacherDescription, teacherSubjects, teacherRate;
        
        string jsonComments;
        TableLayoutPanel tableComments;
        int id;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FormTeacher()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            SetTheme();
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FormTeacher(int id)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();

            this.id = id;
            getInfo();

            lblName.Text = $"{teacherSurname} {teacherName} {teacherMiddlename}";
            lblPosition.Text = $"Посада: {teacherPosition}";
            lblSubject.Text = $"Дисципліни: {teacherSubjects}";
            lblDescription.Text = $"Опис: {teacherDescription}";
            lblGpa.Text = $"Середня оцінка: {teacherRate}/10";
            
            LoadComments();
            SetTheme();
        }

        private void getInfo()
        {
            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `dep` WHERE `id` = @uID", database.getConnection());
            command.Parameters.Add("@uID", MySqlDbType.Int32).Value = id;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow dr = table.Rows[0];
            
#pragma warning disable CS8601 // Possible null reference assignment.
            teacherSurname = dr["surname"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
            teacherName = dr["name"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
            teacherMiddlename = dr["middlename"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
            teacherPosition = dr["pos"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
            teacherDescription = dr["description"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
            teacherSubjects = dr["subjects"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
            teacherRate = dr["rate"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
            jsonComments = dr["comments"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.

            byte[] teacherImg = (byte[])dr["image"];
            MemoryStream ms = new MemoryStream(teacherImg);
            photoTeacher.Image = Image.FromStream(ms);
            database.closeConnection();
        }
        private void btnComment_Click(object sender, EventArgs e)
        {
            // відкриття форми коментування
            FormMain.mainForm.formComent = new FormComment(id, commentList, teacherName, teacherSurname, teacherMiddlename);
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
                
#pragma warning disable CS8601 // Possible null reference assignment.
                commentList = JsonConvert.DeserializeObject<List<Comment>>(jsonComments);
#pragma warning restore CS8601 // Possible null reference assignment.



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
#pragma warning disable CS8602 // Dereference of a possibly null reference.
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
#pragma warning restore CS8602 // Dereference of a possibly null reference.

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
