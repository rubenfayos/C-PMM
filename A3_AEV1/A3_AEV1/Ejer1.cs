using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer1
    {

        public void run()
        {

            int[] numeros = new int[10]; 

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Introduce el número {0}: ", i+1);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numeros.Length - 1; i >= 0; i--) {

                if (numeros[i] % 2 == 0) {
                    Console.Write("{0} ", numeros[i]);
                }

            }

            Console.ReadLine();

        }
    }
}
