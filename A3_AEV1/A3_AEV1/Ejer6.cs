using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer6
    {

        public void run()
        {

            Console.WriteLine("Ejer6");

            Persona[] personas = new Persona[3];

            for(int i = 0; i <= personas.Length-1; i++)
            {
                Console.WriteLine("Introduce el nombre de la persona nº{0}: ", i+1);
                String nombre = Console.ReadLine();
                personas[i] = new Persona(nombre);
            }

            foreach(Persona p in personas)
            {

                Console.WriteLine(p.ToString());

            }

            Console.ReadLine();

        }

    }

    class Persona
    {

        private String nombre;

        public Persona(String nombre)
        {
            this.nombre = nombre;
        }

        ~Persona()
        {
            this.nombre = "";
            Console.WriteLine("Persona destruida");
        }

        public override String ToString() {


            return "Hola " + nombre;

        }

    }
}
