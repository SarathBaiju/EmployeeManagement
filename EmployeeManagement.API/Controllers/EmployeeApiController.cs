using EmployeeManagement.API.Models;
using EmployeeManagement.Application.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeApiController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        [Route("{employeeId}")]
        public IActionResult GetEmployeeById([FromRoute] int employeeId)
        {
            var employee = _employeeService.GetEmployeeById(employeeId);

            var employeeDetailedViewModel = new EmployeeDetailedViewModel();
            if (employee == null)
            {
                return Ok(employeeDetailedViewModel);
            }

            employeeDetailedViewModel = new EmployeeDetailedViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                Age = employee.Age,
                Address = employee.Address
            };

            return Ok(employeeDetailedViewModel);
        }

    }
}
