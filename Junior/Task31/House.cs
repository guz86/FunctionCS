namespace Task31;

public class House
{

    public string Name { get;  }
    private int CountAnimal { get;  }
    public List<Animal> Animals { get;  }

    
    public House(string name, int countAnimal, List<Animal> animals)
    {
        Name = name;
        CountAnimal = countAnimal;
        Animals = animals;
    }
    
    public void ShowInfo()
    {
        Console.Write($"Это вольер: {Name}, количество {Animals.Count}\n");
        foreach (var animal in Animals)
        {
            Console.WriteLine($"Пол: {animal.Sex} + издает звук: {animal.Sound}");
        }
        
    }
}