namespace MyApp_API.Models
{
    public class AttendanceModel
    {
        public DateTime date { get; set; }
        public StatusModel satus { get; set; }
        public string subName{ get; set; }
        public string presentCount { get; set; }
        public string absentCount { get; set; }
    }
}
