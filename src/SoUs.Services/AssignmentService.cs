using SoUs.Entities;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Text;
using System.Security;

namespace SoUs.Services
{
    public class AssignmentService : ApiBase, IAssignmentService
    {
        public AssignmentService(Uri baseUri) : base(baseUri) { }

        public AssignmentService(string baseUri) : base(baseUri) { }

        /// <summary>
        /// Method to get assignments for a specific date and employee.
        /// </summary>
        /// <param name="date">Specific date to get assignments for</param>
        /// <param name="employee">Employee to get assignments for</param>
        /// <returns>List of assignments</returns>
        /// <exception cref="DataException">When data couldn't be updated.</exception>
        /// <exception cref="ApplicationException">Unexpected error happened.</exception>
        public async Task<List<Assignment>> GetAssignmentsAsync(DateTime date, Employee employee)
        {
            try {
                List<Assignment> assignmentList = new();

                // Placeholder data, since no data is available in the database for other dates.
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
                throw new ApplicationException("Der skete en uventet fejl.", ex);
            }
        }

        /// <summary>
        /// Method to update an assignment in the database.
        /// </summary>
        /// <param name="assignment">The assignment object to be updated.</param>
        /// <returns></returns>
        /// <exception cref="DataException">When data couldn't be updated.</exception>
        /// <exception cref="ApplicationException">Unexpected error happened.</exception>
        public async Task<Assignment> UpdateAssignmentAsync(Assignment assignment)
        {
            try
            {
                var content = ConvertToHttpContentFrom(assignment);

                var response = await PutHttpAsync("Assignment", content);

                if (!response.IsSuccessStatusCode) {
                    throw new DataException($"Kunne ikke opdatere opgaven med id {assignment.AssignmentId}");
                }

                return assignment;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Der skete en uventet fejl.\n{ex.Message}");
            }
        }

        /// <summary>
        /// Helper method to convert an object to HttpContent.
        /// </summary>
        /// <param name="obj">Object to convert</param>
        /// <returns>HttpContent</returns>
        public static HttpContent ConvertToHttpContentFrom(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
