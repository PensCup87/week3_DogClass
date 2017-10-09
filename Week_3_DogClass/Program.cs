using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_DogClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dog firstDog = new Dog();
            //firstDog.Weight = 60;
            //firstDog.Height = 4.2f;
            //firstDog.FurLength = "flowing mane";
            //firstDog.RunningSpeed = "Will fetch eventually";

            //firstDog.Groom();
            //Console.WriteLine(firstDog.FurLength);

            //firstDog.Run();
            //Console.WriteLine("The dog now weighs " + firstDog.Weight);
            //Console.WriteLine(firstDog.RunningSpeed);

            //firstDog.Bark();

            //Dog dogTwo = new Dog("Fluffy", 4.04f);
            //Console.WriteLine(dogTwo.FurLength);

            //dogTwo.Groom();

            //Console.WriteLine(dogTwo.FurLength);

            //dogTwo.RunningSpeed = "Faster than Lighting";
            //Console.WriteLine(dogTwo.RunningSpeed);//user changed the variable running speed value
            //dogTwo.Run();
            //Console.WriteLine(dogTwo.RunningSpeed);//after calling the method, the running speed variable is back to original


            //dogTwo.Weight = 78.9;
            //Console.WriteLine(dogTwo.Weight);

            //dogTwo.Potty();//need () when calling methods
            //Console.WriteLine(dogTwo.Weight);

            SuperHero villan = new SuperHero();
            villan.VillanName = "Jason Voorhees";
            villan.CanTrack = true;
            villan.Weapon = "machette";
            villan.Health = 100;

            villan.LocatingPeople();
            Console.WriteLine(villan.Health);

            villan.Find();
            Console.WriteLine(villan.VillanName);
            Console.WriteLine(villan.Weapon);
        }
    }
}
