namespace Csharp_Fundamentals___Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array
            int[] nums = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                int grade = int.Parse(Console.ReadLine()!);
                nums[i] = grade;
            }

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }


            //Task 2 - Dynamic To - Do List
            List<string> toDo = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter task {i + 1}: ");
                string task = Console.ReadLine()!;
                toDo.Add(task);
            }

            foreach (string task in toDo)
            {
                Console.WriteLine(task);
            }


            //Task 3 - Browsing History Stack
            Stack<string> history = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter URL {i + 1}: ");
                string url = Console.ReadLine()!;
                history.Push(url);
            }

            Console.WriteLine(history.Pop());
        }
    }
}
