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
            canFly = false; //Kan den flyga ja/nej 
            base.name = name; //base.name tilldelas namnet name
        }
        public override void IntroduceYourself() //override gör så att denna kör över sin förälder
        {
            Console.WriteLine("Meow, jag är en katt som heter: " + name);
            Console.WriteLine("Jag är " + this.age + " år gammal");
            base.IntroduceYourself();
        }
    }
}
