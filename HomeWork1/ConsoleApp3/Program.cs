using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tiger obTiger = new Tiger();
            obTiger.Name = "Royal Bengal Tiger";
            obTiger.NumberOfLegs = 4;
            obTiger.Age = 10;
            Console.WriteLine(obTiger.Eat());
            obTiger.Sleep();


            Dog dogOb = new Dog();
            dogOb.Name = "Sifu";
            dogOb.NumberOfLegs = 4;
            dogOb.Age = 23;
            Console.WriteLine(dogOb.Eat());
            dogOb.Sleep();
            Console.WriteLine(dogOb.Name + " " + dogOb.Age + " " + dogOb.NumberOfLegs);


            Cat catOb = new Cat();
            catOb.Name = "XYZ";
            catOb.NumberOfLegs = 4;
            catOb.Age = 2;
            Console.WriteLine(catOb.Eat());
            catOb.Sleep();
            Console.WriteLine(catOb.Name + " " + catOb.Age + " " + catOb.NumberOfLegs);

            Console.ReadKey();

        }
    }
}
