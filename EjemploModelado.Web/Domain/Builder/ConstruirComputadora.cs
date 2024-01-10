using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploModelado.Web.Domain.Builder
{
    public class ConstruirComputara : IBuilder
    {
        public Computadora Computadora { get; set; }

        public ConstruirComputara() => Computadora = new Computadora();
        

        public void AgregarComponentes(Componente componente)
        {
            if (Computadora.Componentes == null)
                Computadora.Componentes = new List<Componente>();
            Computadora.Componentes.Add(componente);
        }

        public void SetAlmacenamiento(int almacenamiento) => Computadora.Almacenamiento = almacenamiento;
        
        public void SetMemoriaRam(int memoriaRam) => Computadora.MemoriaRam = memoriaRam;
        
        public void SetNucleosProcesador(int nucleosProcesador) => Computadora.NucleosProcesador = nucleosProcesador;
     

        public void SetPuertosUsb(int puertosUsb) => Computadora.PuertosUsb = puertosUsb;

        public void Reset() => Computadora = new Computadora();
       

    }
}
