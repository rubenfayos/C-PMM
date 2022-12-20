using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejer6
    {

        public void run()
        {

            Console.WriteLine("Ejer6");

            Console.WriteLine("Introduce un número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otro número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce una operacion ( + | - | x | / ): ");
            String sign = Console.ReadLine();

            float operation = 0;

            switch (sign){
                case "+":
                    operation = num + num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num, sign, num2, operation);
                    break;
                case "-":
                    operation = num - num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num, sign, num2, operation);
                    break;
                case "x":
                    operation = num * num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num, sign, num2, operation);
                    break;
                case "/":
                    operation = num / num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num, sign, num2, operation);
                    break;
                default:
                    Console.WriteLine("Unrecognized character");
                    break;
            }

            Console.ReadLine();

        }


    }
}
