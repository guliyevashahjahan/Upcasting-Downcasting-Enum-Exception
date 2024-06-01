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
       
        public Car(string brand,string model,Type type)
        {
            _count++;
            Brand = brand;
            Model = model;
            Type = type;
        }
        public int Id { get => _count; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Type Type { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {this.Id}\nBrand: {this.Brand}\nModel: {this.Model}\nType: {this.Type}");
        }
    }
}
