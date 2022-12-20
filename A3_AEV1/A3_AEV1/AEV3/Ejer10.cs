using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer10
    {

        public void run()
        {

            Console.WriteLine("Ejer10");

            try
            {
                //Crea un nuevo StreamReader
                //Utiliza using para que esté solo abierto mientras se usa

                using (StreamReader sr = new StreamReader("..\\..\\TestFile.txt"))
                {
                    string line;

                    int contador = 0;

                    // Lee las lineas
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] words = line.Split(' ');   

                        foreach(String word in words)
                        {
                            contador++;
                        }
                    }

                    Console.WriteLine("En total hay {0} palabras", contador);
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
