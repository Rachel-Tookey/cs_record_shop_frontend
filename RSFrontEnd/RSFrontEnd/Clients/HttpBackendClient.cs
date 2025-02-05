﻿using System.Net;


namespace RSFrontEnd.Clients
{

    public class HttpBackendClient<T>
    {
        public string Url { get; set; }

        public HttpClient client { get; init; }

        public HttpBackendClient(string endpoint) { 
            Url = "http://localhost:5027/" + endpoint;
            client = new HttpClient(); 
        }

        public async Task<T> GetRequest()
        {
            try
            {
                T response = await client.GetFromJsonAsync<T>(Url);
                return response;
            }
            catch (HttpRequestException ex)
            {
                return default;
            }
        }

        public async Task<HttpStatusCode> PutRequest(T updateValue)
        {
            try
            {
                var response = await client.PutAsJsonAsync<T>(Url, updateValue);
                return response.StatusCode; 
            }
            catch (HttpRequestException ex)
            {
                return HttpStatusCode.ServiceUnavailable;
            }
        }

        public async Task<HttpStatusCode> PostRequest(T postValue)
        {
            try
            {
                var response = await client.PostAsJsonAsync<T>(Url, postValue);
                return response.StatusCode;
            }
            catch
            {
                return HttpStatusCode.ServiceUnavailable;
            }
        }

        public async Task<HttpStatusCode> DeleteRequest()
        {
            try
            {
                var response = await client.DeleteAsync(Url);
                return response.StatusCode;
            }
            catch
            {
                return HttpStatusCode.ServiceUnavailable;
            }

        }




    }

}
