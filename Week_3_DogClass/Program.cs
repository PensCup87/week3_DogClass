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

            Dog firstDog = new Dog();
            firstDog.Weight = 60;
            firstDog.Height = 4.2f;
            firstDog.FurLength = "flowing mane";
            firstDog.RunningSpeed = "Will fetch eventually";

            firstDog.Groom();
            Console.WriteLine(firstDog.FurLength);

            firstDog.Run();
            Console.WriteLine("The dog now weighs " + firstDog.Weight);
            Console.WriteLine(firstDog.RunningSpeed);

            firstDog.Bark();
        }
    }
}
