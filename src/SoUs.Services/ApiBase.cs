using SoUs.Entities;
using System.ComponentModel.Design;
using System.Data;
using System.Net.Http.Json;

namespace SoUs.Services
{
    public partial class ApiBase
    {
        protected readonly Uri baseUri;
        protected readonly HttpClient client;

        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;
            client = new HttpClient();

        }

        protected ApiBase(string baseUri) : this(new Uri(baseUri))
        { }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string url)
        {
            Uri uri = new Uri(baseUri, url);

            client.BaseAddress = uri;

            var res = await client.GetAsync(uri);

            if (res is null)
            {
                throw new NoNullAllowedException("Res er nul din klovn...");
            }

            return res;
        }
    }

    public class SoUsService : ApiBase, ISoUsService
    {
        public SoUsService(Uri baseUri) : base(baseUri) { }

        public SoUsService(string baseUri) : base(baseUri) { }

        public async Task<List<Assignment>> GetAssignmentsForAsync(DateTime date, Employee employee)
        {
            var response = await GetHttpAsync($"Assignment/GetAssignmentsForEmployeeByDate?employeeId=2&date=2024-05-24");

            if (!response.IsSuccessStatusCode)
            {
                throw new DataException("Kunne ikke hente opgaver");
            }

            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Assignment>();

            List<Assignment> assignments = await result.ToListAsync();

            if (assignments is null)
            {
                throw new NoNullAllowedException("Assignments er null din klovn...");
            }

            return assignments;
        }
    }

    public interface ISoUsService
    {
        Task<List<Assignment>> GetAssignmentsForAsync(DateTime date, Employee employee);
    }
}
