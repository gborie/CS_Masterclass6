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
            Human denis = new Human();
            //access public variable from outside and even chnge it
            denis.firstName = "Denis";
            //call method of the class
            denis.IntroduceMyself();

            Human Michael = new Human();
            Michael.firstName = "Mikel";
            Michael.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
