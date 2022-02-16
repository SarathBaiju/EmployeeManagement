using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.UI.Models
{
    public class EmployeeDetailedViewModel:EmployeeViewModel
    {
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
