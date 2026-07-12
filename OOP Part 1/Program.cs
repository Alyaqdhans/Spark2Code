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
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
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

        static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "Karim", Balance = 120 };
        static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

        static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student student2 = new Student { Name = "Ahmed", Address = "Salalah", Grade = 70 };

        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

        static void Main(string[] args)
        {
            while (true)
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

                if (choice == "20")
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }

                switch (choice)
                {
                    case "1": ViewAccountDetails(); break;
                    case "2": UpdateStudentAddress(); break;
                    case "3": MakeDeposit(); break;
                    case "4": MakeWithdrawal(); break;
                    case "5": ViewProductDetails(); break;
                    case "6": RegisterStudent(); break;
                    case "7": CompareAccountBalances(); break;
                    case "8": RestockProduct(); break;
                    case "9": TransferBetweenAccounts(); break;
                    case "10": UpdateStudentGrade(); break;
                    case "11": StudentReportCard(); break;
                    case "12": AccountHealthStatus(); break;
                    case "13": BulkSaleWithRevenue(); break;
                    case "14": ScholarshipEligibilityCheck(); break;
                    case "15": FullBalanceTopUpFlow(); break;
                    case "16": QuickAccountOpening(); break;
                    case "17": TotalStudentsCounter(); break;
                    case "18": OverdrawnAccountCheck(); break;
                    case "19": SetStudentSecurityPIN(); break;
                    default: Console.WriteLine("Invalid choice. Please try again."); break;
                }

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ViewAccountDetails()
        {
            Console.Write("Choose an account to view details (1 or 2): ");
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
        }

        static void UpdateStudentAddress()
        {
            Console.Write("Choose a student to update address (1 or 2): ");
            string studentChoice = Console.ReadLine()!;

            Console.Write($"Enter new address for Student {studentChoice}: ");

            if (studentChoice == "1")
            {
                student1.Address = Console.ReadLine()!;
                Console.WriteLine("Address updated successfully.");
            }
            else if (studentChoice == "2")
            {
                student2.Address = Console.ReadLine()!;
                Console.WriteLine("Address updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid student choice.");
            }
        }

        static void MakeDeposit()
        {
            Console.Write("Choose an account to deposit into (1 or 2): ");
            string depositChoice = Console.ReadLine()!;

            Console.Write("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine()!);

            if (depositChoice == "1")
            {
                account1.Deposit(depositAmount);
            }
            else if (depositChoice == "2")
            {
                account2.Deposit(depositAmount);
            }
            else
            {
                Console.WriteLine("Invalid account choice.");
            }
        }

        static void MakeWithdrawal()
        {
            Console.Write("Choose an account to withdraw from (1 or 2): ");
            string withdrawChoice = Console.ReadLine()!;

            Console.Write("Enter withdrawal amount: ");
            double withdrawAmount = double.Parse(Console.ReadLine()!);

            if (withdrawChoice == "1")
            {
                account1.Withdraw(withdrawAmount);

            }
            else if (withdrawChoice == "2")
            {
                account2.Withdraw(withdrawAmount);
            }
            else
            {
                Console.WriteLine("Invalid account choice.");
            }
        }

        static void ViewProductDetails()
        {
            Console.Write("Choose a product to view details (1 or 2): ");
            string productChoice = Console.ReadLine()!;

            if (productChoice == "1")
            {
                product1.GetInventoryValue();
            }
            else if (productChoice == "2")
            {
                product2.GetInventoryValue();
            }
            else
            {
                Console.WriteLine("Invalid product choice.");
            }
        }

        static void RegisterStudent()
        {
            Console.Write("Choose a student to register (1 or 2): ");
            string registerChoice = Console.ReadLine()!;

            Console.Write("Enter email for registration: ");
            string email = Console.ReadLine()!;

            if (registerChoice == "1")
            {
                student1.Register(email);
            }
            else if (registerChoice == "2")
            {
                student2.Register(email);
            }
            else
            {
                Console.WriteLine("Invalid student choice.");
            }
        }

        static void CompareAccountBalances()
        {
            Console.WriteLine("Comparing account balances:");
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine("Account 1 has a higher balance");
            }
            else if (account1.Balance < account2.Balance)
            {
                Console.WriteLine("Account 2 has a higher balance");
            }
            else
            {
                Console.WriteLine("Both accounts have the same balance.");
            }
        }

        static void RestockProduct()
        {
            Console.Write("Choose a product to restock (1 or 2): ");
            string restockChoice = Console.ReadLine()!;

            Console.Write("Enter quantity to restock: ");
            int restockQuantity = int.Parse(Console.ReadLine()!);

            int currentStock = 0;

            if (restockChoice == "1")
            {
                product1.Restock(restockQuantity);
                currentStock = product1.StockQuantity;
            }
            else if (restockChoice == "2")
            {
                product2.Restock(restockQuantity);
                currentStock = product2.StockQuantity;
            }
            else
            {
                Console.WriteLine("Invalid product choice.");
            }

            if (currentStock < 10)
            {
                Console.WriteLine("Low");
            }
            else if (currentStock >= 10 && currentStock <= 49)
            {
                Console.WriteLine("Medium");
            }
            else
            {
                Console.WriteLine("Well Stocked");
            }
        }
    }
}
