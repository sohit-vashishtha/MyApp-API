namespace MyApp_API.Models
{
    public class TeacherModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public SubjectModel teacherSubject { get; set; }
        public ClassModel teacherClass { get; set; }
       

    }
}
