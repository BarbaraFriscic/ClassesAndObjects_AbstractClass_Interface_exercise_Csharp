using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_22_Predavanje
{
    public interface IObnovljivo
    {
        string Oporavak();
    }
    public class Pacijent : IObnovljivo
    {
        public string Oporavak()
        {
            return $"{GetType().Name}: Osjećam se puno bolje";  
        }

    }
    class Namjestaj : IObnovljivo
    {
        public string Oporavak()
        {
            return $"{GetType().Name}: Svježe sam obojan";
        }

    }
    class Gospodarstvo : IObnovljivo
    {
        public string Oporavak()
        {
            return $"{GetType().Name}: BDP je porastao za 3%";
        }
    }
}
