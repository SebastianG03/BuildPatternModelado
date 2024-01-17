
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
                var res = await client.GetFromJsonAsync<List<Componente>>(_url);
                Console.WriteLine(res);
                return res;

            }
            catch (HttpRequestException ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }
    }
}