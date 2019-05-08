using ESCOLA.DE.ROCK.MVC.Interfaces;

namespace ESCOLA.DE.ROCK.MVC.Models
{
    public class Baixo : InstrumentoMusical, IPercussao , IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter Ritmo com um(a) {0}",this.GetType().Name);
            return true;
        }

        public bool TocarAcorde()
        {
            System.Console.WriteLine("Tocar Acordes com um(a) {0}",this.GetType().Name);
            return true;
        }
    }
}