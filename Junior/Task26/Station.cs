namespace Task26;

public class Station
{
    public List<string> LineBoard { get; private set; }

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
}