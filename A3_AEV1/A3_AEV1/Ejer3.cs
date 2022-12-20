using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer3
    {

        public void run()
        {

            Console.WriteLine("Ejer3");

            Console.WriteLine("Introduce algo: ");
            String text = Console.ReadLine();

            try
            {
                int num = int.Parse(text);
                Console.WriteLine("El texto es un número");
            }
            catch(Exception ex) {

                Console.WriteLine("El texto no es un número");
            }

            Console.ReadLine();

        }

    }
}
