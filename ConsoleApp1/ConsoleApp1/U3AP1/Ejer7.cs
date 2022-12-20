using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejer7
    {

        public void run()
        {

            Console.WriteLine("Ejer7");

            int num = 1;
            int suma = 0;

            while(num != 0)
            {
                Console.WriteLine("Introduce un número (0 para finalizar): ");

                num = int.Parse(Console.ReadLine());
                suma += num;

                Console.WriteLine("Suma total {0}", suma);
            }

            Console.WriteLine("Final", suma);

            Console.ReadLine();

        }

    }
}
