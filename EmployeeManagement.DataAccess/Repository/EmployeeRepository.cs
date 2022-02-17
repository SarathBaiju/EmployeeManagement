using EmployeeManagement.DataAccess.Contracts;
using EmployeeManagement.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.DataAccess.Repository
{
    /// <summary>
    /// Connect To Database and Perforum CRUD operations
    /// </summary>
    public class EmployeeRepository : IEmployeeRepository
    {

        public EmployeeData GetEmployeeById(int id)
        {
            //Take data from Table By Id
            return null;
        }

        public IEnumerable<EmployeeData> GetEmployees()
        {
            //Take data from Table
            return null;
        }
        //Create Methods For Table insert, update and Delete Here
    }
}
