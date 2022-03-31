namespace Task32;

public class Storage
{
    private Random _random = new Random();
    List<Part> Parts { get; set; }

    public Storage(int countPart)
    {
        Parts = new List<Part>();
        AddStoragePart(Parts, countPart);
    }

    private void AddStoragePart(List<Part> parts, int countPart)
    {
        for (int i = 0; i < countPart; i++)
        {
            parts.Add(CreatePart());
        }
    }

    // 10 Part, по 500
    private Part CreatePart()
    {
        Part part = new Part(_random.Next(100000, 999999), _random.Next(500, 10000), _random.Next(5, 10),
            _random.Next(500, 10000));
        return part;
    }

    public void ShowInfoPart()
    {
        Console.WriteLine("Состояние склада");
        for (int i = 0; i < Parts.Count; i++)
        {
            Console.WriteLine($"ID: {Parts[i].Id}, " + $"Cost :{Parts[i].Cost}, " + $" Count: {Parts[i].Count}, " +
                              $"WorkPrice: {Parts[i].WorkPrice}");
        }
    }

    public int[] IdPart()
    {
        int[] idPart = new int[Parts.Count];
        for (int i = 0; i < idPart.Length; i++)
        {
            idPart[i] = Parts[i].Id;
        }

        return idPart;
    }

    public void RepairPart(int partId)
    {
        for (int i = 0; i < Parts.Count; i++)
        {
            if (Parts[i].Id == partId)
            {
                Parts[i].Count--;
            }

            // убираем со склада деталь с данным id
            if (Parts[i].Count == 0)
            {
                Parts.RemoveAt(i);
            }
        }
    }

    public int CostPart(int idPart)
    {
        for (int i = 0; i < Parts.Count; )
        {
            Parts[i].Id = idPart;
            i++;
            return Parts[i].Cost;
            
        }

        return 0;
    }

    public int WorkPricePart(int idPart)
    {
        for (int i = 0; i < Parts.Count; )
        {
            Parts[i].Id = idPart;
            i++;
            return Parts[i].WorkPrice;
        }

        return 0;
    }
}