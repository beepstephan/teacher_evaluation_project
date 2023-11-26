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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isLogIn { get; set; }

        // конструктори
        public User()
        {
            isLogIn = true;
        }

        // шось с реєстрацією
    }
}
