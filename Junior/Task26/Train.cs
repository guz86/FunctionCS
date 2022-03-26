namespace Task26;

public class Train
{
    // создаем поезд и добавляем разные по вместительности вагоны
    // в зависимости от пассажиров
    // отправить поезд и добавить информацию о рейсе
    public int WagonsCount { get; set; }

    public Train(int countPassangers)
    {
        Random random = new Random();
        int WagonsCount = 0;
        while (countPassangers > 0)
        {
            WagonsCount++;
            int capacityWagon = random.Next(10, 50);
            countPassangers -= capacityWagon;
            Console.WriteLine($"{WagonsCount} вагон, с вместимостью на {capacityWagon} человек, готов");
        }

        Console.WriteLine($"Поезд с {WagonsCount} вагонами готов");
    }

    public void TrainLeaves()
    {
        Console.WriteLine("Поезд отправился");
    }
}