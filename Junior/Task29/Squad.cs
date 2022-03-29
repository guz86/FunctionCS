namespace Task29;

public class Squad
{
    private Random _random = new Random();

    public List<Soldier> Soldiers { get; set; }
    public string SquadName { get; set; }

    public void AddSoldiers()
    {
        Soldiers = new List<Soldier>();
        int randomHP = _random.Next(150);
        Soldiers.Add(new Soldier(100, "Sniper", 100));
        Soldiers.Add(new Soldier(randomHP, "Ordinary", 50));
    }

    public bool SquadLife()
    {
        if (Soldiers.Count == 0) return false;

        return true;
    }

    public void TakeDamage(int damage)
    {
        int randomSelectSoldier = _random.Next(0, Soldiers.Count);
        Soldiers[randomSelectSoldier].TakeDamageSolder(damage);
        Console.WriteLine($"В {SquadName} - {randomSelectSoldier + 1} солдат {Soldiers[randomSelectSoldier].Skill}" +
                          $" получил {damage} урона, у него {Soldiers[randomSelectSoldier].HP} HP");

        // если убит
        if (Soldiers[randomSelectSoldier].HP == 0)
        {
            Console.WriteLine($"в {SquadName} убит {Soldiers[randomSelectSoldier].Skill}");
            Soldiers.RemoveAt(randomSelectSoldier);
        }

        Console.WriteLine($"Состав {SquadName}: {Soldiers.Count} солдат");
    }
}