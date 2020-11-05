using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] allAnimals;

            allAnimals = new Animal[3];


            allAnimals[0] = new Cat("Kurre");
            allAnimals[1] = new Dog("William");
            allAnimals[2] = new Cat("Svante");

            foreach (Animal a in allAnimals)
            {
                Console.WriteLine("Nu kommer " + a.name);
                a.IntroduceYourself();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
