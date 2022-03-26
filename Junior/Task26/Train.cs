namespace Task26;

public class Train
{
    // создаем поезд и добавляем разные по вместительности вагоны
    // в зависимости от пассажиров
    // отправить поезд и добавить информацию о рейсе
    private int сapacityWagonMin = 44;
    private int сapacityWagonMed = 54;
    private int сapacityWagonMax = 64;

    public int WagonsCount { get; private set; }

    public Train(int countPassangers)
    {
        FillTrain(countPassangers);
    }

    private void FillTrain(int countPassangers)
    {
        WagonsCount = 0;
        while (countPassangers > 0)
        {
            WagonsCount++;
            if (countPassangers >= сapacityWagonMax)
            {
                countPassangers -= сapacityWagonMax;
                Console.WriteLine($"{WagonsCount} вагон, с вместимостью на {сapacityWagonMax} человек, готов");
                FreePlaceWagon(countPassangers);
            }
            else if (countPassangers >= сapacityWagonMed)
            {
                countPassangers -= сapacityWagonMed;
                Console.WriteLine($"{WagonsCount} вагон, с вместимостью на {сapacityWagonMed} человек, готов");
                FreePlaceWagon(countPassangers);
            }
            else
            {
                countPassangers -= сapacityWagonMin;
                Console.WriteLine($"{WagonsCount} вагон, с вместимостью на {сapacityWagonMin} человек, готов");
                FreePlaceWagon(countPassangers);
            }
            Thread.Sleep(1000);
        }

        Console.WriteLine($"Поезд с {WagonsCount} вагонами готов");
    }

    private void FreePlaceWagon(int count)
    {
        if (count < 0)
        {
            Console.WriteLine("свободных мест в последнем вагоне: " + (-count));
        }
    }

    public void TrainLeaves()
    {
        Console.WriteLine("Поезд отправился");
    }
}