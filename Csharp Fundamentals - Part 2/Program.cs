using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Csharp_Fundamentals___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Countdown Timer
            Console.Write("Enter a count number: ");
            int count = int.Parse(Console.ReadLine()!);

            for (int i = count; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Left off!");


            //Task 2 - Sum of Numbers 1 to N
            Console.Write("Enter a number to be summed: ");
            int number = int.Parse(Console.ReadLine()!);
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers from 1 to {number} is: {sum}");


            //Task 3 - Multiplication Table
            Console.Write("Enter a number for multiplication table: ");
            int mult = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{mult} x {i} = {mult * i}");
            }


            //Task 4 - Password Retry
            string password = "Spark2026";
            string attempt = "";

            while (attempt != password)
            {
                Console.Write("Enter password: ");
                attempt = Console.ReadLine()!;
            }
            Console.WriteLine("Access granted!");
        }
    }
}
