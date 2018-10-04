using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softservetest
{
    class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public string Introduce()
        {
            return "I'm " + this.Name + " of " + this.Breed + ". I'm a cat";
        }

        public Cat(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
    }
}
