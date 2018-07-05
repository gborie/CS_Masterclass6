using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Masterclass6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of the class Human or an instance of Human
            Human sissy = new Human("Sissy", "Wagner", "blue", 25);
            sissy.IntroduceMyself();

            Human louise = new Human("Louise", "Schmidt", "green", 30);
            louise.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
