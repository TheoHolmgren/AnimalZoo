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
            species = 3;
            canFly = true;
            base.name = name;
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Pip aaaaa jag är en fågel!");
            base.IntroduceYourself();
        }
    }

}
