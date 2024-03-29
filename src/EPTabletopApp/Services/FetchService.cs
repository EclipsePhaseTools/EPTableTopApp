﻿using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EPTabletopApp.Services
{
    public class FetchService
    {
        private HttpClient httpClient { get; set; }

        public FetchService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<T> GetTFromFileAsync<T> (string filename)
        {
            return await httpClient.GetFromJsonAsync<T>($"data/{filename}.json");
        }

        public async Task<T> GetTFromEPFileAsync<T> (string filename)
        {
            return await httpClient.GetFromJsonAsync<T>($"data/EP-Data/{filename}.json");
        }
    }
}
