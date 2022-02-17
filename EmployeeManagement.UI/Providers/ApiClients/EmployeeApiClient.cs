using EmployeeManagement.UI.Models.Provider;
using EmployeeManagement.UI.Providers.Contracts;
using System.Collections.Generic;
using System.Net.Http;

namespace EmployeeManagement.UI.Providers.ApiClients
{
    public class EmployeeApiClient :BaseHttpClient, IEmployeeApiClient
    {
        private const string RELATIVE_GET_EMPLOYEE_URI = "/api/employee/{0}";
        private const string RELATIVE_GET_ALL_EMPLOYEE_URI = "/api/employee/get-all";

        public EmployeeApiClient(HttpClient httpClient):base(httpClient)
        {

        }

        public IEnumerable<EmployeeData> GetAllEmployee()
        {
            return ExecuteGet<IEnumerable<EmployeeData>>(RELATIVE_GET_ALL_EMPLOYEE_URI);
        }

        public EmployeeData GetEmployeeById(int id)
        {
            return ExecuteGet<EmployeeData>(string.Format(RELATIVE_GET_EMPLOYEE_URI, id));
        }
    }
}
