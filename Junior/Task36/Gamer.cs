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
    public void PrintGamer()
    {
        Console.WriteLine($"{Name}\tLevel: {Level}\tPower: {Power}");
    }
}