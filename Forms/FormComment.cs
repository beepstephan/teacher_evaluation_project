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
            
            for(int i=0; i<comms.Count; i++)
            {
                if (comms[i].id == User.Id)
                {
                    commentIndex = i;
                    trackBarRating.Value = comms[i].rate;
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
            Comment newComment = new Comment(User.Id, DateTime.Now.ToString("dd/MM/yyyy HH:mm"), trackBarRating.Value, textBoxComment.Text);
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
            readyRate = (double)pointSum /  (double)comments.Count;
            Math.Round(readyRate, 2);
            string stringRate = readyRate.ToString();

            string json = JsonConvert.SerializeObject(comments);

            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update teachers.dep set comments='" + json + "',rate='" + stringRate + "' where id='" + teacherId + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                
                MyConn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // повернення до вікна пошуку викладачів
            FormMain.mainForm.formSearch = new FormSearch();
            FormMain.mainForm.OpenChildForm(FormMain.mainForm.formSearch);
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

        public override void SetFont()
        {
            if (fontFamily != Theme.fontFamily || fontSize != Theme.fontSize)
            {
                fontFamily = Theme.fontFamily;
                fontSize = Theme.fontSize;
                foreach (Control btn in Controls)
                {
                    btn.Font = new System.Drawing.Font(Theme.fontFamily, Theme.fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            lblCounter.Text = "Символів: " + textBoxComment.Text.Length.ToString() + "/250";
            Update();
        }
    }
}
