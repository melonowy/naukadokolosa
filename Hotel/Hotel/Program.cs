using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static Hotel hotel = new Hotel();

        static void Main(string[] args)
        {
            string wybor="z";
            while (true)
            {
                
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("a- ustaw datę");
                Console.WriteLine("b- dodaj rezerwacje");
                Console.WriteLine("c- usun rezerwacje");
                Console.WriteLine("d- wypisz rezerwacje");
                Console.WriteLine("x- wyjscie");
                wybor = Console.ReadLine();

                if (wybor == "a") UstawDate();
                if (wybor == "b") DodajRezerwacje();
                if (wybor == "c") UsunRezerwacje();
                if (wybor == "d") WypiszRezerwacje();
                if (wybor == "x") return;
            }
            
        }
        static void UstawDate()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj date(format rrrr-mm-dd):");
                    DateTime data = Convert.ToDateTime(Console.ReadLine());
                    hotel.UstawDate(data);
                    if (hotel.SprawdzDate())
                        return;
                    Console.WriteLine("Data jest zla");
                }
                catch (Exception)
                {
                    Console.WriteLine("Data ma zly format");
                }
            }
        }

        static void DodajRezerwacje()
        {
            string imie;
            string nazwisko;
            int nr;
            double cena;
            
                Console.WriteLine("Podaj imie,nazwisko,nrpokoju,cena");
                imie = Console.ReadLine();
                nazwisko = Console.ReadLine();
                try
                {
                    nr = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Musisz podac cyfre");
                    return;
                }
                try
                {
                    cena = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Musisz podac cyfre");
                    return;
                }

            hotel.DodajRezerwacje(imie, nazwisko, nr, cena);
        }
        static void UsunRezerwacje()
        {
            hotel.OdwolajRezerwacje();
        }
        static void WypiszRezerwacje()
        {
            Console.WriteLine(hotel.ToString());
        }
        
    }
}
