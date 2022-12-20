using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejer5
    {
        public void run()
        {

            Console.WriteLine("Ejer5");

            Console.WriteLine("Introduce un número: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i<= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (int i = num-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();

        }
    }
}
