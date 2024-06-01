using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.ExceptionHandler;

namespace Task1.Entities
{
    public class Hotel
    {
        private static int _count;
        private int _id;
        private Room[] rooms = Array.Empty<Room>();
        public Hotel(string name)
        {
            _count++;
            _id = _count;
            Name = name;
        }
        public int Id { get => _id; }
        public string Name { get; set; }
        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;
            Console.WriteLine(room.Name + " " + "added\n" );
        }
        public void MakeReservation(int? roomId)
        {
            
            if (roomId == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                foreach (Room room in rooms)
                {
                    if(room.Id == roomId)
                    {
                        if (room.IsAvailable == false)
                        {
                            throw new NotAvailableException("Room is not available.Choose another one.");
                        }
                        else
                        {
                            room.IsAvailable = false;
                            Console.WriteLine("Reservation confirmed");
                        }
                    }
                }
            }
        }
    }
}
