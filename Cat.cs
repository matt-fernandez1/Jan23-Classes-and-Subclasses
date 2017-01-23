using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan23
{
    class Cat : Animal
    {
       
        private string breed;
        private string furLength;

        private bool declawed;


        public Cat(string breed, string furLength, bool declawed, string color): base(4,3,3)//the base ties into animal.cs strings of legs, size, weight
        {
            this.breed = breed;
            this.furLength = furLength;
            this.declawed = declawed;
            this.color = color;
        }
    }
}
