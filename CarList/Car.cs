using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarList
{
    public class Car
    {
        private static int _count;
        private int _id;
       
        public Car(string brand,string model,Type type)
        {
            _count++;
            _id = _count;
            Brand = brand;
            Model = model;
            Type = type;
        }
        public int Id { get => _id; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Type Type { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {this.Id}\nBrand: {this.Brand}\nModel: {this.Model}\nType: {this.Type}");
        }
    }
}
