namespace Task29;

public class Squad
{
    private Random _random = new Random();

    public List<Soldier> Soldiers { get; private set; }
    public string SquadName { get;  }

    public Squad(string squadName)
    {
        SquadName = squadName;
    }

    public void AddSoldiers()
    {
        Soldiers = new List<Soldier>();

        Soldiers.Add(new Soldier(_random.Next(80, 100), "Sniper", 100));
        Soldiers.Add(new Soldier(_random.Next(120, 150), "Ordinary", 50));
        Soldiers.Add(new Soldier(_random.Next(150, 180), "Pro", 80));
        Soldiers.Add(new Soldier(_random.Next(80, 90), "Medic", 1));
    }

    public bool SquadLife()
    {
        if (Soldiers.Count == 0) return false;

        return true;
    }

    public void TakeDamage(int damage)
    {
        int idRandomSelectSoldier = _random.Next(0, Soldiers.Count);
        Soldier randomSelectSoldier = Soldiers[idRandomSelectSoldier];
        Soldier randomSelectSoldierMedic = Soldiers[_random.Next(0, Soldiers.Count)];

        randomSelectSoldier.TakeDamageSolder(damage);
        ConsoleColor defaultColor = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"В {SquadName} - {randomSelectSoldier.Skill}" +
                          $" получил {damage} урона, у него {randomSelectSoldier.HP} HP");

        // медик
        if (randomSelectSoldier.Skill == "Medic")
        {
            if (randomSelectSoldier.HP != 0 && randomSelectSoldierMedic.HP < 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                randomSelectSoldierMedic.HP += 40;
                Console.WriteLine($"В {SquadName} {randomSelectSoldier.Skill} восстановил " +
                                  $"{randomSelectSoldierMedic.Skill} - " + $"{randomSelectSoldierMedic.HP} HP");
            }
        }

        // если убит
        if (randomSelectSoldier.HP == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($" - в {SquadName} убит {randomSelectSoldier.Skill}");
            Soldiers.Remove(randomSelectSoldier);
        }

        Console.ForegroundColor = defaultColor;
    }
}