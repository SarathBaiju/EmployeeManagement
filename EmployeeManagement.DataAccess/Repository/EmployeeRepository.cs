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
                    Name = "sarath",
                    Id = 100,
                    Department = "DEV",
                    Age = 25,
                    Address = "Trivandrum"
                },
                 new EmployeeData
                {
                    Name = "nandu",
                    Id = 91,
                    Department = "DEV",
                    Age = 27,
                    Address = "Alapuzha"
                },
                   new EmployeeData
                {
                    Name = "hari",
                    Id = 101,
                    Department = "DEV",
                    Age = 26,
                    Address = "Thrisur"
                },
                    new EmployeeData
                {
                    Name = "Arun",
                    Id = 92,
                    Department = "DEV",
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
