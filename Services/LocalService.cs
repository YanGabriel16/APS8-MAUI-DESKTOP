using APS8_MAUI_DESKTOP.Objects;
using Newtonsoft.Json;
using System.Net.Http;

namespace APS8_MAUI_DESKTOP.Services
{
    public class LocalService
    {
        public string Url { get => "http://localhost:40000/api/Local"; }
        private readonly System.Net.Http.HttpClient _httpClient;

        public LocalService(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(Url);
        }

        public async Task<List<Local>> GetLocais()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("/api/Local/Locais");

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Local>>(responseContent) ?? new List<Local>();
                }
                else
                {
                    throw new Exception($"Erro na requisição: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }

        public async Task<Local> GetLocal(int id)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"/local/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Local>(responseContent) ?? new Local();
                }
                else
                {
                    throw new Exception($"Erro na requisição: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }
    }
}
