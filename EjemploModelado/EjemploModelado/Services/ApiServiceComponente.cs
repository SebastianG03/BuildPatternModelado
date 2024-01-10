
using EjemploModelado.Builder;

namespace EjemploModelado.Services
{
    public class ApiServiceComponente
    {
        static HttpClient client;

        private string _url = "https://localhost:7234/api/Compontente";


        public ApiServiceComponente() => client = new HttpClient();
        
        

        public async Task<List<Componente>> GetComponentes()
        {
            List<Componente>? lista = new List<Componente>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(_url);

            if (response.IsSuccessStatusCode)
            {
                lista = await response.Content.ReadAsAsync<List<Componente>>();
            }
            return lista;
        }
    }
}
