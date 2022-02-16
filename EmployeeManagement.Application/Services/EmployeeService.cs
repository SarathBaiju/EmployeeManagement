using EmployeeManagement.Application.Contracts;
using EmployeeManagement.Application.Models;
using EmployeeManagement.DataAccess.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public EmployeeDto GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);

            if(employee == null)
            {
                return null;
            }

            return new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Department = employee.Department
            };
        }

        public IEnumerable<EmployeeDto> GetEmployees()
        {
            var employeeData = _employeeRepository.GetEmployees();

            if(employeeData == null)
            {
                return null;
            }

            return employeeData.Select(employee => new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Department = employee.Department
            });
        }
    }
}
