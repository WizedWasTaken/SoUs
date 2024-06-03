using SoUs.Entities;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Json;
using SoUs.DataObjects;

namespace SoUs.Services
{
    public class SoUsService : ApiBase, ISoUsService
    {
        public SoUsService(Uri baseUri) : base(baseUri) { }

        public SoUsService(string baseUri) : base(baseUri) { }

        public async Task<List<ResidentWithAssignmentsDTO>> GetAssignmentsAsync(DateTime date, Employee employee)
        {
            try {
                List<ResidentWithAssignmentsDTO> assignmentList = new();

                var response = await GetHttpAsync($"Resident/GetResidentsTasksOnDateAndEmployee?date=2024-05-24&employeeId={employee.EmployeeId}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new DataException("Kunne ikke hente opgaver");
                }

                assignmentList = await response.Content.ReadFromJsonAsync<List<ResidentWithAssignmentsDTO>>();

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
