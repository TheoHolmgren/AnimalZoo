using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Animal
    {
        public enum  SPECIES { CAT, DOG, BIRD };

        public string name;
        public SPECIES species;
        public bool canFly;
        public int age; //åldersvariabel åt djuren


        public virtual void IntroduceYourself()
        {

            if (canFly == true) //Kollar huruvida djuren kan flyga eller inte med hjälp utav canFly variabeln
            {
                Console.WriteLine("I can fly!");
            }
            else
            {
                Console.WriteLine("I can't fly... at all...");
            }
            Console.WriteLine("My species is a: " + species);
        }
    }
}
