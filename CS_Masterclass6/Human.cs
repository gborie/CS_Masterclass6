using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Masterclass6
{
    // this class is a blueprint of a datatype
    class Human
    {
        //member variable
        public string firstName;
        public string lastName;

        // member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I am {0} {1}", firstName, lastName);
        }

    }
}
