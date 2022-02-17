using EmployeeManagement.DataAccess.Contracts;
using EmployeeManagement.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.DataAccess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<EmployeeData> _employeeDatas;

        public EmployeeRepository()
        {
            _employeeDatas = new List<EmployeeData>
            {
                 new EmployeeData
                {
                    Name = "John",
                    Id = 100,
                    Department = "DEV",
                    Age = 25,
                    Address = "London"
                },
                 new EmployeeData
                {
                    Name = "Maria",
                    Id = 91,
                    Department = "DEVOPS",
                    Age = 27,
                    Address = "Mumbai"
                },
                 new EmployeeData
                {
                    Name = "Vishnu",
                    Id = 101,
                    Department = "DEV",
                    Age = 26,
                    Address = "Kerala"
                },
                 new EmployeeData
                {
                    Name = "Aravind",
                    Id = 92,
                    Department = "TESTING",
                    Age = 26,
                    Address = "Ernakulam"
                }
            };
        }

        public EmployeeData GetEmployeeById(int id)
        {
            return _employeeDatas.Where(employee => employee.Id == id).FirstOrDefault();
        }

        public IEnumerable<EmployeeData> GetEmployees()
        {
            return _employeeDatas;
        }
    }
}
