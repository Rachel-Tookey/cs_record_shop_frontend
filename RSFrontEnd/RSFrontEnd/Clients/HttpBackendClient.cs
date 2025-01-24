﻿using RSFrontEnd.Models;
using System.Net;
using System.Text.Json; 

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

        public async Task<T> GetRequest()
        {
            try
            {
                T response = await client.GetFromJsonAsync<T>(Url);
                return response;
            }
            catch (HttpRequestException ex)
            {
                return default(T);
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
                return HttpStatusCode.BadRequest;
            }
        }

    }

}
