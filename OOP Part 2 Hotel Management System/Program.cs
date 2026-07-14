namespace OOP_Part_2_Hotel_Management_System
{
    class Room
    {
        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(int RoomNumber, string RoomType, double PricePerNight, bool IsAvailable)
        {
            roomNumber = RoomNumber;
            roomType = RoomType;
            pricePerNight = PricePerNight;
            isAvailable = IsAvailable;
        }

        public void displayRoom()
        {
            Console.WriteLine($"Room Number: {roomNumber}");
            Console.WriteLine($"Room Type: {roomType}");
            Console.WriteLine($"Price Per Night: {pricePerNight}");
            Console.WriteLine($"Is Available: {isAvailable}");
        }
    }

    class Guest
    {
        public int guestId;
        public string guestName;
        public int roomNumber;
        public string checkInDate;
        public int totalNights;

        public Guest(int GuestId, string GuestName, int RoomNumber, string CheckInDate, int TotalNights)
        {
            guestId = GuestId;
            guestName = GuestName;
            roomNumber = RoomNumber;
            checkInDate = CheckInDate;
            totalNights = TotalNights;
        }

        public void displayGuest()
        {
            Console.WriteLine($"Guest ID: {guestId}");
            Console.WriteLine($"Guest Name: {guestName}");
            Console.WriteLine($"Room Number: {roomNumber}");
            Console.WriteLine($"Check-In Date: {checkInDate}");
            Console.WriteLine($"Total Nights: {totalNights}");
        }

        public void calculateTotalCost(double pricePerNight)
        {
            double totalCost = pricePerNight * totalNights;
            Console.WriteLine($"Total Cost: {totalCost}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
