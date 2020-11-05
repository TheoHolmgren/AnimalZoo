using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Animal
    {
        public enum  Species { CAT, DOG, BIRD };

        public string name;
        public Species species;
        public bool canFly;


        public virtual void IntroduceYourself()
        {
            Console.WriteLine("Morr. Jag är ett djur som heter: " + name);


            if (canFly == true)
            {
                Console.WriteLine("I can fly, boiii!");
            }
            else
            {
                Console.WriteLine("I can't fly... at all...");
            }
            Console.WriteLine("My7 species is a: " + species);
        }
    }
}
