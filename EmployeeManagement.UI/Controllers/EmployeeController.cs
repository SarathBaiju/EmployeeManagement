using EmployeeManagement.Application.Contracts;
using EmployeeManagement.UI.Models;
using EmployeeManagement.UI.Providers.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeApiClient _employeeApiClient;

        public EmployeeController(IEmployeeApiClient employeeApiClient)
        {
            this._employeeApiClient = employeeApiClient;
        }

        public IActionResult Index()
        {
            try
            {
                var employees = _employeeApiClient.GetAllEmployee();

                var employeeViewModels = employees.Select(employee => new EmployeeViewModel
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Department = employee.Department
                });
                return View(employeeViewModels);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
