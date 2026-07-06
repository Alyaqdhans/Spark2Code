using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Csharp_Fundamentals___Part_4
{
    internal class Program
    {
        static void PrintWelcome(string username)
        {
            Console.WriteLine("Welcome back, " + username);
        }

        static int Square(int number)
        {
            return number * number;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            Console.Write("Enter your username: ");
            PrintWelcome(Console.ReadLine()!);


            //Task 2 - Square Number Function
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine("The square is " + Square(number));


            //Task 3 - Celsius to Fahrenheit Function
            Console.Write("Enter a number: ");
            double celsius = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Temp in Fahrenheit is " + CelsiusToFahrenheit(celsius));


            //Task 4 - Fixed Menu Display Function
            DisplayMenu();


            //Task 5 - Even or Odd Function
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);
            if (IsEven(num)) Console.WriteLine("The number is even.");
            else Console.WriteLine("The number is odd.");
         }
    }
}
