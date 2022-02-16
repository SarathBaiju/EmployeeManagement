using EmployeeManagement.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.UI.Controllers.API
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeApiController : ControllerBase
    {
        [HttpGet]
        [Route("{employeeId}")]
        public IActionResult GetEmployeeById([FromRoute]int employeeId)
        {
            var employees = new List<EmployeeDetailedViewModel>()
            {
                new EmployeeDetailedViewModel
                {
                    Name = "sarath",
                    Id = 100,
                    Department = "DEV",
                    Age = 25,
                    Address = "test address"
                },
                 new EmployeeDetailedViewModel
                {
                    Name = "nandu",
                    Id = 91,
                    Department = "DEV",
                    Age = 27,
                    Address = "test address"
                }
            };

            return Ok(employees.Where(s => s.Id == employeeId).FirstOrDefault());
        }
    }
}
