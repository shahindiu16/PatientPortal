using Newtonsoft.Json;

namespace PatientPortal_WebApp.Utilities
{

    public static class BaseApiService
    {
        private static string baseUrl = AppSettings.BaseUrl;

        public static async Task<T?> GetAsync<T>(HttpClient httpClient, string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(baseUrl + url);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                var value = JsonConvert.DeserializeObject<T>(responseContent);
                return value ?? default;
            }
            else
            {
                return default;
            }
        }

        public static async Task PostAsync(HttpClient httpClient, string url, object data)
        {
            httpClient.BaseAddress = new Uri(baseUrl + url);
            string requestBody = JsonConvert.SerializeObject(data);
            var content = new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(baseUrl + url, content);

        }
    }

}
