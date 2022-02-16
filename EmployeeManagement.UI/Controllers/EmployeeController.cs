using EmployeeManagement.Application.Contracts;
using EmployeeManagement.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employees = _employeeService.GetEmployees();

            var employeeViewModels = employees.Select(employee => new EmployeeViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department
            });
            return View(employeeViewModels);
        }
    }
}
