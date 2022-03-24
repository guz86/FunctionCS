namespace Task24;

public class MyPlayers
{
    private Random rand = new Random();

    private string[] names =
    {
        "Саня", "Сеня", "Вася", "Женя", "Иван", "Антон", "Леха", "Гена", "Макс", "Тоха", "Тимур", "Данил", "Денис"
    };

    public List<Player> Players { get; }
    
    public MyPlayers(int n)
    {
        Players = new List<Player>();
        for (int i = 1; i < n + 1; i++)
        {
            string name = names[rand.Next(0, names.Length)];
            Player player = new Player(i, name, rand.Next(1, 10), false);
            Players.Add(player);
        }
    }

    public void AddPlayer()
    {
        Console.WriteLine("Введите имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите уровень(1-10):");
        int.TryParse(Console.ReadLine(), out int level);
        Console.WriteLine("Игрок забанен (да/нет):");
        string checkFlag = Console.ReadLine();
        bool flag = false;
        if (checkFlag == "да") flag = true;
        if (name != null && level != null)
        {
            Player player = new Player(Players.Count + 1, name, level, flag);
            Players.Add(player);
        }
    }

    public void BanPlayer()
    {
        Console.WriteLine("Введите номер игрока:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number < Players.Count) Players[number - 1].BanPlayerFlag(number - 1);
    }

    public void NoBanPlayer()
    {
        Console.WriteLine("Введите номер игрока:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number < Players.Count) Players[number - 1].NoBanPlayerFlag(number - 1);
    }

    public void DelPlayer()
    {
        Console.WriteLine("Введите номер игрока:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number <= Players.Count) Players.RemoveAt(number - 1);

        foreach (var player in Players)
        {
            if (player.Number > number - 1) player.CorrectNumber(number - 1);
        }
    }
}