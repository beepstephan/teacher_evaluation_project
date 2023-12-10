using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using teacher_evaluation_project.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace teacher_evaluation_project.projectClasses
{
    internal class Except:Exception
    {
        public string namepattern = "^[А-ЩЬЮЯЇІЄҐґа-щьюяїієґҐ]+$";
        public string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}$"; // це чисто патерни для перевірки вмісту ну там шоб не було різних незроз символів і якойсь хуйні
        public Except() { 
        
        }
        public bool ExceptionsRegistration(string Name, string Surname, string Email, string Password)
        {
            if (IsValidUsername(Name) && IsValidPassword(Password) && IsValidEmail(Email)&& IsValidSurname(Surname))
            {
                MessageBox.Show("Реєстрація пройшла успішно!"); //perevirka reestacii
                return true;
            }
            else
            {
                MessageBox.Show("Помилка при реєстрації. Перевірте правильність введених даних.");
                return false;
            }
        }
        public bool ExceptionsLogin( string Email, string Password)
        {
            if (IsValidPassword(Password) && IsValidEmail(Email))
            {
                MessageBox.Show("Авторизація пройшла успішно!"); // perevirka logina 
                return true;
            }
            else
            {
                MessageBox.Show("Помилка при авторизації. Перевірте правильність введених даних.");
                return false;
            }
        }

        public bool ExceptionSearch(string Name, string Kafedra)
        {
            if (IsValidUsername(Name) && IsValidVikladach(Kafedra))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Помилка при пошуку. Перевірте правильність введених даних.");
                return false;
            }
        }

        private bool IsValidUsername(string username)
        {
            // perevirka logina maks i min dovzhina 
            return Regex.IsMatch(username, namepattern) && !string.IsNullOrEmpty(username) && username.Length >1&& username.Length<25;
        }
       
        private bool IsValidSurname(string Surname)
        {
           //perevirka familii mas i min dovzhina 
            return Regex.IsMatch(Surname, namepattern) && !string.IsNullOrEmpty(Surname) && Surname.Length >1 && Surname.Length < 40;
        }

        private bool IsValidPassword(string password)
        {
            //perevirka parolya 
            return !string.IsNullOrEmpty(password) && password.Length >8 && password.Length < 16;
        }

        private bool IsValidEmail(string email)
        {
         // perevirka imeila
            return Regex.IsMatch(email, emailPattern);
        }
        private bool IsValidVikladach(string username)
        {

            return !string.IsNullOrEmpty(username) && username.Length > 1 && username.Length < 50;
        }
        public bool IsValidComment(string text, int rate)
        {
            if (!String.IsNullOrEmpty(text)&&rate!=1)
            {
                return true;
            }
            else
            {
                return false;
                MessageBox.Show("Обидва поля повинні бути заповненими!");
            }
        }
        public bool IsValidConnection(string conn)
        {
            bool result = false;
            MySqlConnection connection = new MySqlConnection(conn);
            try
            {

                connection.Open();

                result = true;

                connection.Close();

            }

            catch

            {

                result = false;
                MessageBox.Show("Не вдалося підключитися до сервера. Приносимо вибачення");
            }
            return result;
        }

    }
}
