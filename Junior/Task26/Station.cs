namespace Task26;

public class Station
{
    public List<string> LineBoard { get;  }

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
        Console.WriteLine("Информация о рейсах: ");
        foreach (var line in LineBoard)
        {
            Console.WriteLine($"* {line}");
        }
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
            Console.WriteLine("Введите направление:");
            string enterWay = Console.ReadLine();
            if (enterWay != "")
            {
                Way way = new Way(enterWay);
                way.BuyTiket(rand.Next(100, 1000));
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