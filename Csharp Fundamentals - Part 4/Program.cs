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

        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            Console.Write("Enter your username: ");
            PrintWelcome(Console.ReadLine()!);


            //Task 2 - Square Number Function
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine("The square is " + Square(number));
        }
    }
}
