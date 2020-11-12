using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Bird : Animal
    {
        public Bird(string name)
        {
            //Initiera attributen i objektet
            species = SPECIES.BIRD; //CAT = 0, DOG = 1, BIRD = 2
            canFly = true;
            base.name = name;
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Pip, jag är en fågel som heter: " + name);
            base.IntroduceYourself();
        }
    }

}
