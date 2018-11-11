using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            string aString = Console.ReadLine();
            double a = double.Parse(aString);
            Console.Write("b: ");
            string bString = Console.ReadLine();
            double b = double.Parse(bString);
            Console.Write("c: ");
            string cString = Console.ReadLine();
            double c = double.Parse(cString);
            if ((a >= b) && (a >= c))
            {
                if (b >= c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }
            else if ((b >= a) && (b >= c))
            {
                if (a >= c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            else if ((c >= b) && (c >= a))
            {
                if (b >= a)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }

        }
    }
}
