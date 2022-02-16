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
        public IActionResult Index()
        {
            var employees = new List<EmployeeViewModel>()
            {
                new EmployeeViewModel
                {
                    Name = "sarath",
                    Id = 100,
                    Department = "DEV"
                },
                 new EmployeeViewModel
                {
                    Name = "nandu",
                    Id = 91,
                    Department = "DEV"
                }
            };
            
            return View(employees);
        }
    }
}
