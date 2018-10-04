using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softservetest
{
    class Petshop
    {
        List<Cat> cats = new List<Cat>();
        List<Dog> dogs = new List<Dog>();
        
        public void addPet(IAnimal animal)
        {
            switch(animal.GetType().Name)
            {
                case "Cat":
                    {
                        cats.Add(new Cat(animal.Name, animal.Breed));
                    }
                    break;

                case "Dog":
                    {
                        dogs.Add(new Dog(animal.Name, animal.Breed));
                    }

                    break;
            }
        }

        public void IntroduceAll()
        {
            if (dogs.Count != 0)
            {
                Console.WriteLine("Dogs:");

                foreach (Dog oneDog in dogs)
                {
                    Console.WriteLine(oneDog.Introduce());
                }
            }
            else
            {
                Console.WriteLine("There's no dogs :'(");
            }

            Console.WriteLine("---------");
            if (cats.Count != 0)
            {
                Console.WriteLine("Cats:");

                foreach (Cat oneCat in cats)
                {
                    Console.WriteLine(oneCat.Introduce());
                }
            }
            else
            {
                Console.WriteLine("There's no cats :'(");
            }
        }
    }
}
