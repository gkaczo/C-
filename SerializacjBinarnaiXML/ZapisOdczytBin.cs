using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializacjBinarnaiXML
{
    class ZapisOdczytBin
    {

            //typ generyczny T
        public static void Zapis<T>(string filePath, T obj)
        {
            if (obj != null)
            {
                try
                {
                    var fs = new FileStream(filePath, FileMode.Create);

                    var bf = new BinaryFormatter();

                    bf.Serialize(fs, obj);

                    fs.Close();
                }
                catch(Exception ex)
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

               var fs = new FileStream(filePath, FileMode.Open);

                    try
                    {
                        var bf = new BinaryFormatter();
                        obj= (T)bf.Deserialize(fs);
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
