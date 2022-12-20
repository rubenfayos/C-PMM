using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_AEV1
{
    internal class Ejer7
    {

        public void run()
        {

            Console.WriteLine("Ejer7");

            Dog dog = new Dog();

            Console.WriteLine("Introduce el nombre del perro: ");
            String nombre = Console.ReadLine();

            dog.setName(nombre);
            Console.WriteLine("The dog's name is {0}", dog.getName());

            dog.Eat();

           

            Console.ReadLine();

        }

    }

    public abstract class Animal
    {
        private String name;

        public void setName(String name) { 
            this.name = name;
        }

        public String getName() { return name; }
        
        public void Eat()
        {
            Console.WriteLine("{0} is eating...", name);
        }
    }

    public class Dog : Animal
    {

    }
}
