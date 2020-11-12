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
            Animal[] allAnimals; //Lägger objektet allAnimals i klassen Animal

            allAnimals = new Animal[4]; //Den skapar fyra stycken tomma Animals i allAnimals


            allAnimals[0] = new Cat("Kurre");  //En instans av klassen Cat skapas och läggs i index 0 av arrayen allAnimals
            allAnimals[1] = new Dog("William"); //En instans av klassen Dog skaps och läggs i index 1 av arrayen allAnimals
            allAnimals[2] = new Cat("Svante"); 
            allAnimals[3] = new Bird("iNamNam");

            foreach (Animal a in allAnimals) //För varje djur i listan allAnimals
            {
                Console.WriteLine("Nu kommer " + a.name); //Skriv ut "nu kommer + djurets namn
                a.IntroduceYourself(); //Anropar funktionen IntroduceYourself
                Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
