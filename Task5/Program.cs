using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int number = int.Parse(Console.In.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("Едно"); break;
                case 2: Console.WriteLine("Две"); break;
                case 3: Console.WriteLine("Три"); break;
                case 4: Console.WriteLine("Четири"); break;
                case 5: Console.WriteLine("Пет"); break;
                case 6: Console.WriteLine("Шест"); break;
                case 7: Console.WriteLine("Седем"); break;
                case 8: Console.WriteLine("Осем"); break;
                case 9: Console.WriteLine("Девет"); break;
                case 0: Console.WriteLine("Нула"); break;
                default: Console.WriteLine("Please, input valid digits - from 0 to 9."); break;
            }

        }
    }
}
