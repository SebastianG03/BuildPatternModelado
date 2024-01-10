using EjemploModelado.Web.Domain.Builder;
using EjemploModelado.Web.Domain.ServiceModel;
using System.Net.Http.Json;

namespace EjemploModelado.Web.Domain.Services
{
    public class ApiServiceComputadora
    {
        private static readonly ApiServiceComputadora _instancia = new ApiServiceComputadora();
        private static readonly HttpClient _client = new HttpClient();

        private string _url = "https://localhost:7234/api/Computadora";

        private ApiServiceComputadora() { }

        public static ApiServiceComputadora Singleton => _instancia;

        public async Task<List<ComputadoraModel>?> GetComputadoras()
        {
            try
            {
                return await _client.GetFromJsonAsync<List<ComputadoraModel>>(_url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener computadoras: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> PostComputadora(ComputadoraModel computadora)
        {
            try
            {
                var response = await _client.PostAsJsonAsync(_url, computadora);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar nueva computadora: {ex.Message}");
                return false;
            }
        }

        public async Task<Computadora> GetComputadoraById(int id)
        {
            try
            {
                return await _client.GetFromJsonAsync<Computadora>($"{_url}/{id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener computadora por ID: {ex.Message}");
                return null;
            }
        }
    }
}
