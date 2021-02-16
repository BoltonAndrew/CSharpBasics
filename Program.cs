using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Would you like me to calculate your spare cash? Y/N");
            string response = Console.ReadLine();
            if (response == "y")
            {
                Console.WriteLine($"{name}, how much are your current expenses?");
                double expenses = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("And what is your total income?");
                double income = Convert.ToDouble(Console.ReadLine());
                double total = Math.Round(income - expenses, 2);
                Console.WriteLine($"{name}, you have £{total} spare cash");
            } 
            else 
            {
                Console.WriteLine("Fair enough");
            }
        }
    }
}
