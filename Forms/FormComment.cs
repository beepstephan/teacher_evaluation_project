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
using static System.Net.Mime.MediaTypeNames;

namespace teacher_evaluation_project.Forms
{
    public partial class FormComment : FormProject
    {
        int teacherId;
        int commentIndex = -1;
        List<Comment> comments;
        public FormComment()
        {
            InitializeComponent();
            SetTheme();
        }
        public FormComment(int teacherId, List<Comment> comms, string name, string sname, string mname)
        {
            InitializeComponent();

            this.teacherId = teacherId;
            comments = comms;

            for (int i = 0; i < comms.Count; i++)
            {
                if (comms[i].id == User.Id)
                {
                    commentIndex = i;
                    trackBarRate.Value = comms[i].rate;
                    lblRate.Text = $"{comms[i].rate}/10";
                    textBoxComment.Text = comms[i].text;
                    lblCounter.Text = $"Символів:{textBoxComment.Text.Length}/{textBoxComment.MaxLength}";
                    break;
                }
            }

            lblName.Text = $"{sname} {name} {mname}";
            SetTheme();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Except CommentException = new Except();
            bool bothfill = CommentException.IsValidComment(textBoxComment.Text, trackBarRate.Value);
            if (bothfill == true)
            {
                Comment newComment = new Comment(User.Id, DateTime.Now.ToString("dd/MM/yyyy HH:mm"), trackBarRate.Value, textBoxComment.Text);
                if (commentIndex > -1)
                {
                    comments[commentIndex] = newComment;
                }
                else
                {
                    comments.Add(newComment);
                }
                comments = comments.OrderByDescending(o => o.time).ToList();

                int pointSum = 0;
                double readyRate = 0.0;
                foreach (Comment com in comments)
                {
                    pointSum += com.rate;
                }
                readyRate = (double)pointSum / (double)comments.Count;
                Math.Round(readyRate, 2);
                string stringRate = readyRate.ToString();

                string json = JsonConvert.SerializeObject(comments);

                try
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
                    string Query = "update teachers.dep set comments='" + json + "',rate='" + stringRate + "' where id='" + teacherId + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // повернення до вікна пошуку викладачів
                FormMain.mainForm.formSearch = new FormSearch();
                FormMain.mainForm.OpenChildForm(FormMain.mainForm.formSearch);
            }
            else
            {
                MessageBox.Show("Обидва поля повинні бути заповненими!");
            }

        }
        public override void SetTheme()
        {
            SetFont();
            if (themeIndex != Theme.themeIndex)
            {
                themeIndex = Theme.themeIndex;
                BackColor = Theme.activeTheme.panelDesktopColor;
                btnDone.BackColor = Theme.activeTheme.mainMenuColor;
            }
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            lblCounter.Text = "Символів: " + textBoxComment.Text.Length.ToString() + "/250";
            Update();
        }

        private void trackBarRating_ValueChanged(object sender, EventArgs e)
        {
            lblRate.Text = $"{trackBarRate.Value}/10";
        }
    }
}
