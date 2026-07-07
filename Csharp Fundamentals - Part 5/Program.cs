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


            //Task 4 - Customer Service Queue
            Queue<string> customers = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter customer name {i + 1}: ");
                string customer = Console.ReadLine()!;
                customers.Enqueue(customer);
            }

            Console.WriteLine("Serving customer: " + customers.Dequeue());


            //Task 5 - Array Grade Range
            int[] grades = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                int grade = int.Parse(Console.ReadLine()!);
                grades[i] = grade;
            }

            grades.Sort();

            Console.WriteLine("Lowest grade: " + grades[0]);
            Console.WriteLine("Highest grade: " + grades[4]);
            Console.WriteLine("Average grade: " + grades.Sum() / 5);


            //Task 6 - Filtered Shopping List
            List<string> shoppingList = new List<string>();

            string shoppingLoop = "";
            while (shoppingLoop != "done")
            {
                Console.Write("Enter item: ");
                shoppingLoop = Console.ReadLine()!;
                if (shoppingLoop != "done")
                {
                    shoppingList.Add(shoppingLoop);
                }
            }

            foreach (string customer in shoppingList)
            {
                Console.WriteLine(customer);
            }

            Console.Write("Enter item to remove: ");
            string itemToRemove = Console.ReadLine()!;
            shoppingList.Remove(itemToRemove);

            foreach (string customer in shoppingList)
            {
                Console.WriteLine(customer);
            }


            //Task 7 - High Score Podium
            List<int> scores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter score {i + 1}: ");
                int score = int.Parse(Console.ReadLine()!);
                scores.Add(score);
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("1st place: " + scores[0]);
            Console.WriteLine("2nd place: " + scores[1]);
            Console.WriteLine("3rd place: " + scores[2]);


            //Task 8 - Undo Last Action
            Stack<string> actions = new Stack<string>();

            string actionLoop = "";
            while (actionLoop != "stop")
            {
                Console.Write("Enter action: ");
                actionLoop = Console.ReadLine()!;
                if (actionLoop != "stop")
                {
                    actions.Push(actionLoop);
                }
            }

            Console.WriteLine("Undoing last action: " + actions.Pop());
            Console.WriteLine("Undoing last action: " + actions.Pop());

            foreach (string action in actions)
            {
                Console.WriteLine(action);
            }


            //Task 9 - Grade Analyzer with Functions
            static double CalculateAverage(List<int> grades)
            {
                return grades.Sum() / grades.Count;
            }

            static int FindFirstFailing(List<int> grades)
            {
                return grades.Find(grade => grade < 60);
            }

            Console.Write("Enter number of grades: ");
            int gradeCount = int.Parse(Console.ReadLine()!);

            List<int> gradesList = new List<int>();

            for (int i = 0; i < gradeCount; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                int grade = int.Parse(Console.ReadLine()!);
                gradesList.Add(grade);
            }

            Console.WriteLine("Average grade: " + CalculateAverage(gradesList));

            int firstFailingGrade = FindFirstFailing(gradesList);

            if (firstFailingGrade == 0)
            {
                Console.WriteLine("No failing grades");
            }
            else
            {
                Console.WriteLine("First failing grade: " + firstFailingGrade);
            }


            //Task 10 - Print Queue Manager
            static Queue<string> RemoveJob(Queue<string> printQueue, string jobToRemove)
            {
                Queue<string> updatedQueue = new Queue<string>();
                while (printQueue.Count > 0)
                {
                    string currentJob = printQueue.Dequeue();
                    if (currentJob != jobToRemove)
                    {
                        updatedQueue.Enqueue(currentJob);
                    }
                }
                return updatedQueue;
            }

            Queue<string> prints = new Queue<string>();

            string printLoop = "";
            while (printLoop != "done")
            {
                Console.Write("Enter print job: ");
                printLoop = Console.ReadLine()!;
                if (printLoop != "done")
                {
                    prints.Enqueue(printLoop);
                }
            }

            foreach (string job in prints)
            {
                Console.WriteLine(job);
            }

            Console.Write("Enter a job to remove: ");
            string jobToRemove = Console.ReadLine()!;

            Queue<string> updatedPrints = RemoveJob(prints, jobToRemove);
            foreach (string job in updatedPrints)
            {
                Console.WriteLine(job);
            }
        }
    }
}
