using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Tambor : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo como um(a) {0}", this.GetType().Name);
            return true;
        }
    }
}