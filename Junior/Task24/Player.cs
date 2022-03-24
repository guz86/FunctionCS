namespace Task24;

public class Player
{
    public int Number { get; private set; }
    public string Name { get; }
    public int Level { get; }
    public bool Flag { get; private set; }

    public Player(int number, string name, int level, bool flag)
    {
        Number = number;
        Name = name;
        Level = level;
        Flag = flag;
    }

    public void BanPlayerFlag(int number)
    {
        Flag = true;
    }

    public void NoBanPlayerFlag(int number)
    {
        Flag = false;
    }

    public void CorrectNumber(int number)
    {
        Number -= 1;
    }
}