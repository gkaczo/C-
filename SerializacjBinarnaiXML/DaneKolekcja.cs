using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacjBinarnaiXML
{
    [Serializable]
    public class DaneKolekcja
    {
        public List<DaneOsoba> lista = new List<DaneOsoba>();

        public void DodajDoListy(DaneOsoba os)
        {
            lista.Add(os);
        }

        public void PokazKolekcje()
        {
            foreach(DaneOsoba o in lista)
            {
                Console.WriteLine(o.Imie + " " + o.Wiek);
            }
        }
    }
}
