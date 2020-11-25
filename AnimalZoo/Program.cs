using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        /*        public static void Main(String[] args)
                {
                    Animal kurre = new Cat("Kurre");
                    Animal vilma = new Dog("Vilma");

                    kurre.age = 6;
                    vilma.age = 3;

                    kurre.IntroduceYourself();
                    vilma.IntroduceYourself();
                    Console.ReadKey();
                }*/

        static void Main(string[] args)
        {
            Animal[] allAnimals; //Objektet allAnimals av klassen Animal - array

            allAnimals = new Animal[4]; //Den skapar fyra stycken tomma Animals i allAnimals

            //Här skapas fyra instanser med hjäp utav konstruktorerna "Cat", "Dog" och "Bird"
            allAnimals[0] = new Cat("Kurre");  //Här skapas en instans av klassen "Cat", där konstruktorn tar ett argument  S
            allAnimals[1] = new Dog("William");
            allAnimals[2] = new Cat("Svante");
            allAnimals[3] = new Bird("iNamNam");

            foreach (Animal a in allAnimals) //För varje objekt i listan allAnimals så anropas objektets metod "IntroduceYourself"
            {
                Console.WriteLine("Nu kommer " + a.name); //Skriv ut "nu kommer + djurets namn
                a.IntroduceYourself(); //Anropar funktionen IntroduceYourself
                Console.WriteLine(); 
                Console.ReadKey(); //Ser till så att programmet inte stängs ner direkt det har körts
            }

        }
    }
}
