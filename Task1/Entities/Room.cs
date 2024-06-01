using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Entities
{
    public class Room
    {
        private static int _count;
        private int _id;

        public bool IsAvailable = true;
        public Room(string name, double price, int personCapacity)
        {
            _count++;
           _id = _count;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public int Id { get => _id;}
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {this.Id}\nName: {this.Name}\nPrice: {this.Price}\nPerson capacity: {this.PersonCapacity}\nAvailable: {this.IsAvailable}");
        }
    }
}
