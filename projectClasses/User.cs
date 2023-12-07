using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher_evaluation_project.projectClasses
{
    public class User
    {
        // поля
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static bool isLogIn { get; set; }

        // конструктори
        public User()
        {
            isLogIn = false;
        }

        // шось с реєстрацією
    }
}
