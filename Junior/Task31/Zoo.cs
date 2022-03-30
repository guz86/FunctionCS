namespace Task31;

public class Zoo
{
    private Random _random;
    public List<House> Houses { get; }

    public Zoo()
    {
        _random = new Random();
        Houses = new List<House>();
        AddHouses();
    }

    private void AddHouses()
    {
        Houses.Add(new House("Вольер для сурикатов", ListAnimal(10, "Сурикаты")));

        Houses.Add(new House("Вольер для лошадей", ListAnimal(5, "Лошади")));

        Houses.Add(new House("Вольер для кабанов", ListAnimal(7, "Кабаны")));

        Houses.Add(new House("Вольер для медведей", ListAnimal(1, "Медведи")));
    }

    private List<Animal> ListAnimal(int count, string name)
    {
        List<Animal> animals = new List<Animal>();
        for (int i = 0; i < count; i++)
        {
            animals.Add(AddAnimal(name));
        }

        return animals;
    }

    private Animal AddAnimal(string name)
    {
        // пол
        string sex = "Ж";
        int chooseSex = _random.Next(0, 2);
        if (chooseSex == 0) sex = "М";
        Animal animal;
        switch (name)
        {
            case "Сурикаты":
                animal = new Animal(sex, "Урр...");
                break;
            case "Лошади":
                animal = new Animal(sex, "Игого...");
                break;
            case "Кабаны":
                animal = new Animal(sex, "Хрю хрю...");
                break;
            case "Медведи":
                animal = new Animal(sex, "Рррааарр..");
                break;
            default:
                animal = new Animal(sex, ".....");
                break;
        }

        return animal;
    }

    public void ShowZoo()
    {
        while (true)
        {
            Console.WriteLine("Зоопарк. Выберите вольер(1-4) (5 выход):");

            int.TryParse(Console.ReadLine(), out int chooseHouse);
            if (chooseHouse > 0 && chooseHouse < 5)
            {
                Houses[chooseHouse - 1].ShowInfo();
            }

            if (chooseHouse == 5) return;

            Console.ReadKey();
            Console.Clear();
        }
    }
}