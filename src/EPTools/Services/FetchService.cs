using System.Net.Http.Json;

namespace EPTools.Services
{
    public interface IFetchService
    {
        Task<T> GetTFromEPFileAsync<T>(string filename);
        Task<T> GetTFromFileAsync<T>(string filename);
    }

    public class FetchService : IFetchService
    {
        private HttpClient HttpClient { get; set; }

        public FetchService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<T> GetTFromFileAsync<T>(string filename)
        {
            return await HttpClient.GetFromJsonAsync<T>($"data/{filename}.json");
        }

        public async Task<T> GetTFromEPFileAsync<T>(string filename)
        {
            return await HttpClient.GetFromJsonAsync<T>($"data/EP-Data/{filename}.json");
        }
    }
}
