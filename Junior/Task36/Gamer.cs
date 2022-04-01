namespace Task36;

public class Gamer
{
    public string Name { get; }
    public int Level { get; }
    public int Power { get; }

    public Gamer(string name, int level, int power)
    {
        Name = name;
        Level = level;
        Power = power;
    }
}