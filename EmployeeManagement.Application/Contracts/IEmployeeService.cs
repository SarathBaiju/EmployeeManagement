﻿using EmployeeManagement.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Contracts
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetEmployees();
        EmployeeDto GetEmployeeById(int id);
       
    }
}
