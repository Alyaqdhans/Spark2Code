using System.Diagnostics.Metrics;

namespace Csharp_Fundamentals___Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Personal Info Card
            string name = "Alyaqdhan Alazri";
            int age = 23;
            float salary = 1000.50f;
            bool isEmployed = true;

            Console.WriteLine("Name: " + name + ", Age: " + age + ", Salary: " + salary + ", Employed: " + isEmployed);


            //Task 2 - Rectangle Calculator
            Console.Write("Enter the length: ");
            float length = float.Parse(Console.ReadLine()!);
            Console.Write("Enter the width: ");
            float width = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Area = " + (length * width));
            Console.WriteLine("Perimeter = " + (2 * (length + width)));


            //Task 3 - Even or Odd Checker
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }


            //Task 4 - Voting Eligibility
            Console.Write("Enter your age: ");
            int voteAge = int.Parse(Console.ReadLine()!);
            Console.Write("Is your ID valid [yes/no]: ");
            string valid = Console.ReadLine()!;
            bool isValid = valid == "yes";

            if (voteAge >= 18 && isValid)
            {
                Console.WriteLine("You can vote.");
            }
            else
            {
                Console.WriteLine("You cannot vote.");
            }


            //Task 5 - Grade Letter Lookup
            Console.Write("Enter your grade (letter): ");
            string grade = Console.ReadLine()!;

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Very Good");
                    break;
                case "C":
                    Console.WriteLine("Good");
                    break;
                case "D":
                    Console.WriteLine("Pass");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }
    }
}
