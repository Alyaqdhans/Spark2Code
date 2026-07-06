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

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static string GetGradeLetter(int score)
        {
            if (score >= 90) return "A";
            else if (score >= 80) return "B";
            else if (score >= 70) return "C";
            else if (score >= 60) return "D";
            else return "F";
        }

        static void Countdown(int start)
        {
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine("Count: " + i);
            }
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


            //Task 6 - Rectangle Area & Perimeter Functions
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine()!);

            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Area: " + CalculateArea(length, width));
            Console.WriteLine("Perimeter: " + CalculatePerimeter(length, width));


            //Task 7 - Grade Letter Function
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Grade: " + GetGradeLetter(score));


            //Task 8 - Countdown Function
            Console.Write("Enter a number to countdown: ");
            int countdownStart = int.Parse(Console.ReadLine()!);
            Countdown(countdownStart);
        }
    }
}
