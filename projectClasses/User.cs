
namespace teacher_evaluation_project.projectClasses
{
    public class User
    {
        // поля
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string Email { get; set; }
        public static bool isLogIn { get; set; }

        // конструктори
        public static void LogIn(int id, string e, string s, string n)
        {
            Id = id;
            Email = e;
            
            Surname = s;
            Name = n;
            isLogIn = false;
        }

        // методи
        public static void LogOut()
        {
            Id = -1;
            Email = "";
            Surname = "";
            Name = "";
            isLogIn = false;
        }
    }
}
