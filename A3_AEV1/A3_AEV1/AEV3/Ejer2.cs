using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer2
    {

        public void run()
        {

            Console.WriteLine("Ejer2");

            Console.WriteLine("Introduce una palabra: ");
            String word = Console.ReadLine();

            String reversedWord = "";

            for(int i = word.Length-1 ; i>= 0 ; i--)
            {

                reversedWord += word[i];

            }

            if(String.Equals(word, reversedWord))
            {
                Console.WriteLine("Es un palindromo");
            }
            else
            {
                Console.WriteLine("No es un palindromo");
            }

            Console.ReadLine();

        }

    }
}
