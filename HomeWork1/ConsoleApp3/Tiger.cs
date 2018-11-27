using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Tiger:Animal
    {
        public override string Eat()
        {
            return "Tiger Eat Success";
        }

        public override void Sleep()
        {
            Console.WriteLine("I am from Tiger. I sleep for 5 seconds");
            System.Threading.Thread.Sleep(5000);
        }
    }
}
