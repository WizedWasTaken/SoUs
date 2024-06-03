using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;

namespace SoUs.Services
{
    public partial class ApiBase
    {
        protected readonly Uri baseUri;
        protected readonly HttpClient client;

        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;

            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
            };

            client = new HttpClient(handler);
        }

        protected ApiBase(string baseUri) : this(new Uri(baseUri))
        { }

        protected virtual Task<HttpResponseMessage> GetHttpAsync(string url)
        {
            try
            {
                Uri fullUrl = new Uri(baseUri, url);

                string fullUrlString = fullUrl.AbsoluteUri;
                var res = client.GetAsync(fullUrlString);

                Thread.Sleep(500);

                return res == null ? throw new NoNullAllowedException("Res er nul din klovn...") : res;
            }
            catch (Exception e)
            {
                Debug.Write($"Shit no workey workey on line 33... {e.Message}");
            }
            return default;
        }
    }
}
