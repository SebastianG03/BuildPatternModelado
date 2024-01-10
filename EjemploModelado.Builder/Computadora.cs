using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploModelado.Builder
{
    public class Computadora
    {
        public int Id { get; set; }
        public int MemoriaRam { get; set; }
        public int Almacenamiento { get; set; }
        public int NucleosProcesador { get; set; }
        public int PuertosUsb { get; set; }

        public List<string> Componentes = new List<string>();

    }
}
