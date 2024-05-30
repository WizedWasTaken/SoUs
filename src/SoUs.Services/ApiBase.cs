using SoUs.Entities;
using System.ComponentModel.Design;

namespace SoUs.Services
{
    public partial class ApiBase
    {
        protected readonly Uri baseUri;

        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;
        }

        protected ApiBase(string baseUri) : this(new Uri(baseUri))
        { }

    }

    public class SoUsService : ApiBase, ISoUsService
    {
        public SoUsService(Uri baseUri) : base(baseUri) { }

        public SoUsService(string baseUri) : base(baseUri) { }

        public List<Assignment> GetAssignmentsFor(DateTime date, Employee employee)
        {
            UriBuilder uriBuilder = new UriBuilder(baseUri);
            uriBuilder.Path = "api/Assignment";

            // call the API
            return default;
        }
    }

    public interface ISoUsService
    {
        List<Assignment> GetAssignmentsFor(DateTime date, Employee employee);
    }
}
