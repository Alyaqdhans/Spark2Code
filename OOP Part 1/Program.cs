namespace OOP_Part_1
{
    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public bool BrokeAccount()
        {
            return (Balance < 0);
        }

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

        static int totalStudents = 1;
        int pin;

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Email sent to account holder.");
        }

        public static int studentCount()
        {
            return totalStudents;
        }

        public void setSecurityPIN(int Pin)
        {
            pin = Pin;
            Console.WriteLine("Security PIN set successfully.");
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

        static BankAccount account1 = new BankAccount(1163, "Karim", 120);
        static BankAccount account2 = new BankAccount(15203, "Ali", 63);

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

        static void TransferBetweenAccounts()
        {
            Console.Write("Enter a source account number (1 or 2): ");
            string sourceChoice = Console.ReadLine()!;

            Console.Write("Enter a destination account number (1 or 2): ");
            string destinationChoice = Console.ReadLine()!;

            Console.Write("Enter transfer amount: ");
            double transferAmount = double.Parse(Console.ReadLine()!);

            if (sourceChoice == "1" && transferAmount <= account1.Balance)
            {
                account1.Withdraw(transferAmount);
                account2.Deposit(transferAmount);
            }
            else if (sourceChoice == "2" && transferAmount <= account2.Balance)
            {
                account2.Withdraw(transferAmount);
                account1.Deposit(transferAmount);
            }
            else
            {
                Console.WriteLine("Insufficient funds for transfer.");
            }
        }

        static void UpdateStudentGrade()
        {
            Console.Write("Choose a student to update grade (1 or 2): ");
            string studentChoice = Console.ReadLine()!;

            Console.Write("Enter new grade (0-100): ");
            int newGrade = int.Parse(Console.ReadLine()!);

            if (newGrade < 0 || newGrade > 100)
            {
                Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
                return;
            }
            if (studentChoice == "1")
            {
                student1.Grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
            }
            else if (studentChoice == "2")
            {
                student2.Grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid student choice.");
            }
        }

        static void StudentReportCard()
        {
            Console.Write("Choose a student to view report card (1 or 2): ");
            string studentChoice = Console.ReadLine()!;

            string studentName = "";
            string studentAddress = "";
            int studentGrade = 0;

            if (studentChoice == "1")
            {
                studentName = student1.Name;
                studentAddress = student1.Address;
                studentGrade = student1.Grade;
            }
            else if (studentChoice == "2")
            {
                studentName = student2.Name;
                studentAddress = student2.Address;
                studentGrade = student2.Grade;
            }
            else
            {
                Console.WriteLine("Invalid student choice.");
            }

            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Address: " + studentAddress);
            Console.WriteLine("Grade: " + studentGrade);
            if (studentGrade >= 60) Console.WriteLine("Pass");
            else Console.WriteLine("Fail");
        }

        static void AccountHealthStatus()
        {
            Console.Write("Choose an account to check health status (1 or 2): ");
            string accountChoice = Console.ReadLine()!;

            double balance = 0;

            if (accountChoice == "1")
            {
                balance = account1.Balance;
            }
            else if (accountChoice == "2")
            {
                balance = account2.Balance;
            }
            else
            {
                Console.WriteLine("Invalid account choice.");
                return;
            }

            if (balance < 50)
            {
                Console.WriteLine("Low Balance");
            }
            else if (balance >= 50 && balance <= 1000)
            {
                Console.WriteLine("Healthy");
            }
            else
            {
                Console.WriteLine("Premium");
            }
        }

        static void BulkSaleWithRevenue()
        {
            Console.Write("Choose a product for bulk sale (1 or 2): ");
            string productChoice = Console.ReadLine()!;

            Console.Write("Enter quantity to sell: ");
            int saleQuantity = int.Parse(Console.ReadLine()!);

            double revenue = 0;
            int quantity = 0;

            if (productChoice == "1")
            {
                quantity = product1.StockQuantity;
            }
            else if (productChoice == "2")
            {
                quantity = product2.StockQuantity;
            }
            else
            {
                Console.WriteLine("Invalid product choice.");
                return;
            }

            if (saleQuantity > quantity)
            {
                Console.WriteLine($"Not enough stock for the sale, {saleQuantity - quantity} more is needed to fulfill the order.");
                return;
            }

            if (productChoice == "1")
            {
                product1.Sell(saleQuantity);
                revenue = saleQuantity * product1.Price;
            }
            else if (productChoice == "2")
            {
                product2.Sell(saleQuantity);
                revenue = saleQuantity * product2.Price;
            }

            Console.WriteLine("Total revenue from the sale: " + revenue);
        }

        static void ScholarshipEligibilityCheck()
        {
            Console.Write("Choose a student (1 or 2): ");
            string studentChoice = Console.ReadLine()!;

            Console.Write("Choose a bank account (1 or 2): ");
            string accountChoice = Console.ReadLine()!;

            if (studentChoice == "1" && student1.Grade < 80)
            {
                Console.WriteLine("Student 1 is not eligible for scholarship due to low grade.");
                return;

            }
            else if (studentChoice == "2" && student2.Grade < 80)
            {
                Console.WriteLine("Student 2 is not eligible for scholarship due to low grade.");
                return;
            }

            if (accountChoice == "1" && account1.Balance < 100)
            {
                Console.WriteLine("Student 1 is not eligible for scholarship due to low account balance.");
                return;
            }
            else if (accountChoice == "2" && account2.Balance < 100)
            {
                Console.WriteLine("Student 2 is not eligible for scholarship due to low account balance.");
                return;
            }

            Console.WriteLine("The student is eligible for scholarship.");
        }

        static void FullBalanceTopUpFlow()
        {
            Console.Write("Choose an account to top up (1 or 2): ");
            string accountChoice = Console.ReadLine()!;

            double balance = 0;

            if (accountChoice == "1")
            {
                balance = account1.Balance;
            }
            else if (accountChoice == "2")
            {
                balance = account2.Balance;
            }
            else
            {
                Console.WriteLine("Invalid account choice.");
                return;
            }

            double topUpAmount = 0;

            if (balance < 50)
            {
                Console.WriteLine("Account balance was: " + balance);

                if (accountChoice == "1")
                {
                    topUpAmount = 100 - balance;
                    account1.Deposit(topUpAmount);
                }
                else if (accountChoice == "2")
                {
                    topUpAmount = 100 - balance;
                    account2.Deposit(topUpAmount);
                }

                Console.WriteLine("Account balance is: " + (balance + topUpAmount));
            }
            else
            {
                Console.WriteLine("No top-up is needed.");
            }
        }

        static void QuickAccountOpening()
        {
            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Enter holder name: ");
            string holderName = Console.ReadLine()!;

            Console.Write("Enter initial balance: ");
            double balance = double.Parse(Console.ReadLine()!);

            BankAccount newAccount = new BankAccount(accountNumber, holderName, balance);
            newAccount.CheckBalance();

            Console.WriteLine("New account created successfully.");
        }

        static void TotalStudentsCounter()
        {
            int total = Student.studentCount();
            Console.WriteLine("Total number of students: " + total);
        }

        static void OverdrawnAccountCheck()
        {
            Console.Write("Choose an account to check (1 or 2): ");
            string accountChoice = Console.ReadLine()!;

            bool overDrawn;

            if (accountChoice == "1")
            {
                overDrawn = account1.BrokeAccount();
            }
            else if (accountChoice == "2")
            {
                overDrawn = account2.BrokeAccount();
            }
            else
            {
                Console.WriteLine("Invalid account choice.");
                return;
            }

            if (overDrawn)
            {
                Console.WriteLine("The account is overdrawn.");
            }
            else
            {
                Console.WriteLine("The account is NOT overdrawn.");
            }
        }

        static void SetStudentSecurityPIN()
        {
            Console.Write("Choose a student to set security PIN (1 or 2): ");
            string studentChoice = Console.ReadLine()!;

            Console.Write("Enter new security PIN: ");
            int pin = int.Parse(Console.ReadLine()!);

            if (studentChoice == "1")
            {
                student1.setSecurityPIN(pin);

            }
            else if (studentChoice == "2")
            {
                student2.setSecurityPIN(pin);
            }
            else
            {
                Console.WriteLine("Invalid student choice.");
            }
        }
    }
}
