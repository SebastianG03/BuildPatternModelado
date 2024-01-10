using EjemploModelado.Web.ServiceModel;

namespace EjemploModelado.Web.Services
{
    public class ApiServiceComputadora
    {
        private static ApiServiceComputadora? _instancia;
        static HttpClient client;

        private string _url = "https://localhost:7234/api/Computadora";


        private ApiServiceComputadora() => client = new HttpClient();

        public static ApiServiceComputadora Singleton()
        {
            if (_instancia == null)
            {
                _instancia = new ApiServiceComputadora();
            }
            return _instancia;
        }

        public async Task<List<ComputadoraModel>> GetComputadoras()
        {
            List<ComputadoraModel>? lista = new List<ComputadoraModel>();
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(_url);

            if (response.IsSuccessStatusCode)
            {
                lista = await response.Content.ReadAsAsync<List<ComputadoraModel>>();
            }
            return lista;
        }

        public async Task<bool> PostComputadora(ComputadoraModel computadora)
        {
            var response = await client.PostAsJsonAsync(_url, computadora);
            if (response.IsSuccessStatusCode)
            {
                return response.IsSuccessStatusCode;
            }
            return false;
        }

        public async Task<Computadora> GetComputadoraById(int Id)
        {
            Computadora computadora = null;
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"{_url}/{Id}");

            if (response.IsSuccessStatusCode)
            {
                computadora = await response.Content.ReadAsAsync<Computadora>();
            }

            return computadora;
        }
    }
}
