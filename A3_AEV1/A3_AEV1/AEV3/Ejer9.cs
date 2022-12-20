using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer9
    {

        public void run()
        {

            Console.WriteLine("Ejer9");

            String linea = " ";


            try
            {

                FileStream file = File.Create("..\\..\\testFile2.txt");
                StreamWriter sw = new StreamWriter(file);

                while (!String.Equals(linea, ""))
                {
                    Console.WriteLine("Introduce algo: ");
                    linea = Console.ReadLine();
                    sw.WriteLine(linea);
                }

                sw.Close();

                Console.WriteLine("Escritura terminada");

            }catch(Exception ex) {
                Console.WriteLine("Error en la escritura");
            }

            

            Console.ReadLine();

        }

    }
}
