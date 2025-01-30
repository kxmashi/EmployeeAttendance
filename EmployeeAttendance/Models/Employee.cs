using System.ComponentModel.DataAnnotations;

namespace EmployeeAttendance.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }    
        [Required]
        public string Position { get; set; }
    }
}
