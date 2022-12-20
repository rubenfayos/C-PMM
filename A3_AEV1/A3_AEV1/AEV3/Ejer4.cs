using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer4
    {

        public void run()
        {

            Console.WriteLine("Ejer4");

            despedirse(saludar());

            Console.ReadLine();

        }

        private String saludar()
        {
            Console.WriteLine("Introduce tu nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("Hola {0}.", nombre);

            return nombre;
        }

        private void despedirse(String nombre)
        {
            Console.WriteLine("Adios {0}.", nombre);
        }
    }

}

    
