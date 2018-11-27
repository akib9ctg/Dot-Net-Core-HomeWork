using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Cat: Animal
    {
        public override string Eat()
        {
            return "Cat Eat Success";
        }

        public override void Sleep()
        {
            Console.WriteLine("I am from Cat. I sleep for 10 seconds");
            System.Threading.Thread.Sleep(10000);
        }
    }
}
