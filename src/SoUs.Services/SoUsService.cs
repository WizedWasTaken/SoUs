using SoUs.Entities;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Json;

namespace SoUs.Services
{
    public class SoUsService : ApiBase, ISoUsService
    {
        public SoUsService(Uri baseUri) : base(baseUri) { }

        public SoUsService(string baseUri) : base(baseUri) { }

        public async Task<List<Assignment>> GetAssignmentsAsync(DateTime date, Employee employee)
        {
            try {
                List<Assignment> assignmentList = new();
                date = new DateTime(2024, 05, 24);

                var response = await GetHttpAsync($"Assignment/GetAssignmentsForEmployeeByDate?date={date.ToString("yyyy-MM-dd")}&employeeId={employee.EmployeeId}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new DataException("Kunne ikke hente opgaver");
                }

                assignmentList = await response.Content.ReadFromJsonAsync<List<Assignment>>();

                return assignmentList;
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
