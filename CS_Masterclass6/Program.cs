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

            Human louise = new Human("Louise", "Schmidt", "green");
            louise.IntroduceMyself();

            Human thomas = new Human("Thomas", "Muller");
            thomas.IntroduceMyself();

            Human Jurgen = new Human("Jurgen");
            Jurgen.IntroduceMyself();

            Human Jan = new Human("Jan", "lowe", 58);
            Jan.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
