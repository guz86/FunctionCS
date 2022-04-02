namespace Task38;

public class Soldier
{
    public string Name { get; }
    public string Weapon { get; }
    public string Rank { get; }
    public int Period { get; }
    
    public Soldier(string name, string weapon, string rank, int period)
    {
        Name = name;
        Weapon = weapon;
        Rank = rank;
        Period = period;
    }
}