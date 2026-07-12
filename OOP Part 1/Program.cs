namespace OOP_Part_1
{
    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount.");
                return;
            }

            Balance += amount;
            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            Balance -= amount;
            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine($"Holder Name: {HolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }

        private void SendEmail()
        {
            Console.WriteLine("Email sent to account holder.");
        }
    }

    class Student
    {
        public int Grade;
        public string Name;
        public string Address;
        private string email;
        int age;

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Email sent to account holder.");
        }
    }

    class Product
    {
        public string ProductName;
        public double Price;
        public int StockQuantity;

        public void Sell(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Invalid quantity.");
                return;
            }

            if (quantity > StockQuantity)
            {
                Console.WriteLine("Not enough stock.");
                return;
            }

            StockQuantity -= quantity;
            LogTransaction();
        }

        public void Restock(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Invalid quantity.");
                return;
            }

            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Stock Quantity: " + StockQuantity);
        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged.");
        }
    }

    internal class Program
    {

        static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "Karim", Balance = 120};
        static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

        static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student student2 = new Student { Name = "Ahmed", Address = "Salalah", Grade = 70 };

        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

        static void Main(string[] args)
        {
            Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
            Console.WriteLine(" 1. View Account Details");
            Console.WriteLine(" 2. Update Student Address");
            Console.WriteLine(" 3. Make a Deposit");
            Console.WriteLine(" 4. Make a Withdrawal");
            Console.WriteLine(" 5. View Product Details");
            Console.WriteLine(" 6. Register a Student");
            Console.WriteLine(" 7. Compare Two Account Balances");
            Console.WriteLine(" 8. Restock Product & Stock Level Check");
            Console.WriteLine(" 9. Transfer Between Accounts");
            Console.WriteLine("10. Update Student Grade (Validated)");
            Console.WriteLine("11. Student Report Card");
            Console.WriteLine("12. Account Health Status");
            Console.WriteLine("13. Bulk Sale With Revenue Calculation");
            Console.WriteLine("14. Scholarship Eligibility Check");
            Console.WriteLine("15. Full Balance Top-Up Flow");
            Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
            Console.WriteLine("17. Total Students Counter (Static Field & Method)");
            Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
            Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
            Console.WriteLine("20. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine()!;

            while (true)
            {
                if (choice == "20")
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Choose an account to view details (1 or 2): ");
                        string accountChoice = Console.ReadLine()!;

                        if (accountChoice == "1")
                        {
                            account1.CheckBalance();
                        }
                        else if (accountChoice == "2")
                        {
                            account2.CheckBalance();
                        }
                        else
                        {
                            Console.WriteLine("Invalid account choice.");
                        }
                        break;
                }

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
