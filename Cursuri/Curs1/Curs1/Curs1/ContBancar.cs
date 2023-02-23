﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1
{

    class Op_bancara
    {
        DateTime dataOp; // oriunde apare "Op" = operatie
        int suma;
        char tipOperatie;

        public Op_bancara(int suma, char tipOperatie)
        {
            this.dataOp = DateTime.Now;
            this.suma = suma;
            this.tipOperatie = tipOperatie;
        }
    }

    interface IDateFinanciare
    {
        string Iban { get; set; }

        void Depunere(int suma); 

        void Extragere( int suma);
        int getSold();
    }

    interface IDatePersonale
    {
        string Nume { get; set; }

        void setDataNasterii(int anul, int luna, int ziua);

        int getVarsta();
    }
    internal class ContBancar : IDatePersonale, IDateFinanciare
    {
        List<Op_bancara> operatiiBancare;
        int soldInitial;
        string numePrenume;
        string iban;
        DateTime dataNasterii;

        public ContBancar(int soldInitial)
        {
            this.soldInitial = soldInitial;
            operatiiBancare = new List<Op_bancara>();
            dataNasterii = new DateTime();
        }

        string IDatePersonale.Nume { get { return numePrenume; } set { numePrenume = value; } }



        public int getVarsta()
        {
            return DateTime.Now.Year - dataNasterii.Year;
        }

        public void setDataNasterii(int anul, int luna, int ziua)
        {
            dataNasterii = DateTime.Parse(anul.ToString() + "-" + luna.ToString() + "-" + ziua.ToString());
        }

        string IDateFinanciare.Iban { get { return iban; } set { } }

        void IDateFinanciare.Depunere(int suma) {
            operatiiBancare.Add(new Op_bancara(suma, 'd'));
        }

        public void Extragere(int suma)
        {
            throw new NotImplementedException();
        }

        public int getSold()
        {
            throw new NotImplementedException();
        }
    }
}
