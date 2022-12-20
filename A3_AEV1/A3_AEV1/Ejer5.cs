using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer5
    {

        public void run()
        {

            Console.WriteLine("Ejer5");

            Console.WriteLine("Introduce un número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(factorial(num));

            Console.ReadLine();

        }

        private int factorial(int num)
        {

            int res = 1;

            if (num == 1) return 1;

            else
            {
                res = num * factorial(num -1);
            }

            return res;

        }

    }
}
