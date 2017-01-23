using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan23
{
    class Animal
    {
        //fields/properties
        private int legs;
        private int size;
        private int weight;

        protected string color; //changed to protected

        protected bool isGoodToEat;

        public int Legs
        {
            get { return this.legs; }
            set { this.legs = value; }
        }

        public Animal()
        {

        }
        //constructors
        public Animal(int legs, string color)
        {
            this.legs = legs;
            this.color = color; 
        }

        public Animal(int legs, int size, int weight)
        {
            this.legs = legs;
            this.size = size;
            this.weight = weight;
        }

        public Animal(int legs, int size, int weight, string color)
        {
            this.legs = legs;
            this.size = size;
            this.weight = weight;
            this.color = color;
            
        }
        //method
        public void printAnimalInfo()
        {
            Console.WriteLine("This animal has " + legs + " legs");
            Console.WriteLine("It's size is: " + size);
            Console.WriteLine("It weighs: " + weight);
            Console.WriteLine("And is the color " + color);
        }

        protected void WhoAmI()
        {
            Console.WriteLine("I am an animal");
        }
    }
}
