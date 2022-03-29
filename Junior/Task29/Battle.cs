namespace Task29;

public class Battle
{
    public List<Squad> BattleSquads { get;  }
    public Battle()
    {
        BattleSquads = new List<Squad>();
        BattleSquads.Add(new Squad("Manga"));
        BattleSquads.Add(new Squad("SaTTela"));
        BattleSquads[0].AddSoldiers();
        BattleSquads[1].AddSoldiers();
    }

    public void ShowSquads()
    {
        Console.WriteLine($"\n[Состав {BattleSquads[0].SquadName} = {BattleSquads[0].Soldiers.Count}]");

        foreach (var soldier in BattleSquads[0].Soldiers)
        {
            Console.WriteLine($"{soldier.Skill}, hp:{soldier.HP}, damage:{soldier.Damage}"); 
        }
        Console.WriteLine();
        
        Console.WriteLine($"\n[Состав {BattleSquads[1].SquadName} = {BattleSquads[1].Soldiers.Count}]");
        foreach (var soldier in BattleSquads[1].Soldiers)
        {
            Console.WriteLine($"{soldier.Skill}, hp:{soldier.HP}, damage:{soldier.Damage}"); 
        }
        Console.WriteLine();
    }
}