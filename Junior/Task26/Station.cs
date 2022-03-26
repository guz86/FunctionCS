namespace Task26;

public class Station
{
    private List<string> _ways = new List<string>()
    {
        "Санкт-Петербург - Москва",
        "Казань - Москва",
        "Москва - Екатеринбург",
        "Иваново - Кемерово"
    };
    public List<string> LineBoard { get; }
    
    public Station()
    {
        LineBoard = new List<string>();
    }

    public void AddLineBoard(Way way)
    {
        LineBoard.Add(way.WayInformation);
    }

    public void InfoLineBoard()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("Информация о рейсах: ");
        foreach (var line in LineBoard)
        {
            Console.WriteLine($"* {line}");
        }
        
        Console.WriteLine("---------------------\n");
    }

    public void Work()
    {
        Random rand = new Random();
        while (true)
        {
            if (LineBoard.Count > 0)
            {
                InfoLineBoard();
            }

            Console.WriteLine("Формируется направление:");
            Thread.Sleep(1500);
            string enterWay = _ways[rand.Next(0,_ways.Count)];
            Console.WriteLine(enterWay);
            if (enterWay != "")
            {
                Way way = new Way(enterWay);
                way.BuyTiket(rand.Next(500, 1000));
                Thread.Sleep(1500);
                Console.WriteLine($"{way.WayPassengers} - пассажиров готовы к отправлению");
                Train train = new Train(way.WayPassengers);
                train.TrainLeaves();
                AddLineBoard(way);
            }

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.End)
            {
                return;
            }

            Console.Clear();
        }
    }
}