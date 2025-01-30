using EmployeeAttendance.Models;
using EmployeeAttendance.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAttendance.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository) 
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var employees = await _employeeRepository.GetEmployeesAsync();

                return Ok(employees);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
  
                var employee = await _employeeRepository.GetEmployeeByIdAsync(id);
                if (employee == null) return NotFound();
                return Ok(employee);

        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            try
            {
                var newEmployee = await _employeeRepository.AddEmployeeAsync(employee);
                return CreatedAtAction(nameof(AddEmployee), newEmployee);
            }
            catch (Exception) { return null; }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
        {
            try
            {
                var updatedEmployee = await _employeeRepository.UpdateEmployeeAsync(id, employee);
                if (updatedEmployee == null) return NotFound();
                return Ok(updatedEmployee);
            }
            catch (Exception) { return null; }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            try
            {
                var result = await _employeeRepository.DeleteEmployeeAsync(id);
                if (!result) return NotFound();
                return NoContent();
            }
            catch(Exception) { return null; }
        }
    }
}
