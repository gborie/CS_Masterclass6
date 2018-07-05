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
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member
        public void IntroduceMyself()
        {
            if(age < 2)
            {
                Console.WriteLine("Hi, I am {0} {1}, I have {2} eyes and I am {3} year old", firstName, lastName, eyeColor, age);
            }
            else
            {
                Console.WriteLine("Hi, I am {0} {1}, I have {2} eyes and I am {3} years old", firstName, lastName, eyeColor, age);
            }
                
        }

    }
}
