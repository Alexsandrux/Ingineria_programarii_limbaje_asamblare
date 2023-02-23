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
            ContBancar obc = new ContBancar(100); // obc = obiect cont bancar
            IDatePersonale datePersonale = obc;
            datePersonale.Nume = "Vasile";
            Console.Out.WriteLine( datePersonale.Nume);
            

        }
    }
}
