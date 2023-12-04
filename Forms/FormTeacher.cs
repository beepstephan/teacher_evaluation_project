using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
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
        public FormTeacher()
        {
            InitializeComponent();
            SetTheme();
        }
        public FormTeacher(ListViewItem item)
        {
            InitializeComponent();
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
    }
}
