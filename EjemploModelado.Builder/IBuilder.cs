namespace EjemploModelado.Builder
{
    public interface IBuilder
    {
        public void SetMemoriaRam(int memoriaRam);
        public void SetAlmacenamiento(int almacenamiento);
        public void SetNucleosProcesador(int nucleosProcesador);
        public void SetPuertosUsb(int puertosUsb);
        public void AgregarComponentes(String componentes);

        public void Reset();
        public void Union();
    }
}
