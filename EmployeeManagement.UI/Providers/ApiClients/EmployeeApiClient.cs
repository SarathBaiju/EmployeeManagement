using EmployeeManagement.UI.Models.Provider;
using EmployeeManagement.UI.Providers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.UI.Providers.ApiClients
{
    public class EmployeeApiClient :BaseHttpClient, IEmployeeApiClient
    {
        private const string RELATIVE_GET_EMPLOYEE_URI = "/api/employee/{0}";

        public EmployeeApiClient(HttpClient httpClient):base(httpClient)
        {

        }

        public EmployeeData GetEmployeeById(int id)
        {
            return ExecuteGet<EmployeeData>(string.Format(RELATIVE_GET_EMPLOYEE_URI, id));
        }
    }
}
