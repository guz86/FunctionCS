namespace Task31;

public class House
{

    public string Name { get;  }
    public List<Animal> Animals { get;  }

    
    public House(string name, List<Animal> animals)
    {
        Name = name;
        Animals = animals;
    }
    
    public void ShowInfo()
    {
        Console.Write($"Это {Name}, количество {Animals.Count}\n");
        foreach (var animal in Animals)
        {
            Console.WriteLine($"Пол: {animal.Sex} + издает звук: {animal.Sound}");
        }
        
    }
}