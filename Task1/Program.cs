using Task1.Entities;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hotel hotel = new Hotel("Giggle");

            Room room = new Room("Jupiter", 85, 2);
            room.ShowInfo();
            hotel.AddRoom(room);

            Room room1 = new Room("Mars", 70, 1);
            room1.ShowInfo();
            hotel.AddRoom(room1);

            hotel.MakeReservation(2);

            try
            {
                hotel.MakeReservation(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); 
            }
            try
            {
                hotel.MakeReservation(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Program is working");
        }
    }
}
