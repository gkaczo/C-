using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacjBinarnaiXML
{
    class Program
    {
        static void Main(string[] args)
        {
            DaneKolekcja k = new DaneKolekcja();
            
            var os1 = new DaneOsoba() { Imie = "Jan", Nazwisko = "Kowalski", Wiek = 25 };
            var os2 = new DaneOsoba() { Imie = "Tomasz", Nazwisko = "iksinski", Wiek = 38 };
            k.DodajDoListy(os1);
            k.DodajDoListy(os2);

            string filePath = @"data.xml";

           // ZapisOdczytXML.Zapis<DaneOsoba>(filePath, os1);
            ZapisOdczytXML.Zapis<DaneKolekcja>(filePath, k);

            //   DaneOsoba o = new DaneOsoba();
            //  o = ZapisOdczytXML.Odczyt<DaneOsoba>(filePath);

            k = ZapisOdczytXML.Odczyt<DaneKolekcja>(filePath);
            k.PokazKolekcje();
         //   Console.WriteLine(o.Imie + " " + o.Nazwisko);

            Console.WriteLine();
        }
    }
}
