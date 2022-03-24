using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadej 1. číslo");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("zadej 2. číslo");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(x);
            }
            else if (x < y)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(y);
            }
            else if (x == y)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Obě čísla jsou stejně velká");
            }
        }
    }
}