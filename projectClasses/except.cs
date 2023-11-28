using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using teacher_evaluation_project.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace teacher_evaluation_project.projectClasses
{
    internal class Except
    {
        public string namepattern = "^[А-ЩЬЮЯЇІЄҐґа-щьюяїієґҐ ]+$";
        public string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}$";
        public bool ExceptionsRegistration(string Name, string Surname, string Email, string Password)
        {
            if (IsValidUsername(Name) && IsValidPassword(Password) && IsValidEmail(Email)&& IsValidSurname(Surname))
            {
                MessageBox.Show("Реєстрація пройшла успішно!");
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
                MessageBox.Show("Авторизація пройшла успішно!");
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
            if (IsValidUsername(Name) && IsValidKafedra(Kafedra))
            {
                MessageBox.Show("Пошук пройшов успішно!");
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
            // Логіка перевірки логіну (наприклад, мінімальна довжина)
            return Regex.IsMatch(username, namepattern) && !string.IsNullOrEmpty(username) && username.Length >1&& username.Length<25;
        }
        private bool IsValidKafedra(string username)
        {

            return Regex.IsMatch(username, namepattern) && !string.IsNullOrEmpty(username) && username.Length > 1 && username.Length < 25;
        }
        private bool IsValidSurname(string Surname)
        {
            // Логіка перевірки логіну (наприклад, мінімальна довжина)
            return Regex.IsMatch(Surname, namepattern) && !string.IsNullOrEmpty(Surname) && Surname.Length >1 && Surname.Length < 40;
        }

        private bool IsValidPassword(string password)
        {
            // Логіка перевірки паролю (наприклад, мінімальна довжина, використання різних символів)
            return !string.IsNullOrEmpty(password) && password.Length >8 && password.Length < 16;
        }

        private bool IsValidEmail(string email)
        {
            // Логіка перевірки електронної пошти за допомогою регулярного виразу
            return Regex.IsMatch(email, emailPattern);
        }

    }
}
