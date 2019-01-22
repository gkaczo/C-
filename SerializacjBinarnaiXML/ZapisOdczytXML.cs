using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.IO;

namespace SerializacjBinarnaiXML
{
    class ZapisOdczytXML
    {

        public static void Zapis<T>(string filePath, T obj)
        {
            if (obj != null)
            {
                try
                {
                    var fs = new FileStream(filePath, FileMode.Create);

                    XmlRootAttribute xRoot = new XmlRootAttribute();
                  //  xRoot.ElementName = "mojaBaza";
                  //  xRoot.Namespace = "http://www.gkaczo.cba.pl";
                  //  xRoot.IsNullable = true;

                    XmlSerializer xml = new XmlSerializer(typeof(T), xRoot);

                    xml.Serialize(fs, obj);

                    fs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }


        public static T Odczyt<T>(string filePath)
        {
            T obj = default(T);

            if (File.Exists(filePath))
            {

                try
                {
                    var fs = new FileStream(filePath, FileMode.Open);
                    XmlRootAttribute xRoot = new XmlRootAttribute();
                   // xRoot.ElementName = "mojaBaza";
                  //  xRoot.Namespace = "http://www.gkaczo.cba.pl";
                  //  xRoot.IsNullable = true;

                    XmlSerializer xml = new XmlSerializer(typeof(T), xRoot);

                    obj = (T)xml.Deserialize(fs);
                    fs.Close();
                    return obj;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return obj;
        }


    }
}
