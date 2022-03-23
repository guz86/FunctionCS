namespace Task24;

public class GeneratePlayer
{
    private Random rand = new Random();
    private string[] names = {"Саня", "Сеня", "Вася", "Женя", 
        "Иван", "Антон", "Леха", "Гена", "Макс", "Тоха", "Тимур", "Данил", "Денис"};
    
    public GeneratePlayer(int n, List<Player> players)
    {
        for (int i = 1; i < n + 1; i++)
        {
            string name = names[rand.Next(0,names.Length)];
            Player player = new Player(i, name, rand.Next(1, 10), false);
            players.Add(player);
        }
    }
}