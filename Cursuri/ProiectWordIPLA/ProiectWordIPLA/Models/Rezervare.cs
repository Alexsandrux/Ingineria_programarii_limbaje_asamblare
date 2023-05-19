using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProiectWordIPLA.Models
{
    public class Rezervare
    {
        public int ID { get; set; }
        public int IdClient { get; set; }
        public double Valoare { get; set; }

        public int NumarCamera { get; set; }

        public DateTime Data { get; set; }

        public Rezervare(int id, int idClient, int numarCamera, double valoare, DateTime data) { 
            this.ID = id;
            this.IdClient = idClient;
            this.NumarCamera = numarCamera;
            this.Valoare = valoare;
            this.Data = data;
        }

        
    }
}
