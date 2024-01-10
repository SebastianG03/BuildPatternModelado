using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploModelado.Builder
{
    public class ConstruirComputara : IBuilder
    {
        public Computadora computadora;

        public ConstruirComputara()
        {
            computadora = new Computadora();
        }

        public void AgregarComponentes(string componente)
        {
            if (computadora.Componentes == null)
                computadora.Componentes = new List<string>();
            computadora.Componentes.Add(componente);
        }

        public void SetAlmacenamiento(int almacenamiento)
        {

            computadora.Almacenamiento = almacenamiento;
        }

        public void SetMemoriaRam(int memoriaRam)
        {

            computadora.MemoriaRam = memoriaRam;
        }

        public void SetNucleosProcesador(int nucleosProcesador)
        {

            computadora.NucleosProcesador = nucleosProcesador;
        }

        public void SetPuertosUsb(int puertosUsb)
        {

            computadora.PuertosUsb = puertosUsb;
        }

        public void Reset()
        {

            computadora = new Computadora();
        }

        public void Union()
        {
            string components = computadora.Componentes.Aggregate((i, j) => i + j);
            Console.WriteLine(components);
        }

        public Computadora Computadora => computadora;


    }
}
