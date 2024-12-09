using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace MyApp_API.Models
{
    public class StudentModel
    {
        public string Name { get; set; }
        public int RollNum { get; set; }
        public string Password { get; set; }
        public string ClassName { get; set; }
        public string School { get; set; }
        public ExameResultModel ExamResult { get; set; }
        public string Role { get; set; }
        public AttendanceModel Attendance { get; set; }




    }
}
