namespace Csharp_Fundamentals___Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Absolute Difference
            Console.Write("Enter the first number: ");
            float num1 = float.Parse(Console.ReadLine()!);

            Console.Write("Enter the second number: ");
            float num2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Result is " + Math.Abs(num1 - num2));


            //Task 2 - Power & Root Explorer
            Console.Write("Enter the base number: ");
            float baseNum = float.Parse(Console.ReadLine()!);

            Console.WriteLine("The Square is " + Math.Pow(baseNum, 2));
            Console.WriteLine("The Square Root is " + Math.Sqrt(baseNum));


            //Task 3 - Name Formatter
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;

            Console.WriteLine("Your name in uppercase is " + name.ToUpper());
            Console.WriteLine("Your name in lowercase is " + name.ToLower());
            Console.WriteLine("Your name length is " + name.Length);


            //Task 4 - Subscription End Date
            Console.Write("Enter the subscription period: ");
            int subDays = int.Parse(Console.ReadLine()!);
            DateTime endPeriod = DateTime.Today.AddDays(subDays);

            Console.WriteLine("Subscription end date is " + endPeriod.ToString("yyyy-MM-dd"));

        }
    }
}
