using EmployeeManagement.API.Models;
using EmployeeManagement.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
        [Route("get-all")]
        public IActionResult GetEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployees();

                var employeeDetailedViewModels = new List<EmployeeDetailedViewModel>();

                if (employees == null)
                {
                    return Ok(employeeDetailedViewModels);
                }

                employeeDetailedViewModels = employees.Select(employee => new EmployeeDetailedViewModel
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Department = employee.Department,
                    Age = employee.Age,
                    Address = employee.Address
                }).ToList();

                return Ok(employeeDetailedViewModels);
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpGet]
        [Route("{employeeId}")]
        public IActionResult GetEmployeeById([FromRoute] int employeeId)
        {
            try
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
            catch (Exception)
            {
                throw;
            }

        }

    }
}
