using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_eveniment_delegate.Models
{


    public class Animal
    {
        // prototipul evenimentului
        public delegate void Delegat_Schimbare_Varsta(int varsta);

        // evenimentul
        public Delegat_Schimbare_Varsta schimbare_varsta;


        private string nume;
        private int varsta;
        private double greutate;

        public Animal()
        {
            nume = "Grivei";
            varsta = 4;
            greutate = 4.6;
        }

        public int Varsta 
        { 
            get { return varsta; } 
            set { 
                if (value == varsta) return; 
                varsta = value;
                schimbare_varsta?.Invoke(value) ;
            }
        }

        public override string ToString()
        {
            return "Nume: " + nume + "\nVarsta: " + varsta + "\nGreutate: " + greutate + "\n";
        }
    }
}
