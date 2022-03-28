namespace Task27;

public abstract class Fighter
{
    public string Name{ get; }
    public int Health { get; protected set; }
    public int Damage { get; }
    public int Armor { get; protected set; }

    public Fighter(string name, int health, int damage, int armor)
    {
        Name = name;
        Health = health;
        Damage = damage;
        Armor = armor;
    }

    public void ShowStats()
    {
        Console.WriteLine($"{Name}, Health {Health}, Damage {Damage}, Armor {Armor}");
    }

    public void TakeDamage(int damage)
    {
        // 50 - 100
        Health -= damage - Armor;
        if (Health < 0)
        {
            Health = 0;
        }
        Console.WriteLine($"{Name} получает: {damage}, здоровье стало {Health}");
    }
    
    public bool isAlive()
    {
        return Health > 0;
    }

    public abstract int UniqueAbility();
}