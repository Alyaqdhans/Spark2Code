namespace BankingConsoleApp
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. <your 1st custom service - choose a name>");
                Console.WriteLine("7. <your 2nd custom service - choose a name>");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine()!;

                if (choice == "8")
                {
                    Console.WriteLine("Thank you for using Spark Bank. Goodbye!");
                    break;
                }

                switch (choice)
                {
                    case "1":
                        AddAccount();
                        break;

                    case "2":
                        DepositMoney();
                        break;

                    case "3":
                        WithdrawMoney();
                        break;

                    case "4":
                        ShowBalance();
                        break;

                    case "5":
                        TransferAmount();
                        break;

                    case "6":
                        CustomService1();
                        break;

                    case "7":
                        CustomService2();
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddAccount()
        {

        }

        static void DepositMoney()
        {

        }

        static void WithdrawMoney()
        {

        }

        static void ShowBalance()
        {

        }

        static void TransferAmount()
        {

        }

        static void CustomService1()
        {

        }

        static void CustomService2()
        {

        }
    }
}
