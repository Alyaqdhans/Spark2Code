namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine()!);

            Console.Write("Enter your salary: ");
            float salary = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Welcome back " + name + ", " + age + " years old.");
            Console.WriteLine("Your salary: " + salary);
        }
    }
}
