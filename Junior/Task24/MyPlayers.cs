namespace Task24;

public class MyPlayers
{
    private Random rand = new Random();

    private string[] names =
    {
        "Саня", "Сеня", "Вася", "Женя", "Иван", "Антон", "Леха", "Гена", "Макс", "Тоха", "Тимур", "Данил", "Денис"
    };

    private List<Player> players;

    public MyPlayers(int n)
    {
        players = new List<Player>();
        for (int i = 1; i < n + 1; i++)
        {
            string name = names[rand.Next(0, names.Length)];
            Player player = new Player(i, name, rand.Next(1, 10), false);
            players.Add(player);
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
            Player player = new Player(players.Count + 1, name, level, flag);
            players.Add(player);
        }
    }

    public void BanPlayer()
    {
        Console.WriteLine("Введите номер игрока:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number < players.Count) players[number - 1].BanPlayerFlag(number - 1);
    }

    public void NoBanPlayer()
    {
        Console.WriteLine("Введите номер игрока:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number < players.Count) players[number - 1].NoBanPlayerFlag(number - 1);
    }

    public void DelPlayer()
    {
        Console.WriteLine("Введите номер игрока:");
        int.TryParse(Console.ReadLine(), out int number);
        if (number <= players.Count) players.RemoveAt(number - 1);

        foreach (var player in players)
        {
            if (player.Number > number - 1) player.CorrectNumber(number - 1);
        }
    }

    public void ShowPlayers()
    {
        Console.WriteLine("***** База Игроков *****");
        foreach (var player in players)
        {
            Console.WriteLine($"{player.Number}.\tИмя: {player.Name}\tУровень: {player.Level}\tБан: {player.Flag}");
        }
    }
}
