using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class Animal
    {
        public string  Name { get; set; }
        public int NumberOfLegs { get; set; }
        public int Age { get; set; }

        public virtual void Sleep()
        {
            Console.WriteLine("I am from Animal");
            System.Threading.Thread.Sleep(5000);
        }
        public abstract string Eat();
    }
}
