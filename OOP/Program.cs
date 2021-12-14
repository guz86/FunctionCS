using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tankOne = new Tank();
            tankOne.Armor = 100;
            Tank tankTwo;
            tankTwo = tankOne;
            tankTwo.Speed = 900;
            Console.WriteLine($"Armor Tank Two = {tankTwo.Armor}");
            Console.WriteLine($"Armor Tank One = {tankTwo.Speed}");
        }
    }
    
    class Tank
    {
        public int Armor;
        int _damage;
        public int Speed;

    }
}
