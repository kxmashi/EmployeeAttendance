using System.ComponentModel.DataAnnotations;

namespace EmployeeAttendance.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeSpan TimeIn { get; set; }
        [Required]
        public TimeSpan? TimeOut { get; set; }
    }
}
