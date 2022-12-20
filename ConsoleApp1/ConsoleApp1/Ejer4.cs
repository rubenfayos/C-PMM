using System;

namespace ConsoleApp1
{
    internal class Ejer4
    {

        public void run()
        {

            Console.WriteLine("Ejer4");

            Console.WriteLine("Introduce un número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otro número: ");
            int num2 = int.Parse(Console.ReadLine());

            //Random
            var rand = new Random();

            int randomNum = rand.Next(num, num2);
            Console.WriteLine("Número aleatorio entre {0} y {1}: {2}", num, num2, randomNum);

            Console.ReadLine();

        }

    }
}
