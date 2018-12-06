using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    class NoteBook
    {
        public void WriteMessage(IPen pen, string message)
        {

            //Owner is not the property of IPen interface. So it cannot be accessable by Interface parameter object.

            //Console.WriteLine(pen.Owner);
            pen.Draw("Circle");
            pen.Write("Hello");
        }
    }
}
