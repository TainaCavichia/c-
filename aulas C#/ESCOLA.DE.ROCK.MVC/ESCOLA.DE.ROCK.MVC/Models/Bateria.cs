using ESCOLA.DE.ROCK.MVC.Interfaces;

namespace ESCOLA.DE.ROCK.MVC.Models
{
    public class Bateria : InstrumentoMusical , IPercussao
    {
        public bool ManterRitmo()
        {
           System.Console.WriteLine("Tocar Acordes com um(a) {0}",this.GetType().Name);
            return true;
        }      
    }
}