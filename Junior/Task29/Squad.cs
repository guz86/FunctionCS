namespace Task29;

public class Squad
{
    private Random _random = new Random();


    public List<Soldier> Soldiers { get; private set; }
    public string SquadName { get; set; }

    public Squad(string squadName)
    {
        SquadName = squadName;
    }
    
    public void AddSoldiers()
    {
        Soldiers = new List<Soldier>();
         
        Soldiers.Add(new Soldier(_random.Next(80,100), "Sniper", 100));
        Soldiers.Add(new Soldier(_random.Next(120,150), "Ordinary", 50));
        Soldiers.Add(new Soldier(_random.Next(150,180), "Pro", 80));
        Soldiers.Add(new Soldier(_random.Next(80,90), "Medic", 1));
    }

    public bool SquadLife()
    {
        if (Soldiers.Count == 0) return false;

        return true;
    }

    public void TakeDamage(int damage)
    {
        int randomSelectSoldier = _random.Next(0, Soldiers.Count);
        int randomSelectSoldierMedic = _random.Next(0, Soldiers.Count);
        
        Soldiers[randomSelectSoldier].TakeDamageSolder(damage);
        ConsoleColor defaultColor = Console.ForegroundColor;
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"В {SquadName} - {Soldiers[randomSelectSoldier].Skill}" +
                          $" получил {damage} урона, у него {Soldiers[randomSelectSoldier].HP} HP");

        // медик
        if (Soldiers[randomSelectSoldier].Skill == "Medic")
        {
            if (Soldiers[randomSelectSoldier].HP != 0 && Soldiers[randomSelectSoldierMedic].HP < 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Soldiers[randomSelectSoldierMedic].HP += 40;
                Console.WriteLine($"В {SquadName} {Soldiers[randomSelectSoldier].Skill} восстановил " +
                                  $"{Soldiers[randomSelectSoldierMedic].Skill} - " +
                                  $"{Soldiers[randomSelectSoldierMedic].HP} HP");
            }
        }
        
        // если убит
        if (Soldiers[randomSelectSoldier].HP == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($" - в {SquadName} убит {Soldiers[randomSelectSoldier].Skill}");
            Soldiers.RemoveAt(randomSelectSoldier);
        }

        Console.ForegroundColor = defaultColor;
    }
}