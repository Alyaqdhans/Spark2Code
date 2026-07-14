namespace OOP_Part_2_Hotel_Management_System
{
    class Room
    {
        public string roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(string RoomNumber, string RoomType, double PricePerNight, bool IsAvailable)
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
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;

        public Guest(string GuestId, string GuestName, string RoomNumber, string CheckInDate, int TotalNights)
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
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();

        static void Main(string[] args)
        {
            rooms.Add(new Room("101", "Single", 100.0, true));
            rooms.Add(new Room("102", "Double", 150.0, true));
            rooms.Add(new Room("103", "Suite", 250.0, true));
            rooms.Add(new Room("104", "Single", 80.0, false));
            rooms.Add(new Room("105", "Double", 350.0, true));
            rooms.Add(new Room("106", "Suite", 550.0, true));

            while (true)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine()!;

                if (choice == "0")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                switch (choice)
                {
                    case "1": AddNewRoom(); break;
                    case "2": RegisterNewGuest(); break;
                    case "3": BookRoomForGuest(); break;
                    case "4": ViewAllRooms(); break;
                    case "5": ViewAllGuests(); break;
                    case "6": SearchAndFilterRooms(); break;
                    case "7": GuestAndBookingStatistics(); break;
                    case "8": UpdateRoomPrice(); break;
                    case "9": GuestLookupByName(); break;
                    case "10": RoomTypeBreakdownReport(); break;
                    case "11": CheckOutGuest(); break;
                    case "12": RemoveUnavailableRooms(); break;
                    case "13": ExtendGuestStay(); break;
                    case "14": HighestRevenueBooking(); break;
                    case "15": GuestPaginationViewer(); break;
                    default: Console.WriteLine("Invalid choice. Please try again."); break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AddNewRoom()
        {
            Console.Write("Enter Room Number: ");
            string roomNumber = Console.ReadLine()!;

            Console.Write("Enter Room Type (Single/Double/Suite): ");
            string roomType = Console.ReadLine()!;

            Console.Write("Enter Price Per Night: ");
            double pricePerNight = double.Parse(Console.ReadLine()!);

            if (rooms.Any(r => r.roomNumber == roomNumber))
            {
                Console.WriteLine("Room number already exists.");
                return;
            }

            rooms.Add(new Room(roomNumber, roomType, pricePerNight, true));

            Console.WriteLine("Room added successfully.");
            rooms.FirstOrDefault(r => r.roomNumber == roomNumber)!.displayRoom();
        }

        static void RegisterNewGuest()
        {
            Console.Write("Enter Guest Name: ");
            string guestName = Console.ReadLine()!;

            Console.Write("Enter check-in date (yyyy-mm-dd): ");
            string checkInDate = Console.ReadLine()!;

            Console.Write("Enter total nights of stay: ");
            int totalNights = int.Parse(Console.ReadLine()!);

            string guestId = "G" + (guests.Count + 1).ToString("D3");

            guests.Add(new Guest(guestId, guestName, "Not Assigned", checkInDate, totalNights));

            Console.WriteLine("Guest registered successfully.");
            guests.FirstOrDefault(g => g.guestId == guestId)!.displayGuest();
        }

        static void BookRoomForGuest()
        {

        }

        static void ViewAllRooms()
        {

        }

        static void ViewAllGuests()
        {

        }

        static void ViewAllGuestsCount()
        {

        }

        static void SearchAndFilterRooms()
        {

        }

        static void GuestAndBookingStatistics()
        {

        }

        static void UpdateRoomPrice()
        {

        }

        static void GuestLookupByName()
        {

        }

        static void RoomTypeBreakdownReport()
        {

        }

        static void CheckOutGuest()
        {

        }

        static void RemoveUnavailableRooms()
        {

        }

        static void ExtendGuestStay()
        {

        }

        static void HighestRevenueBooking()
        {

        }

        static void GuestPaginationViewer()
        {

        }
    }
}
