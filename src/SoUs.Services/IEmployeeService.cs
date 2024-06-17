using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SoUs.Services
{
    public interface IEmployeeService
    {
        Employee Employee { get; set; }

        Task<Employee> GetEmployeeFromIdAsync(int id);
    }
}
