namespace MyApp_API.Models
{
    public class SubjectModel
    {
        public string subName { get; set; }
        public string subCode { get; set; }
        public string sessions {  get; set; }
        public ClassModel className{ get;set; }
        public TeacherModel teacher { get; set; }
    }
}
