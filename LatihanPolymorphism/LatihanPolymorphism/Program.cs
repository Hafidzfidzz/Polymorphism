using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Cat cat = new Cat();
            animal = cat; 
            //cat.Speak();
            animal.Speak();

            Chicken chicken = new Chicken();
            animal = cat;
            //chicken.Speak();
            animal.Speak();

            Dog dog = new Dog();
            animal = cat;
            //dog.Speak();
            animal.Speak();

            Console.ReadKey();
        }
    }
}
