namespace CarList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW","F10",Type.Sport);
            car.ShowInfo();
            Car car1 = new Car("Mercedes", "C200", Type.Sedan);           
            car1.ShowInfo();
        }
    }
}
