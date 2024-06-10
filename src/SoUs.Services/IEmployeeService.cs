using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
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

    public class EmployeeService : ApiBase, IEmployeeService
    {

        // Constructors
        public EmployeeService(Uri baseUri) : base(baseUri) { }

        public EmployeeService(string baseUri) : base(baseUri) { }

        public Employee Employee { get; set; }

        public async Task<Employee> GetEmployeeFromIdAsync(int id)
        {
            try
            {
                Employee e = default;

                var response = await GetHttpAsync($"Employee/GetEmployeeById?id={id}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Error: {response.StatusCode}");
                }

                e = await response.Content.ReadFromJsonAsync<Employee>();

                return e;
            }
            catch (Exception ex)
            {
                // Log the detailed exception message and stack trace
                Debug.WriteLine($"General exception: {ex.Message}");
                Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
                if (ex.InnerException != null)
                {
                    Debug.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                throw new ApplicationException("An unexpected error occurred.", ex);
            }
        }
    }
}
