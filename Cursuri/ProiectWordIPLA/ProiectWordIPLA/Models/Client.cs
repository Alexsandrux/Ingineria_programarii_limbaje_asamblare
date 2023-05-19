using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectWordIPLA.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }

        public Client(int iD, string nume, string prenume, string email)
        {
            ID = iD;
            Nume = nume;
            Prenume = prenume;
            Email = email;
        }
    }
}
