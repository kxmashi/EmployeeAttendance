using EmployeeAttendance.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAttendance.Data 

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet <Attendance> Attendances { get; set; }

    }
}

