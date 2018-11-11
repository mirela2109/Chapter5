using System;

namespace Task6
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
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("No real roots");
            }
            if (D == 0)
            {
                double root = -b / 2 * a;
                Console.WriteLine(root);
            }
            else
            {
                Console.WriteLine((-b + Math.Sqrt(D)) / (2 * a) + " " + (-b - Math.Sqrt(D)) / (2 * a));
            }

        }
    }
}
