using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {

        public Dog(string name)
        {
            //Initiera attributen i objektet
            species = SPECIES.DOG; //CAT = 0, DOG = 1, BIRD = 2
            canFly = false;
            base.name = name;
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Woff. Jag är en hund som heter: " + name);
            base.IntroduceYourself();
        }
    }

}


