namespace OOP_Part_2_Hotel_Management_System
{
    class Room
    {
        int roomNumber;
        string roomType;
        double pricePerNight;
        bool isAvailable;

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

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
