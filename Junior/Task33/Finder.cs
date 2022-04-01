namespace Task33;

public class Finder
{
    private List<Criminal> _criminals = new List<Criminal>();
    private Random _random = new Random();
    private int _inputGrowth;
    private int _inputWeight;
    private string _inputNation = "";

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
            Criminal newCriminal = new Criminal("Иванов Иван Иванович", false, _random.Next(160, 210),
                _random.Next(40, 200), "русский");
            _criminals.Add(newCriminal);
        }

        Console.WriteLine("------база-------");
        foreach (var criminal in _criminals)
        {
            AboutCriminal(criminal);
        }

        Console.WriteLine("------база-------");
    }

    private void InputDetective()
    {
        Console.Write("Введите рост:\t");
        //int.TryParse(Console.ReadLine(), out _inputGrowth);
        _inputGrowth = CheckValue();
        Console.Write("Введите вес:\t");
        _inputWeight = CheckValue();
        //int.TryParse(Console.ReadLine(), out _inputWeight);
        Console.Write("Введите национальность:\t");
        _inputNation = Console.ReadLine();
    }

    private void OutputResult()
    {
        /*
        var resultSearch = _criminals.Where(
            criminal => criminal.Growth == _inputGrowth
                        && criminal.Weight == _inputWeight
                        && criminal.Nation == _inputNation
                        && criminal.State == false);
        
        var foundCriminals = _criminals
            .Where(criminal => criminal.Nation.ToLower() == _inputNation.ToLower())
            .Where(criminal => criminal.Growth == _inputGrowth)
            .Where(criminal => criminal.Weight == _inputWeight)
            .Where(criminal => criminal.State == false)
            .ToList();
        */
        var outputCriminals = from Criminal criminal in _criminals
            where criminal.Growth == _inputGrowth 
                  && criminal.Weight == _inputWeight 
                  && criminal.Nation.ToLower() == _inputNation.ToLower().Trim() 
                  && criminal.State == false
            select criminal;
        var criminalsList = outputCriminals.ToList();
        if (criminalsList.Count > 0)
        {
            Console.WriteLine("\nРезультат поиска:\n");
            foreach (var outputCriminal in criminalsList)
            {
                AboutCriminal(outputCriminal);
            }
        }
        else
        {
            Console.WriteLine("\nНичего не найдено:\n");
        }
    }

    private void AboutCriminal(Criminal criminal)
    {
        Console.WriteLine($"ФИО: {criminal.Fio}, " + $"рост: {criminal.Growth}, " + $"вес: {criminal.Weight}, " +
                          $"национальность: {criminal.Nation}\n");
    }
    
    // проверка на корректность ввода данных
    private int CheckValue()
    {
        int result = 0;
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Введите верные данные");
        }

        return result;
    }
 
}