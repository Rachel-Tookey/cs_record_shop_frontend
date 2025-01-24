using RSFrontEnd.Models;

namespace RSFrontEnd.Clients
{
    public class HttpBackendClient<T>
    {
        public string Url { get; set; }

        public HttpClient client { get; init; }

        public HttpBackendClient(string endpoint) { 
            Url = "https://localhost:7278/" + endpoint;
            client = new HttpClient(); 
        }

        public async Task<List<T>> GetRequest()
        {
            try
            {
                List<T> response = await client.GetFromJsonAsync<List<T>>(Url);
                return response;
            }
            catch (HttpRequestException ex)
            {
                return null;
            }
        }
    }

}
