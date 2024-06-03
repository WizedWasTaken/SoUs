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
            List<Assignment> assignmentList = new List<Assignment>();
            try { 
                var response = await GetHttpAsync($"Assignment/GetAssignmentsForEmployeeByDate?employeeId=2&date=2024-05-24");

                if (!response.IsSuccessStatusCode)
                {
                    throw new DataException("Kunne ikke hente opgaver");
                }

                assignmentList = await response.Content.ReadFromJsonAsync<List<Assignment>>();

                return assignmentList;
            }
            catch (HttpRequestException ex)
            {
                // Log the detailed exception message and stack trace
                Console.WriteLine($"HttpRequestException: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                throw new ApplicationException("An error occurred while sending the request.", ex);
            }
            catch (TaskCanceledException ex) when (ex.CancellationToken == CancellationToken.None)
            {
                // Handle timeout exceptions specifically
                Console.WriteLine("Request timed out.");
                throw new TimeoutException("The request timed out.", ex);
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
