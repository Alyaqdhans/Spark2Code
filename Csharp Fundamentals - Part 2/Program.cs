using System.ComponentModel.DataAnnotations;
using System.Numerics;
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


            //Task 5 - Number Guessing Game
            int secretNum = 42;
            int guess = 0;
            int attempts = 0;

            do
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine()!);
                attempts++;

                if (guess < secretNum)
                {
                    Console.WriteLine("Too low");
                }
                else if (guess > secretNum)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Correct, took you " + attempts + " tries!");
                }
            }
            while (secretNum != guess);


            //Task 6 - Safe Division Calculator
            try
            {
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine()!);

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine()!);

                if (num2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                Console.WriteLine($"Result: {num1 / num2}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }


            //Task 7 - Repeating Menu with Exit Option
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Say Hello");
            Console.WriteLine("2) Show Current Time of day greeting");
            Console.WriteLine("3) Exit");
            bool running = true;

            try
            {

                while (running)
                {
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine()!);

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;
                        case 2:
                            Console.WriteLine("Welcome back");
                            break;
                        case 3:
                            Console.WriteLine("Exiting");
                            running = false;
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input, correct choices [1-3]");
            }


            //Task 8 - Sum of Even Numbers Only
            int numberEven = int.Parse(Console.ReadLine()!);
            int sumEven = 0;

            for (int i = 0; i < numberEven; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                }
            }
            Console.WriteLine("The sum is " + sumEven);


            //Task 9 - Validated Positive Number Input
            int choice = 0;
            bool isValid = false;

            do
            {
                try
                {
                    Console.Write("Enter a number: ");
                    choice = int.Parse(Console.ReadLine()!);
                    
                    if (choice < 1)
                    {
                        continue;
                    }

                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input");
                    continue;
                }
            }
            while (!isValid);

            int numSum = 0;

            for (int i = 1; i <= choice; i++)
            {
                numSum += i;
            }
            Console.WriteLine("The sum of numbers from 1 to " + choice + " is: " + numSum);
        }
    }
}
