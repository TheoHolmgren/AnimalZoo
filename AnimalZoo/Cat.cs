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
             Species species = Species.Cat ; //Cat=0, DOG=1, BIRD=2
            canFly = false;
            base.name = name;
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Meow, nu kommer: " + name + ", wow, en katt!");
            base.IntroduceYourself();
        }
    }
}
