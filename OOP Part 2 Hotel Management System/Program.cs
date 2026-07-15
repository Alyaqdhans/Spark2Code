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

        public double calculateTotalCost(double pricePerNight)
        {
            return pricePerNight * totalNights;
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

                Console.Write("Press any key to continue...");
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
            Console.Write("Enter Guest ID: ");
            string guestId = Console.ReadLine()!;

            Console.Write("Enter Room Number: ");
            string roomNumber = Console.ReadLine()!;

            Guest guest = guests.FirstOrDefault(g => g.guestId == guestId)!;
            Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber)!;

            if (guest == null || room == null)
            {
                Console.WriteLine("Guest or Room not found.");
                return;
            }

            if (room.isAvailable == false)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }

            guest.roomNumber = room.roomNumber;
            room.isAvailable = false;

            Console.WriteLine("Room booked sucessfully.");
            Console.WriteLine("Guest Name: " + guest.guestName);
            Console.WriteLine("Room Number: " + room.roomNumber);
            Console.WriteLine("Room Type: " + room.roomType);
            Console.WriteLine("Price Per Night: " + room.pricePerNight);
            double totalCost = guest.calculateTotalCost(room.pricePerNight);
            Console.WriteLine("Total Cost for Stay: " + totalCost);
        }

        static void ViewAllRooms()
        {
            List<Room> filteredRooms = rooms.Select(r => new Room(r.roomNumber, r.roomType, r.pricePerNight, r.isAvailable))
                                            .OrderBy(r => r.roomNumber)
                                            .ToList();
            if (filteredRooms.Count == 0)
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            Console.WriteLine($"Rooms List ({filteredRooms.Count}): ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Room Number | Room Type | Price Per Night | Is Available");
            foreach (Room room in filteredRooms)
            {
                string roomStatus = room.isAvailable ? "Available" : "Booked";
                Console.WriteLine($"{room.roomNumber} | {room.roomType} | {room.pricePerNight} | {roomStatus}");
            }
            Console.WriteLine("------------------------------------------------");
        }

        static void ViewAllGuests()
        {
            List<Guest> filteredGuests = guests.Select(g => new Guest(g.guestId, g.guestName, g.roomNumber, g.checkInDate, g.totalNights))
                                              .OrderBy(g => g.guestId)
                                              .ToList();
            if (filteredGuests.Count == 0)
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            Console.WriteLine($"Guests List ({filteredGuests.Count}): ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Guest ID | Guest Name | Room Number | Check-In Date | Total Nights");
            foreach (Guest guest in filteredGuests)
            {
                Console.WriteLine($"{guest.guestId} | {guest.guestName} | {guest.roomNumber} | {guest.checkInDate} | {guest.totalNights}");
            }
            Console.WriteLine("------------------------------------------------");
        }

        static void SearchAndFilterRooms()
        {
            while (true)
            {
                Console.WriteLine("Search & Filter Rooms:");
                Console.WriteLine("1. Show all available rooms");
                Console.WriteLine("2. Filter by room type");
                Console.WriteLine("3. Filter by max price");
                Console.WriteLine("4. Room price statistics");
                Console.WriteLine("0. Back");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine()!;

                if (choice == "0")
                {
                    Console.WriteLine("Returning to main menu...");
                    break;
                }

                switch (choice)
                {
                    case "1":
                        List<Room> availableRooms = rooms.Where(r => r.isAvailable)
                                                         .OrderBy(r => r.pricePerNight)
                                                         .ToList();
                        if (availableRooms.Count == 0)
                        {
                            Console.WriteLine("No available rooms.");
                            break;
                        }

                        Console.WriteLine($"Available Rooms ({availableRooms.Count}):");
                        foreach (Room room in availableRooms)
                        {
                            room.displayRoom();
                            Console.WriteLine("--------------------");
                        }
                        break;

                    case "2":
                        Console.Write("Enter room type to filter (Single/Double/Suite): ");
                        string roomType = Console.ReadLine()!;

                        List<Room> filteredRooms = rooms.Where(r => r.roomType == roomType).ToList();

                        if (filteredRooms.Count == 0)
                        {
                            Console.WriteLine("No available rooms.");
                            break;
                        }

                        Console.WriteLine($"Rooms of type {roomType} ({filteredRooms.Count}):");
                        foreach (Room room in filteredRooms)
                        {
                            room.displayRoom();
                            Console.WriteLine("--------------------");
                        }
                        break;

                    case "3":
                        Console.Write("Enter max price to filter: ");
                        double maxPrice = double.Parse(Console.ReadLine()!);

                        List<Room> filteredByPrice = rooms.Where(r => r.pricePerNight <= maxPrice).ToList();

                        if (filteredByPrice.Count == 0)
                        {
                            Console.WriteLine("No available rooms.");
                            break;
                        }

                        Console.WriteLine($"Rooms with price <= {maxPrice} ({filteredByPrice.Count}):");
                        foreach (Room room in filteredByPrice)
                        {
                            room.displayRoom();
                            Console.WriteLine("--------------------");
                        }
                        break;

                    case "4":
                        if (rooms.Count == 0)
                        {
                            Console.WriteLine("No rooms have been added yet.");
                            break;
                        }

                        Console.WriteLine("Room Price Statistics:");
                        Console.WriteLine("Total Rooms: " + rooms.Count);
                        Console.WriteLine("Available Rooms: " + rooms.Where(r => r.isAvailable).ToList().Count);
                        Console.WriteLine("Average Price: " + rooms.Average(r => r.pricePerNight).ToString("0.00"));
                        Console.WriteLine("Cheapest Price: " + rooms.Min(r => r.pricePerNight).ToString("0.00"));
                        Console.WriteLine("Most Expensive Price: " + rooms.Max(r => r.pricePerNight).ToString("0.00"));
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void GuestAndBookingStatistics()
        {
            Console.WriteLine("Guest & Booking Statistics:");

            Console.WriteLine("Total Guests: " + guests.Count);
            int assignedRooms = guests.Where(g => g.roomNumber != "Not Assigned").ToList().Count;
            Console.WriteLine("Guests with Assigned Rooms: " + assignedRooms);

            Console.WriteLine("Total Rooms: " + rooms.Count);
            int bookedRooms = rooms.Where(r => r.isAvailable == false).ToList().Count;
            Console.WriteLine("Booked Rooms: " + bookedRooms);

            if (guests.Any())
            {
                double averageNights = guests.Where(g => g.roomNumber != "Not Assigned")
                                             .Average(g => g.totalNights);
                Console.WriteLine("Average Nights of Stay: " + averageNights);
            }

            List<Guest> spendingGuests = guests.Where(g => g.roomNumber != "Not Assigned")
                                               .OrderByDescending(g => g.calculateTotalCost(rooms.FirstOrDefault(r => r.roomNumber == g.roomNumber)!.pricePerNight))
                                               .Take(3).ToList();
            if (spendingGuests.Any())
            {
                Console.WriteLine("Top 3 Guests by Spending:");
                foreach (Guest guest in spendingGuests)
                {
                    double totalCost = guest.calculateTotalCost(rooms.FirstOrDefault(r => r.roomNumber == guest.roomNumber)!.pricePerNight);
                    Console.WriteLine($"Guest Name: {guest.guestName}, Total Cost: {totalCost.ToString("0.00")}");
                }
            }


            List<Guest> bookedGuests = guests.Where(g => g.roomNumber != "Not Assigned")
                                             .Select(g => new Guest(g.guestId, g.guestName, g.roomNumber, g.checkInDate, g.totalNights))
                                             .ToList();
            if (bookedGuests.Any())
            {
                Console.WriteLine("Summary of booked guests:");
                Console.WriteLine("Guest Name - Room Number - Total Nights - Total Cost");
                foreach (Guest guest in bookedGuests)
                {
                    double totalCost = guest.calculateTotalCost(rooms.FirstOrDefault(r => r.roomNumber == guest.roomNumber)!.pricePerNight);
                    Console.WriteLine($"{guest.guestName} - {guest.roomNumber} - {guest.totalNights} - {totalCost.ToString("0.00")}");
                }
            }
        }

        static void UpdateRoomPrice()
        {
            Console.Write("Enter Room Number to update price: ");
            string roomNumber = Console.ReadLine()!;

            Room foundRoom = rooms.FirstOrDefault(r => r.roomNumber == roomNumber)!;

            if (foundRoom == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            Console.Write($"Enter new price for Room {roomNumber}: ");
            double newPrice = double.Parse(Console.ReadLine()!);

            if (newPrice <= 0)
            {
                Console.WriteLine("Invalid Price.");
                return;
            }

            Console.WriteLine("Room price updated successfully.");
            Console.WriteLine("Old Price: " + foundRoom.pricePerNight);
            foundRoom.pricePerNight = newPrice;
            Console.WriteLine("New Price: " + newPrice);
        }

        static void GuestLookupByName()
        {
            Console.Write("Enter Guest Name to search: ");
            string guestName = Console.ReadLine()!;

            List<Guest> foundGuests = guests.Where(g => g.guestName.ToLower().Contains(guestName.ToLower())).ToList();

            if (foundGuests.Any() == false)
            {
                Console.WriteLine("No guests found with the name: " + guestName);
                return;
            }

            Console.WriteLine($"Found Guests ({foundGuests.Count}):");
            Console.WriteLine("--------------------");
            foreach (Guest guest in foundGuests)
            {
                guest.displayGuest();
                Console.WriteLine("--------------------");
            }
        }

        static void RoomTypeBreakdownReport()
        {
            Console.WriteLine("Room Type Breakdown Report:");

            List<Room> singleRooms = rooms.Where(r => r.roomType == "Single").ToList();
            Console.WriteLine("Total Rooms (Single): " + singleRooms.Count);
            Console.Write("Average Price (Single): ");
            if (singleRooms.Count == 0) Console.WriteLine("N/A");
            else Console.WriteLine(singleRooms.Average(r => r.pricePerNight).ToString("0.00"));

            List<Room> doubleRooms = rooms.Where(r => r.roomType == "Double").ToList();
            Console.WriteLine("Total Rooms (Double): " + doubleRooms.Count);
            Console.Write("Average Price (Double): ");
            if (doubleRooms.Count == 0) Console.WriteLine("N/A");
            else Console.WriteLine(doubleRooms.Average(r => r.pricePerNight).ToString("0.00"));

            List<Room> suiteRooms = rooms.Where(r => r.roomType == "Suite").ToList();
            Console.WriteLine("Total Rooms (Suite): " + suiteRooms.Count);
            Console.Write("Average Price (Suite): ");
            if (suiteRooms.Count == 0) Console.WriteLine("N/A");
            else Console.WriteLine(suiteRooms.Average(r => r.pricePerNight).ToString("0.00"));

            Console.WriteLine("Total Rooms: " + rooms.Count);
            Console.Write("Average Price (All Rooms): ");
            if (rooms.Count == 0) Console.WriteLine("N/A");
            else Console.WriteLine(rooms.Average(r => r.pricePerNight).ToString("0.00"));
        }

        static void CheckOutGuest()
        {
            Console.Write("Enter Guest ID to check out: ");
            string guestId = Console.ReadLine()!;

            Guest foundGuest = guests.FirstOrDefault(g => g.guestId == guestId)!;

            if (foundGuest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            if (foundGuest.roomNumber == "Not Assigned")
            {
                Console.WriteLine("Guest has no active booking.");
                return;
            }

            Room foundRoom = rooms.FirstOrDefault(r => r.roomNumber == foundGuest.roomNumber)!;

            Console.WriteLine("Guest Name: " + foundGuest.guestName);
            Console.WriteLine("Room Number: " + foundRoom.roomNumber);
            Console.WriteLine("Room Type: " + foundRoom.roomType);
            Console.WriteLine("Check-In Date: " + foundGuest.checkInDate);
            Console.WriteLine("Total Nights: " + foundGuest.totalNights);
            Console.WriteLine("Price Per Night: " + foundRoom.pricePerNight);
            Console.WriteLine("Total Cost for Stay: " + foundGuest.calculateTotalCost(foundRoom.pricePerNight));

            Console.Write("Confirm check-out? (Y/N): ");
            string confirm = Console.ReadLine()!;

            if (confirm.ToLower() == "n")
            {
                Console.WriteLine("Check-out cancelled.");
                return;
            }

            foundRoom.isAvailable = true;
            guests.Remove(foundGuest);
            Console.WriteLine("Guest checked out successfully.");
            
            Console.WriteLine("Available Rooms: " + rooms.Where(r => r.isAvailable).ToList().Count);
            Console.WriteLine("Total Guests: " + guests.Count);

            if (rooms.Where(r => r.roomNumber == foundRoom.roomNumber).Any())
            {
                Console.WriteLine("Room " + foundRoom.roomNumber + " is now available for booking.");
            }
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
