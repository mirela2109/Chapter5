using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            string aString = Console.ReadLine();
            long a = long.Parse(aString);
            Console.Write("b: ");
            string bString = Console.ReadLine();
            long b = long.Parse(bString);
            if (a > b)
            {
                long comparator = a;
                a = b;
                b = comparator;
            }
                Console.WriteLine("a: " + a +" "+ "b: " + b);
            

        }
    }
}
