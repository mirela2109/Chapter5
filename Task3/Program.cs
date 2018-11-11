using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            string aString = Console.ReadLine();
            decimal a = decimal.Parse(aString);
            Console.Write("b: ");
            string bString = Console.ReadLine();
            decimal b = decimal.Parse(bString);
            Console.Write("c: ");
            string cString = Console.ReadLine();
            decimal c = decimal.Parse(cString);
            if (a >= b && a >= c)
            {
                Console.WriteLine("the biggest number is the first number -> {0}", a);
            }
            else if (b >= c && b >= a)
            {
                Console.WriteLine("the biggest number is the second number -> {0}", b);
            }
            else
            {
                Console.WriteLine("the biggest number is the third number -> {0}", c);
            }


        }
    }
}
