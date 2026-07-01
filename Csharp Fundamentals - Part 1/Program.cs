using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Xml.Linq;

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


            //Task 6 - Temperature Converter
            float C = float.Parse(Console.ReadLine()!);
            float F = (C * 9 / 5) + 32;
            if (F < 10)
            {
                Console.WriteLine(F + "F Cold");
            }
            else if (F >= 10 && F <= 30)
            {
                Console.WriteLine(F + "F Mild");
            }
            else if (F > 30)
            {
                Console.WriteLine(F + "F Hot");
            }
            else
            {
                Console.WriteLine("Invalid temp");
            }


            //Task 7 - Movie Ticket Pricing
            Console.Write("Enter your age: ");
            int ticketAge = int.Parse(Console.ReadLine()!);

            if (ticketAge > 0 && ticketAge <= 12)
            {
                Console.WriteLine("Children ticket price: 2.000 OMR");
            }
            else if (ticketAge >= 13 && ticketAge <= 59)
            {
                Console.WriteLine("Adults ticket price: 5.000 OMR");
            }
            else if (ticketAge >= 60)
            {
                Console.WriteLine("Seniors ticket price: 3.000 OMR");
            }
            else
            {
                Console.WriteLine("Invalid age");
            }


            //Task 8 - Restaurant Bill with Membership Discount
            Console.Write("Enter the total bill amount: ");
            float billAmount = float.Parse(Console.ReadLine()!);
            Console.Write("Are you a loyalty member? [yes/no]: ");
            string loyalty = Console.ReadLine()!;
            
            if (billAmount > 20 && loyalty == "yes")
            {
                Console.WriteLine("Original bill: " + billAmount + " | Discount: 15% | Final amount: " + (billAmount - (0.15f * billAmount)));
            }
            else
            {
                Console.WriteLine("Original bill: " + billAmount + " | Discount: 0% | Final amount: " + billAmount);
            }


            //Task 9 - Day Name Finder
            Console.Write("Enter a day number [1-7]: ");
            string day = Console.ReadLine()!;

            switch (day)
            {
                case "1":
                    Console.WriteLine("Sunday");
                    break;
                case "2":
                    Console.WriteLine("Monday");
                    break;
                case "3":
                    Console.WriteLine("Tuesday");
                    break;
                case "4":
                    Console.WriteLine("Wednesday");
                    break;
                case "5":
                    Console.WriteLine("Thursday");
                    break;
                case "6":
                    Console.WriteLine("Friday");
                    break;
                case "7":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }


            //Task 10 - Mini Calculator
            Console.Write("Enter the first number: ");
            float operand1 = float.Parse(Console.ReadLine()!);
            Console.Write("Enter the second number: ");
            float operand2 = float.Parse(Console.ReadLine()!);
            Console.Write("Enter the operator [+ - * / %]: ");
            string op = Console.ReadLine()!;

            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (operand1 + operand2));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (operand1 - operand2));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (operand1 * operand2));
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        Console.WriteLine("Result: " + (operand1 / operand2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
                case "%":
                    if (operand2 != 0)
                    {
                        Console.WriteLine("Result: " + (operand1 % operand2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
    }
}
