namespace teacher_evaluation_project.projectClasses
{
    public class Comment
    {
        public int id { get; set; }
        public string time { get; set; }
        public int rate { get; set; }
        public string text { get; set; }

        public Comment(int i, string tm, int r, string tx)
        {
            id = i;
            time = tm;
            rate = r;
            text = tx;            
        }
    }
}
