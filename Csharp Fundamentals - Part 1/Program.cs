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


            //Task 11 - Loan Eligibility System
            Console.Write("Enter your age: ");
            int loanAge = int.Parse(Console.ReadLine()!);

            Console.Write("Enter your monthly income: ");
            float monthlyIncome = float.Parse(Console.ReadLine()!);

            Console.Write("Do you have an existing loan? [yes/no]: ");
            string existingLoan = Console.ReadLine()!;

            if (loanAge >= 21 && loanAge <= 60 && monthlyIncome >= 400 && existingLoan == "no")
            {
                Console.WriteLine("You are eligible for a loan.");
            }
            else
            {
                Console.WriteLine("You are not eligible for a loan.");
                if (loanAge < 21 || loanAge > 60)
                {
                    Console.WriteLine("Reason: age is out of range.");
                }
                else if (monthlyIncome < 400)
                {
                    Console.WriteLine("Reason: income too low.");
                }
                else if (existingLoan == "yes")
                {
                    Console.WriteLine("Reason: you have an existing loan.");
                }
            }


            //Task 12 - Shipping Cost Calculator
            Console.WriteLine("[A] local");
            Console.WriteLine("[B] national");
            Console.WriteLine("[C] international");
            Console.Write("Enter a region code: ");
            string region = Console.ReadLine()!;

            Console.Write("Enter the weight of the package (kg): ");
            float weight = float.Parse(Console.ReadLine()!);

            float charge;

            switch (region)
            {
                case "A":
                    charge = 1.000f;
                    Console.WriteLine("Base shipping cost: " + charge + " OMR");
                    if (weight > 5)
                    {
                        charge += 2.000f;
                        Console.WriteLine("Extra shipping cost: 2.000 OMR");
                    }
                    else if (weight > 10)
                    {
                        charge += 5.000f;
                        Console.WriteLine("Extra shipping cost: 5.000 OMR");
                    }
                    else
                    {
                        charge += 0;
                        Console.WriteLine("Extra shipping cost: None");
                    }
                    Console.WriteLine("Total shipping cost: " + charge + " OMR");
                    break;
                case "B":
                    charge = 3.000f;
                    Console.WriteLine("Base shipping cost: " + charge + " OMR");
                    if (weight > 5)
                    {
                        charge += 2.000f;
                        Console.WriteLine("Extra shipping cost: 2.000 OMR");
                    }
                    else if (weight > 10)
                    {
                        charge += 5.000f;
                        Console.WriteLine("Extra shipping cost: 5.000 OMR");
                    }
                    else
                    {
                        charge += 0;
                        Console.WriteLine("Extra shipping cost: None");
                    }
                    Console.WriteLine("Total shipping cost: " + charge + " OMR");
                    break;
                case "C":
                    charge = 7.000f;
                    Console.WriteLine("Base shipping cost: " + charge + " OMR");
                    if (weight > 5)
                    {
                        charge += 2.000f;
                        Console.WriteLine("Extra shipping cost: 2.000 OMR");
                    }
                    else if (weight > 10)
                    {
                        charge += 5.000f;
                        Console.WriteLine("Extra shipping cost: 5.000 OMR");
                    }
                    else
                    {
                        charge += 0;
                        Console.WriteLine("Extra shipping cost: None");
                    }
                    Console.WriteLine("Total shipping cost: " + charge + " OMR");
                    break;
                default:
                    Console.WriteLine("Invalid region code");
                    break;
            }


            //Task 13 - Triangle Type Classifier
            Console.WriteLine("Enter the lengths of the three sides of the triangle");

            Console.Write("Side 1: ");
            float side1 = float.Parse(Console.ReadLine()!);

            Console.Write("Side 2: ");
            float side2 = float.Parse(Console.ReadLine()!);

            Console.Write("Side 3: ");
            float side3 = float.Parse(Console.ReadLine()!);

            if (side1 + side2 > side3 || side1 + side3 > side2 || side2 + side3 > side2)
            {
                if (side1 == side2 && side2 == side3 && side1 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene");
                }
            }
            else
            {
                Console.WriteLine("The lengths do not form a triangle.");
            }
        }
    }
}
