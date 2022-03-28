namespace Task27;

public class Necromant : Fighter
{
    public int Mana { get; private set; }
    public int SucksHealth { get; private set; }

    public Necromant(string name, int health, int damage, int armor = 0) : base(name, health, damage, armor)
    {
        Mana = 100;
        SucksHealth = 0;
    }
    public override int UniqueAbility()
    {
        Random random = new Random();
        Mana -= random.Next(30, 50);
        if (Mana < 0) Mana = 0;
        SucksHealth = Damage * random.Next(3,6);
        Console.WriteLine($"{Name} высасывает здоровье {SucksHealth}, остатки маны: {Mana}");
        if (Mana > 0)
        {
            Health += SucksHealth;
        }
        return SucksHealth;
    }
}