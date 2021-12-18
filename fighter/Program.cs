using System;

namespace fighter
{
    class Program
    {
        static void Main(string[] args)
        {

            Fighter Heavy = new Fighter("John",100,5,15);
            Fighter Low = new Fighter("Leon", 80, 5, 25);
            Fighter Maks = new Fighter("Leon", 90, 1, 35);
            Fighter Sam = new Fighter("Sanya", 60, 0, 45);
           
            Fighter[] fighters= {Heavy, Low , Maks , Sam, new Fighter("Anton", 99, 0, 5) };

            for (int i = 0; i < fighters.Length; i++)
            {
                fighters[i].ShowStats();
            }
        }
    }

    class Fighter
    {
        private string _name;
        private int _health;
        private int _armor;
        private int _damage;

        public Fighter(string name, int health, int armor, int damage)
        {
            _name = name;
            _health = health;
            _armor = armor;
            _damage = damage;
        }
        
        public void ShowStats()
        {
            Console.WriteLine($"{_name}, {_health} - health, {_armor} - armor, {_damage} - damage");
        }

    }
    
 
}
