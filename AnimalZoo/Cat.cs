using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            //Initiera attributen i objektet
            species = SPECIES.CAT ; //CAT=0, DOG=1, BIRD=2
            canFly = false;
            base.name = name;
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Meow, jag är en katt som heter: " + name);
            base.IntroduceYourself();
        }
    }
}
