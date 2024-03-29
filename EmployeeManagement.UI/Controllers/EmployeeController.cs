﻿using EmployeeManagement.Application.Contracts;
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

                //Dummy Data Need to Replace with employees object
                var employeeViewModels = new List<EmployeeViewModel>()
                {
                    new EmployeeViewModel
                    {
                        Id = 1,
                        Name = "Dummy Name",
                        Department = "Dummy Department"
                    }
                };
                return View(employeeViewModels);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
