using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class RedPen : IPen
    {
        public string Owner { get; set; }

        public void Draw(string shapeName)
        {
            Console.WriteLine("I am Draw function from Redpen Class");
        }

        public void Write(string message)
        {
            Console.WriteLine("I am Write function from Redpen Class");
        }
    }
}
