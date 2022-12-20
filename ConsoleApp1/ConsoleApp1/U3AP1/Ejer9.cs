using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejer9
    {

        public void run()
        {

            Console.WriteLine("Ejer9");

            Console.WriteLine("Introduce un número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otro número: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > 10 && num2 > 10)
            {
                Console.WriteLine("Los 2 números son mayores a 10");
            }else if(num1 > 10 && num2 < 10 || num1 < 10 && num2 > 10)
            {
                Console.WriteLine("Un número es mayor a 10");
            }
            else{
                Console.WriteLine("Ningún número es mayor a 10");
            }

            Console.ReadLine();

        }

    }
}
