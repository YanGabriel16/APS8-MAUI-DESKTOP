using APS8_MAUI_DESKTOP.Objects;
using APS8_MAUI_DESKTOP.Objects.Request;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

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

        public async Task<Local> GetLocal(string id)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"/api/Local/local/{id}");

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

        public async Task<EnderecoObject> GetEndereco(string cep)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"/api/Local/consulta/cep/{cep}");

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<EnderecoObject>(responseContent) ?? new EnderecoObject();
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

        public async Task<bool> AdicionarLocal(AdicionarLocalRequest request)
        {
            try
            {
                StringContent body = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync($"/api/Local", body);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }

        public async Task<bool> AtualizarLocal(int id, AtualizarLocalRequest request)
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(request);
                StringContent body = new(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync($"/api/Local/{id}", body);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }

        public async Task<bool> ExcluirLocal(int id)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.DeleteAsync($"/api/Local/{id}");

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro na requisição: {ex.Message}");
            }
        }
    }
}
