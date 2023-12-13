
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
