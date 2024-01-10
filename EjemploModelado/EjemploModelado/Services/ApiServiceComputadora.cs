using EjemploModelado.Builder;

namespace EjemploModelado.Services
{
    public class ApiServiceComputadora
    {
        static HttpClient client;

        private string _url = "https://localhost:7234/api/Computadora";


        public ApiServiceComputadora() => client = new HttpClient();
        
        
        public async Task<Computadora> GetComputadora() { }

        public async Task<bool> PostComputadora()



    }
}
}
