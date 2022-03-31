using System.Linq;

namespace Task33;

public class Finder
{
    private List<Criminal> criminals = new List<Criminal>();
    private Random _random = new Random();
    private int inputGrowth;
    private int inputWeight;
    private string inputNation;

    public void Start()
    {
        GenerateCriminal(5);
        while (true)
        {
            InputDetective();
            OutputResult();
            
            Console.ReadKey();
            Console.Clear();
        }
    }

    private void GenerateCriminal(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Criminal newCriminal = new Criminal("Иванов Иван Иванович",
                false,
                _random.Next(160,210),
                _random.Next(40,200),
                "русский");
            criminals.Add(newCriminal);
        }

        Console.WriteLine("------база-------");
        foreach (var criminal in criminals)
        {
            AboutCriminal(criminal);
        }

        Console.WriteLine("------база-------");
    }

    private void InputDetective()
    {
        Console.Write("Введите рост:\t");
        int.TryParse(Console.ReadLine(), out inputGrowth);
        Console.Write("Введите вес:\t");
        int.TryParse(Console.ReadLine(), out inputWeight);
        Console.Write("Введите национальность:\t");
        inputNation = Console.ReadLine();
        
    }
    
    private void OutputResult()
    {
        var outputCriminals = from Criminal criminal in criminals
            where criminal.Growth == inputGrowth
                  && criminal.Weight == inputWeight
                  && criminal.Nation == inputNation
                  && criminal.State == false
            select criminal;
        //outputCriminals.ToList();
        Console.WriteLine("\nРезультат поиска:\n");
        foreach (var outputCriminal in outputCriminals)
        {
            AboutCriminal(outputCriminal);
        }

    }

    public void AboutCriminal(Criminal criminal)
    {
        Console.WriteLine($"ФИО: {criminal.FIO}, " +
                          $"рост: {criminal.Growth}, " +
                          $"вес: {criminal.Weight}, " +
                          $"национальность: {criminal.Nation}\n");
    }
    
}