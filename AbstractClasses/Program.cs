using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // сar1 = new Car();
            //сar1.Move();

            //Car car2 = new Car();
            //car2.Move();

            //Vehicle tractor1 = new Tractor();
            //tractor1.Move();

            Vehicle[] vehicles = {new Car(), new Tractor()};

            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
                Console.WriteLine(vehicle.GetCurrentSpeed());
            }
        }
    }
}
