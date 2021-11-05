using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1 + 2 = {new Service().Sum(1, 2)}");
        }
    }
}
