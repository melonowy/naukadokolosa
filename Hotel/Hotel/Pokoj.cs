﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Pokoj:IComparable<Pokoj>
    {
        private int nrPokoju;
        private double cenaZaDzien;

        public Pokoj(int nrPokoju,double cenaZaDzien)
        {
            this.nrPokoju = nrPokoju;
            this.cenaZaDzien = cenaZaDzien;
        }

        public override string ToString()
        {
            return "Pokoj, nr: " + nrPokoju + ", cena za dzień: " + cenaZaDzien;
        }

        public int zwrocNrPokoju()
        {
            return nrPokoju;
        }
        public double zwrocCenaZaDzien()
        {
            return cenaZaDzien;
        }

        public int CompareTo(Pokoj other)
        {
            return this.nrPokoju.CompareTo(other.nrPokoju);
        }
    }
}
