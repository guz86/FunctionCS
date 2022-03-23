namespace Task22;

public class Player
{
    private string _name;
    private int _health;

    public Player(string name, int health)
    {
        _name = name;
        _health = health;
    }

    public void PlayerInfo()
    {
        Console.WriteLine($"Name: {_name}, health: {_health}");
    }
}