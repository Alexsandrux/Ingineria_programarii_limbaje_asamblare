using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ContBancar obc = new ContBancar(100);*/ // obc = obiect cont bancar, desi ar fi trebuit ocb
            IDatePersonale datePersonale = new ContBancar(100); // ar fi fost = obc in loc de = new ContaBancar, vezi in git
            datePersonale.Nume = "Vasile";
            IDateFinanciare dateFinanciare = (IDateFinanciare) datePersonale;
            dateFinanciare.Iban = "RO01023131BAASE2134";
            dateFinanciare.Depunere(500);
            dateFinanciare.Extragere(200);

            Console.Out.WriteLine("Contul:" + dateFinanciare.Iban + " al lui " + datePersonale.Nume + " are soldul " + dateFinanciare.getSold());
                
            
            Console.Out.WriteLine( );
            

        }
    }
}
