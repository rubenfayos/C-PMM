using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Ejer3
    {

        public void run()
        {

            Console.WriteLine("Ejer3");

            Console.WriteLine("Introduce un número del 1 al 10: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",num, i, num*i);
            }
            

            Console.ReadLine();

        }

    }
}
