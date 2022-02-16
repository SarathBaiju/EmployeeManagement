using EmployeeManagement.UI.Models.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.UI.Providers.Contracts
{
    public interface IEmployeeApiClient
    {
        EmployeeData GetEmployeeById(int id);
    }
}
