using EjemploModelado.Builder;

namespace EjemploModelado.Web.Services
{
    public class ApiServiceComponente
    {
        private static ApiServiceComponente? _instancia;
        static HttpClient client;

        private string _url = "https://localhost:7234/api/Compontente";


        private ApiServiceComponente() => client = new HttpClient();

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
