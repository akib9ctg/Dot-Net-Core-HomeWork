using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            BluePen bluePen = new BluePen();
            RedPen redPen = new RedPen();
            bluePen.Owner = "Akib";
            redPen.Owner = "Abid";
            

            NoteBook noteBook = new NoteBook();
            noteBook.WriteMessage(bluePen,"Sending BluePen object");
            noteBook.WriteMessage(redPen, "Sending Redpen object");
            Console.ReadKey();
        }
    }
}
