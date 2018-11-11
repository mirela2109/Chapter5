using System;

namespace Task7
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
            Console.Write("d: ");
            string dString = Console.ReadLine();
            double d = double.Parse(dString);
            Console.Write("e: ");
            string eString = Console.ReadLine();
            double e = double.Parse(eString);

            double max1 = Math.Max(a, b);
            double max2 = Math.Max(e, d);

            max1 = Math.Max(max1, c);
            max1 = Math.Max(max1, max2);
            Console.WriteLine("The max number is:" + max1);


        }
    }
}
