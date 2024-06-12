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
            client = InitializeHttpClient();
        }

        protected ApiBase(string baseUri) : this(new Uri(baseUri))
        { }

        /// <summary>
        /// Helper method to initialize the HttpClient with a custom handler that allows all certificates.
        /// </summary>
        /// <returns></returns>
        private HttpClient InitializeHttpClient()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };

            HttpClient client = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(15)
            };

            return client;
        }

        /// <summary>
        /// Method to get data from the API.
        /// </summary>
        /// <param name="uri">URI to get from</param>
        /// <returns>HttpResponseMessage</returns>
        /// <exception cref="NoNullAllowedException">Response from server is null</exception>
        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string uri)
        {
            try
            {
                Uri fullUrl = new Uri(baseUri, uri);
                HttpResponseMessage res = await client.GetAsync(fullUrl);

                if (res == null)
                {
                    throw new NoNullAllowedException("Response is null.");
                }

                return res;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error during GET request: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Method to update data in the database.
        /// </summary>
        /// <param name="uri">URI to update to</param>
        /// <param name="content">Content to update</param>
        /// <returns>HttpResponseMessage</returns>
        /// <exception cref="NoNullAllowedException">Response from server is null</exception>
        protected virtual async Task<HttpResponseMessage> PutHttpAsync(string uri, HttpContent content)
        {
            try
            {
                Uri fullUrl = new Uri(baseUri, uri);
                HttpResponseMessage res = await client.PutAsync(fullUrl, content);

                if (res == null)
                {
                    throw new NoNullAllowedException("Response is null.");
                }

                return res;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error during PUT request: {e.Message}");
                throw;
            }
        }
    }
}
