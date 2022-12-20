using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejer8
    {
        public void run()
        {

            Console.WriteLine("Ejer8");

            Console.WriteLine("Introduce un número: ");
            String num = Console.ReadLine();

            int length = num.Length;

            if (String.Equals(num[0], '-'))
            {
                length--;
            }

            Console.WriteLine("En total {0} tiene {1} digitos", num, length);

            Console.ReadLine();

        }
    }
}
