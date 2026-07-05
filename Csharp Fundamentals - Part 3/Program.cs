using System.Reflection.Emit;
using System.Timers;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

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


            //Task 5 - Grade Rounding System
            Console.Write("Enter you exam score (from 100): ");
            double score = double.Parse(Console.ReadLine()!);
            score = Math.Round(score);

            if (score >= 60) Console.WriteLine("Pass with a score of " + score);
            else Console.WriteLine("Fail with a score of " + score);


            //Task 6 - Password Strength Checker
            Console.Write("Enter your password: ");
            string password = Console.ReadLine()!;

            if (password.ToLower().Contains("password") && password.Length < 8)
            {
                Console.WriteLine("Weak Password");
            }
            else
            {
                Console.WriteLine("Strong Password");
            }


            //Task 7 - Clean Name Comparator
            Console.Write("Enter the first name: ");
            string name1 = Console.ReadLine()!.Trim().ToLower();

            Console.Write("Enter the second name: ");
            string name2 = Console.ReadLine()!.Trim().ToLower();

            if (name1 == name2) Console.WriteLine("Match");
            else Console.WriteLine("No Match");


            //Task 8 - Membership Expiry Checker
            Console.Write("Enter membership start date (yyyy-MM-dd): ");
            DateTime membershipStart = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Enter membership valid days: ");
            int validDays = int.Parse(Console.ReadLine()!);

            DateTime membershipEnd = membershipStart.AddDays(validDays);

            if (DateTime.Today > membershipEnd)
            {
                Console.WriteLine("Membership expired on " + membershipEnd.ToString("yyyy-MM-dd"));
            }
            else
            {
                Console.WriteLine("Membership is valid until " + membershipEnd.ToString("yyyy-MM-dd"));
            }


            //Task 9 - Round Up / Round Down Explorer
            Console.Write("Enter a decimal number: ");
            double decimalNum = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Rounded: " + Math.Round(decimalNum));
            Console.WriteLine("Rounded Up: " + Math.Ceiling(decimalNum));
            Console.WriteLine("Rounded Down: " + Math.Floor(decimalNum));


            //Task 10 - Word Position Finder
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine()!;

            Console.Write("Enter a word to find: ");
            string word = Console.ReadLine()!;

            if (sentence.Contains(word))
            {
                int positionStart = sentence.IndexOf(word);
                int positionLast = sentence.LastIndexOf(word);

                Console.WriteLine($"Found at position {positionStart}");

                if (positionStart != positionLast)
                {
                    Console.WriteLine($"Found at position {positionLast}");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
    }
}
