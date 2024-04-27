using System.Net.Http.Headers;

namespace RainFallLibrary.Services
{
    public static class ApiHelper
    {
        public static HttpClient HttpClient { get; set; }
        public static void InitializeCient()
        {
            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        }
    }
}
