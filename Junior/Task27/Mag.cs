namespace Task27;

public class Mag : Fighter
{
    public Mag(string name, int health, int damage, int armor = 0) : base(name, health, damage, armor){}
    
    public override int UniqueAbility()
    {
        Random random = new Random();
        Console.WriteLine($"{Name} запускает Огненный шар");
        return Damage * random.Next(3,7);
    }
}