namespace Task27;

public class Warrior : Fighter
{
    private bool _agr;
    private int _iAgr;

    public Warrior(string name, int health, int damage, int armor = 15) : base(name, health, damage, armor)
    {
    }

    public override int UniqueAbility()
    {
        Random random = new Random();
        _iAgr++;
        if (!_agr)
        {
            Armor = Armor * random.Next(2, 4);
            Console.WriteLine($"{Name} вызывает АГР, Armor стал: {Armor}");
            _agr = true;
        }

        if (_iAgr > 2)
        {
            _agr = false;
            Console.WriteLine("АГР снят.");
            _iAgr = 0;
            Armor = 15;
        }

        return Damage;
    }
}