
using EjemploModelado.Web.Domain.Builder;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Net.Http.Json;

namespace EjemploModelado.Web.Domain.Services
{
    public class ApiServiceComponente
    {
        private static ApiServiceComponente? _instancia;
        static readonly HttpClient client = new HttpClient();

        private string _url = "https://localhost:7234/api/Compontente";


        private ApiServiceComponente() { }

        public static ApiServiceComponente Singleton()
        {
            if (_instancia == null)
            {
                _instancia = new ApiServiceComponente();
            }
            return _instancia;
        }
        

        public async Task<List<Componente>> GetComponentes()
        {
            List<Componente> componentes = new List<Componente>();
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(_url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    componentes = JsonConvert.DeserializeObject<List<Componente>>(jsonResponse);

                    return componentes;
                }
                else
                {
                    // Manejar el caso en que la solicitud no sea exitosa
                    Console.WriteLine($"Error en la solicitud: {response.StatusCode}");
                    return null;
                }

            } catch (HttpRequestException ex)
            {
                Console.Write(ex.Message );
                throw;
            }            
        }
    }
}
