using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            string aString = Console.ReadLine();
            int a = int.Parse(aString);
            Console.Write("b: ");
            string bString = Console.ReadLine();
            int b = int.Parse(bString);
            Console.Write("c: ");
            string cString = Console.ReadLine();
            int c = int.Parse(cString);

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else if ((a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0) ||
                (c < 0 && b > 0 && a > 0) || (a < 0 && b < 0 && c < 0))
            {
                Console.WriteLine("The product of the 3 numbers is negative");
            }
            else Console.WriteLine("The product of the 3 numbers is positive");

        }
    }
}
