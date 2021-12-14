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

            tankOne.Health = 100;
            tankOne.ShowStats();
            tankOne.TakeDamage(110);
            tankOne.ShowStats();
            Console.WriteLine("--------");
            // конструктор
            MilitaryMan SolderOne = new MilitaryMan();
            SolderOne.ShowStats();

            MilitaryMan SolderTwo = new MilitaryMan(90, 40);
            SolderTwo.ShowStats();

        }
    }
    
    class Tank
    {
        public int Armor;
        int _damage;
        public int Speed;
        public int Health;

        public void ShowStats()
        {
            Console.WriteLine($"Armor: {Armor}, Speed: {Speed}, Health: {Health}");
        }
        public void TakeDamage(int damage)
        {
            //this.Health
            Health -= damage-Armor;
            Console.WriteLine($"Take Damage: -{damage}hp");
        }

    }


    // конструкторы

    class MilitaryMan
    {
        public int Health;
        public int Armor;
        
        public MilitaryMan()
        {
            Health = 100;
            Armor = 50;
        }
        public MilitaryMan(int health, int armor)
        {
            Health = health;
            Armor = armor;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Health: {Health}, Armor: {Armor}");
        }

    }
}
