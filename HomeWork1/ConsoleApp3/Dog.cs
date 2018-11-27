using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Dog : Animal
    {
        public override string Eat()
        {
            return "Dog Eat Success";
        }

        public override void Sleep()
        {
            Console.WriteLine("I am from Dog. I sleep for 2 seconds");
            System.Threading.Thread.Sleep(2000);
        }

    }
}
