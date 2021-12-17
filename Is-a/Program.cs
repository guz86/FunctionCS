using System;

namespace Is_a
{
    class Program
    {
        static void Main(string[] args)
        {
            // рыцарь и варвар
            Knight knight = new Knight();
            knight.ShowInfo();
            knight.TakeDamage(10);
            knight.ShowInfo();

            Barbarian barbarian = new Barbarian();
            barbarian.ShowInfo();
            barbarian.TakeDamage(30);
            barbarian.ShowInfo();
            
            Knight knightTwo = new Knight(120,20,10);
            knightTwo.ShowInfo();
            knightTwo.TakeDamage(10);
            knightTwo.ShowInfo();
        }
    }

    class Warrior
    {
        protected int Health;
        protected int Damage;
        protected int Armor;

        public Warrior(int health, int damage, int armor)
        {
            Health = health;
            Damage = damage;
            Armor = armor;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage- Armor;
            Console.WriteLine($"Нанесено {damage - Armor} урона");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}, Damage: {Damage}, Armor: {Armor}");
        }

    }

    class Knight : Warrior
    {
        public Knight(int health = 100, int damage = 10, int armor = 5) :  base(health, damage, armor)
        {

        }
    }

    class Barbarian : Warrior
    {
        protected int AttackSpeed;
        public Barbarian(int health = 200, int damage = 5, int armor = 2, int attackSpeed = 5) : base(health, damage, armor)
        {
            AttackSpeed = attackSpeed;
        }
    }
}
