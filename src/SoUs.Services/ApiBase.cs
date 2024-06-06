using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;

namespace SoUs.Services
{
    public partial class ApiBase
    {
        protected readonly Uri baseUri;
        // HttpClient that everything uses
        protected readonly HttpClient client;

        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;

            // Makes the HttpClient that everything uses ignore SSL stuff. Stupid errors
            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
                
            };

            // Initialise HttpClient that everything uses with the new handler ignoring f****** stupid errors :D
            client = new HttpClient(handler);
            client.Timeout = TimeSpan.FromSeconds(15);
        }

        protected ApiBase(string baseUri) : this(new Uri(baseUri))
        { }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string url)
        {
            try
            {
                Uri fullUrl = new Uri(baseUri, url);

                string fullUrlString = fullUrl.AbsoluteUri;
                var res = await client.GetAsync(fullUrlString);

                return res == null ? throw new NoNullAllowedException("Res er nul din klovn...") : res;
            }
            catch (Exception e)
            {
                Debug.Write($"Shit no workey workey... {e.Message}");
            }

            return default;
        }
    }
}
