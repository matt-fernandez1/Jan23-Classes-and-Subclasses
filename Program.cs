using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan23
{
     class Program
    {
        
        static void Main(string[] args)
        {
            //instantiating objects
            Animal animal1 = new Animal(2, "Tan");
            Animal animal2 = new Animal(6, 1, 1);
           

            animal1.printAnimalInfo();
            Console.WriteLine();
            animal2.printAnimalInfo();
            Console.WriteLine();


            Cat cat1 = new Cat("Grumpy", "Short", false, "Grey");
            cat1.printAnimalInfo();
            Console.WriteLine();
            cat1.Speak();

            Fish fish1 = new Fish(5, true, true, "salt");
            fish1.printAnimalInfo();
            Console.WriteLine();
            fish1.Swim();
        }
    }
}
