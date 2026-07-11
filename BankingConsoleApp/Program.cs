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
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine()!;

            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Account number already exists. Please try again.");
                return;
            }

            Console.Write("Enter initial balance: ");
            double balance = double.Parse(Console.ReadLine()!);

            customerNames.Add(name);
            accountNumbers.Add(accountNumber);
            balances.Add(balance);

            Console.WriteLine("Account added successfully!");
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Initial Balance: " + balance);
            Console.WriteLine("-----------------------------------");
        }

        static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine()!;

            if (!accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Account number not found. Please try again.");
                return;
            }

            int accountIndex = accountNumbers.IndexOf(accountNumber);

            Console.Write("Enter amount to deposit: ");
            double amount = double.Parse(Console.ReadLine()!);

            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive value.");
                return;
            }

            balances[accountIndex] += amount;

            Console.WriteLine("Deposit successful!");
            Console.WriteLine("New Balance: " + balances[accountIndex]);
            Console.WriteLine("-----------------------------------");
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine()!;

            if (!accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Account number not found. Please try again.");
                return;
            }

            int accountIndex = accountNumbers.IndexOf(accountNumber);

            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine()!);

            if (amount <= 0 || amount > balances[accountIndex])
            {
                Console.WriteLine("Invalid amount or amount exceeds your balance.");
                return;
            }

            balances[accountIndex] -= amount;

            Console.WriteLine("Withdrawal successful!");
            Console.WriteLine("New Balance: " + balances[accountIndex]);
            Console.WriteLine("-----------------------------------");
        }

        static void ShowBalance()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine()!;

            if (!accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Account number not found. Please try again.");
                return;
            }

            int accountIndex = accountNumbers.IndexOf(accountNumber);

            Console.WriteLine("Customer Name: " + customerNames[accountIndex]);
            Console.WriteLine("Account Number: " + accountNumbers[accountIndex]);
            Console.WriteLine("Current Balance: " + balances[accountIndex]);
            Console.WriteLine("-----------------------------------");
        }

        static void TransferAmount()
        {
            Console.Write("Enter account number (sender): ");
            string senderNumber = Console.ReadLine()!;

            Console.Write("Enter account number (receiver): ");
            string receiverNumber = Console.ReadLine()!;

            if (!accountNumbers.Contains(senderNumber) || !accountNumbers.Contains(receiverNumber))
            {
                Console.WriteLine("One or both account numbers not found. Please try again.");
                return;
            }

            int senderIndex = accountNumbers.IndexOf(senderNumber);
            int receiverIndex = accountNumbers.IndexOf(receiverNumber);

            Console.Write("Enter amount to transfer: ");
            double amount = double.Parse(Console.ReadLine()!);

            if (amount <= 0 || amount > balances[senderIndex])
            {
                Console.WriteLine("Invalid amount or amount exceeds sender balance.");
                return;
            }

            balances[senderIndex] -= amount;
            balances[receiverIndex] += amount;

            Console.WriteLine("Transfer successful!");
            Console.WriteLine("Sender New Balance: " + balances[senderIndex]);
            Console.WriteLine("Receiver New Balance: " + balances[receiverIndex]);
            Console.WriteLine("-----------------------------------");
        }

        static void CustomService1()
        {

        }

        static void CustomService2()
        {

        }
    }
}
