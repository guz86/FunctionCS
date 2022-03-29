namespace Task30;

public class Aquarium
{
    private Random _random = new Random();
    
    public int Count { get; set; }
    public List<Fish> LifeFish { get; set; }

    public Aquarium(int count = 10)
    {
        Count = count;
        LifeFish = new List<Fish>();
    }

    public void AddFish()
    {
        
        Console.WriteLine("Сколько рыб добавить?");
        int.TryParse(Console.ReadLine(), out int addFish);
        if (addFish <= (Count - LifeFish.Count))
        {
            for (int i = 0; i < addFish; i++)
            {
                LifeFish.Add(new Fish(_random.Next(30)));
            }

        }
        else
        {
            Console.WriteLine($"{addFish} не влезет в аквариум, место только на {(Count - LifeFish.Count)} рыбок");
        }
    }
    
    public void GetsOldAllFish()
    {
        for (int i = 0; i < LifeFish.Count; i++)
        {
            LifeFish[i].Old--;
            
            //умирает
            if (LifeFish[i].Old < 1)
            {
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
            LifeFish.RemoveRange(0,removeFish);
        }
        else
        {
            Console.WriteLine($"{removeFish} это слишком много, в аквариуме {LifeFish.Count} рыбок");
        }
    }

    public void ShowFish()
    {
        Console.WriteLine("1/ добавить рыб, 2/ убрать рыб, /3 Выход\n");
        foreach (var fish in LifeFish)
        {
            Console.WriteLine($"рыбка, возраст {fish.Old}");
        }
    }
}