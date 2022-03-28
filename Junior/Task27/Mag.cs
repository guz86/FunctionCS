namespace Task27;

public class Mag : Fighter
{
    public int Mana { get; private set; }

    public Mag(string name, int health, int damage, int armor = 0) : base(name, health, damage, armor)
    {
        Mana = 100;
    }
    
    public override int UniqueAbility()
    {
        Random random = new Random();
        Mana -= random.Next(30, 50);
        if (Mana < 0) Mana = 0;
        Console.WriteLine($"{Name} запускает Огненный шар, остатки маны: {Mana}");
        if (Mana > 0)
        {
            return Damage * random.Next(9,13);
        }

        return Damage;
    }
}