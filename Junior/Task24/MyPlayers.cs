namespace Task24;

public class MyPlayers
{
    private Random rand = new Random();

    private string[] names =
    {
        "Саня", "Сеня", "Вася", "Женя", "Иван", "Антон", "Леха", "Гена", "Макс", "Тоха", "Тимур", "Данил", "Денис"
    };

    public MyPlayers(int n, List<Player> players)
    {
        for (int i = 1; i < n + 1; i++)
        {
            string name = names[rand.Next(0, names.Length)];
            Player player = new Player(i, name, rand.Next(1, 10), false);
            players.Add(player);
        }
    }

    public void AddPlayer(List<Player> players)
    {
        Console.WriteLine("Введите имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите уровень(1-10):");
        int.TryParse(Console.ReadLine(), out int level);
        Console.WriteLine("Игрок забанен (да/нет):");
        string checkFlag = Console.ReadLine();
        bool flag = false;
        if (checkFlag == "да") flag = true;
        Player player = new Player(players.Count + 1, name, level, flag);
        players.Add(player);
    }

    public void BanPlayer(List<Player> players)
    {
        Console.WriteLine("Введите номер игрока:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number < players.Count) players[number - 1].BanPlayer(number - 1);
    }

    public void NoBanPlayer(List<Player> players)
    {
        Console.WriteLine("Введите номер игрока:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number < players.Count) players[number - 1].NoBanPlayer(number - 1);
    }

    public void DelPlayer(List<Player> players)
    {
        Console.WriteLine("Введите номер игрока:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number < players.Count) players.RemoveAt(number - 1);

        foreach (var player in players)
        {
            if (player.Number > number - 1) player.CorrectNumber(number - 1);
        }
    }
}