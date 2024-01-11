namespace EjemploModelado.Web.Domain.Builder
{
    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            builder = builder;
        }

        public void CreateSamsungComputer()
        {
            builder.Reset(); 

            
            builder.SetAlmacenamiento(512);
            builder.SetMemoriaRam(16);
            builder.SetNucleosProcesador(8);
            builder.SetPuertosUsb(4);

            builder.AgregarComponentes(new Componente { Id = 3, Descripcion = "Monitor" }); 
            builder.AgregarComponentes(new Componente { Id = 4, Descripcion = "Teclado" });
            builder.AgregarComponentes(new Componente { Id = 5, Descripcion = "Mouse" });
            builder.AgregarComponentes(new Componente { Id = 6, Descripcion = "Parlantes" });

        }
        public void CreateBasicComputer()
        {
            builder.Reset();

            builder.SetAlmacenamiento(256);
            builder.SetMemoriaRam(8);
            builder.SetNucleosProcesador(4);
            builder.SetPuertosUsb(2);

            builder.AgregarComponentes(new Componente { Id = 3, Descripcion = "Monitor" });
            builder.AgregarComponentes(new Componente { Id = 4, Descripcion = "Teclado" });
            builder.AgregarComponentes(new Componente { Id = 5, Descripcion = "Mouse" });

        }

        public void CreateGamingComputer()
        {
            builder.Reset();

            builder.SetAlmacenamiento(1024);
            builder.SetMemoriaRam(32);
            builder.SetNucleosProcesador(12);
            builder.SetPuertosUsb(6);

            builder.AgregarComponentes(new Componente { Id = 3, Descripcion = "Monitor" });
            builder.AgregarComponentes(new Componente { Id = 4, Descripcion = "Teclado" });
            builder.AgregarComponentes(new Componente { Id = 5, Descripcion = "Mouse" });
            builder.AgregarComponentes(new Componente { Id = 1, Descripcion = "Tarjeta de video" });
        }

        public void CreateOfficeComputer()
        {
            builder.Reset();

            builder.SetAlmacenamiento(512);
            builder.SetMemoriaRam(16);
            builder.SetNucleosProcesador(6);
            builder.SetPuertosUsb(4);

            builder.AgregarComponentes(new Componente { Id = 3, Descripcion = "Monitor" });
            builder.AgregarComponentes(new Componente { Id = 4, Descripcion = "Teclado" });
            builder.AgregarComponentes(new Componente { Id = 5, Descripcion = "Mouse" });
            builder.AgregarComponentes(new Componente { Id = 1, Descripcion = "Tarjeta de video" });
            builder.AgregarComponentes(new Componente { Id = 2, Descripcion = "Gabinete" });

        }



    }
}
