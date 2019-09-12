using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, last;
            Console.WriteLine("Enter your first name:");
            first=Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            last = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", first, last);
            Console.ReadLine();

        }
    }
}
