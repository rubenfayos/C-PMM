using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer8
    {

        public void run()
        {

            Console.WriteLine("Ejer8");

            try
            {
                //Crea un nuevo StreamReader
                //Utiliza using para que esté solo abierto mientras se usa

                using (StreamReader sr = new StreamReader("..\\..\\TestFile.txt"))
                {
                    string line;

                    // Lee las lineas
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Error de archivo
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }

    }
}
