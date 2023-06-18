using _1_eveniment_delegate.Forms;
using _1_eveniment_delegate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_eveniment_delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();

            //Console.WriteLine(animal.ToString());

            //animal.schimbare_varsta += new Animal.Delegat_Schimbare_Varsta((int i) =>
            //{ Console.WriteLine("A fost apelat delegatul cu valoarea " +i + "\n"); });
            //animal.schimbare_varsta += new Animal.Delegat_Schimbare_Varsta((int i) =>
            //{ Console.WriteLine("A fost apelat delegatul cu valoarea " + i + "\n"); });
            //animal.Varsta = 5;

            //Console.WriteLine(animal.ToString());

            //animal.schimbare_varsta = new Animal.Delegat_Schimbare_Varsta((int i) =>
            //{ Console.WriteLine("A fost apelat delegatul cu valoarea " + i + "\n"); });

            //animal.Varsta = 4;


            Form1 form1 = new Form1();

            form1.ShowDialog();
        }
    }
}
