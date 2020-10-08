using System;
using System.Transactions;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloUser();
            SumOfTwo();
        }

        public static void HelloUser()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}");
        }

        public static void SumOfTwo()
        {
            Console.WriteLine("Enter the first number: ");
            double Number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double Number2 = Int32.Parse(Console.ReadLine());
            double Answer = Number + Number2;
            Console.WriteLine($"The sum of the numbers is {Answer}");
        }
    }
}
