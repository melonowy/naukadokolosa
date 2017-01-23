using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel:IHotel,IData
    {

        private SortedDictionary<Gosc,Pokoj> rezerwacje = new SortedDictionary<Gosc,Pokoj>();
        private double zysk = -80;
        private DateTime data;

        public void DodajRezerwacje(string imie, string nazwisko, int nr, double cena)
        {
            rezerwacje.Add(new Gosc(imie, nazwisko), new Pokoj(nr, cena));
            zysk += cena;
        }

        public void OdwolajRezerwacje()
        {
            rezerwacje.Remove(rezerwacje.Last().Key);
        }
        public void UstawDate(DateTime Time)
        {
            data = Time;
        }
        public bool SprawdzDate()
        {
            if (data > DateTime.Now)
                return true;
            return false;
        }
        public override string ToString()
        {
            string output;
            output= "Rezerwacje:\n" + "Data: " + data.ToShortDateString() + "\n";
            foreach(var rez in rezerwacje)
            {
                output += "[" + rez.Value + "; " + rez.Key + "]";
            }
            return output;
        }
    }
}
