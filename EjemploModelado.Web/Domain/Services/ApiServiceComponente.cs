
using EjemploModelado.Web.Domain.Builder;
using System.Net.Http.Json;

namespace EjemploModelado.Web.Domain.Services
{
    public class ApiServiceComponente
    {
        private static readonly ApiServiceComponente? _instancia = new ApiServiceComponente();
        static readonly HttpClient client = new HttpClient();

        private string _url = "https://localhost:7234/api/Compontente";


        private ApiServiceComponente() { }

        public static ApiServiceComponente Singleton => _instancia!;
        

        public async Task<List<Componente>> GetComponentes()
        {
            List<Componente> componentes = new List<Componente>();
            try
            {
                var client = new HttpClient();
                return await client.GetFromJsonAsync<List<Componente>>(_url);
                
            } catch (Exception ex)
            {
                throw;
            }            
        }
    }
}
