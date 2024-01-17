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
/*
            builder.AgregarComponentes("Tarjeta gráfica, 3060 ");
            builder.AgregarComponentes("Unidad de disco SSD, ");
            builder.AgregarComponentes("Fuente de poder,100 ");
            builder.AgregarComponentes("Placa base, ");
*/
        }
        public void CreateBasicComputer()
        {
            builder.Reset();

            builder.SetAlmacenamiento(256);
            builder.SetMemoriaRam(8);
            builder.SetNucleosProcesador(4);
            builder.SetPuertosUsb(2);

    /*        builder.AgregarComponentes("Unidad de disco HDD, ");
            builder.AgregarComponentes("Fuente de poder, ");
            builder.AgregarComponentes("Placa base, ");
*/

        }

        public void CreateGamingComputer()
        {
            builder.Reset();

            builder.SetAlmacenamiento(1024);
            builder.SetMemoriaRam(32);
            builder.SetNucleosProcesador(12);
            builder.SetPuertosUsb(6);

/*            builder.AgregarComponentes("Tarjeta gráfica, 3080 ");
            builder.AgregarComponentes("Unidad de disco SSD NVMe, ");
            builder.AgregarComponentes("Refrigeración líquida, ");
            builder.AgregarComponentes("Placa base para juegos, ");
*/
        }

        public void CreateOfficeComputer()
        {
            builder.Reset();

            builder.SetAlmacenamiento(512);
            builder.SetMemoriaRam(16);
            builder.SetNucleosProcesador(6);
            builder.SetPuertosUsb(4);
/*
            builder.AgregarComponentes("Unidad de disco SSD, ");
            builder.AgregarComponentes("Fuente de poder eficiente, ");
            builder.AgregarComponentes("Placa base con soporte para múltiples monitores, ");
*/
        }



    }
}
