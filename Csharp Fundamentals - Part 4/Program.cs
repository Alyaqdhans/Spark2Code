namespace Csharp_Fundamentals___Part_4
{
    internal class Program
    {
        static void PrintWelcome(string username)
        {
            Console.WriteLine("Welcome back, " + username);
        }

        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function
            Console.Write("Enter your username: ");
            PrintWelcome(Console.ReadLine()!);

        }
    }
}
