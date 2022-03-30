namespace Task30;

public class Aquarium
{
    private Random _random;

    public int PlaceCount { get; }
    public List<Fish> LifeFish { get; }

    public Aquarium(int placeCount = 10)
    {
        PlaceCount = placeCount;
        LifeFish = new List<Fish>();
        _random = new Random();
    }

    public void Work()
    {
        while (true)
        {
            ShowFish();
            int.TryParse(Console.ReadLine(), out int enter);

            switch (enter)
            {
                case 1:
                    AddFish();
                    break;
                case 2:
                    RemoveFish();
                    break;
                case 3:
                    return;
                default:
                    break;
            }

            GetsOldAllFish();
            PrintColorText("Прошел еще один день.", ConsoleColor.DarkGreen);

            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
        }
    }

    public void AddFish()
    {
        Console.WriteLine("Сколько рыб добавить?");
        int.TryParse(Console.ReadLine(), out int addFish);
        if (addFish <= (PlaceCount - LifeFish.Count))
        {
            for (int i = 0; i < addFish; i++)
            {
                LifeFish.Add(new Fish(_random.Next(5, 30)));
            }

            PrintColorText($"{addFish} добавили в аквариум", ConsoleColor.Green);
        }
        else
        {
            PrintColorText($"{addFish} не влезет в аквариум, место только на {(PlaceCount - LifeFish.Count)} рыбок",
                ConsoleColor.Red);
        }
    }

    public void GetsOldAllFish()
    {
        for (int i = 0; i < LifeFish.Count; i++)
        {
            LifeFish[i].GetsOld();

            //умирает
            if (LifeFish[i].Old < 1)
            {
                PrintColorText($"рыбка плавает вверх брюхом, убираем ее", ConsoleColor.Red);
                LifeFish.RemoveAt(i);
            }
        }
    }

    public void RemoveFish()
    {
        Console.WriteLine("Сколько рыб убрать?");
        int.TryParse(Console.ReadLine(), out int removeFish);
        if (removeFish <= LifeFish.Count)
        {
            LifeFish.RemoveRange(0, removeFish);
        }
        else
        {
            PrintColorText($"{removeFish} это слишком много, в аквариуме {LifeFish.Count} рыбок", ConsoleColor.Red);
        }
    }

    public void ShowFish()
    {
        PrintColorText("1/ добавить рыб, 2/ убрать рыб, /3 Выход\n", ConsoleColor.Blue);

        if (LifeFish.Count > 0)
        {
            Console.WriteLine("----В аквариуме----");
            foreach (var fish in LifeFish)
            {
                Console.WriteLine($"рыбка, возраст {fish.Old}");
            }
        }
    }

    private void PrintColorText(string input, ConsoleColor color)
    {
        ConsoleColor defaultColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(input);
        Console.ForegroundColor = defaultColor;
    }
}