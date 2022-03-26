﻿namespace Task26
{
    class Program
    {
        static void Main()
        {
            /*
            Конфигуратор пассажирский поездов
            У вас есть программа, которая помогает пользователю составить план поезда.
            Есть 4 основных шага в создании плана:
            - Создать направление - создает направление для поезда(к примеру Бийск - Барнаул)
            - Продать билеты - вы получаете рандомное кол - во пассажиров, которые купили билеты на это направление
            - Сформировать поезд - вы создаете поезд и добавляете ему столько вагонов(
            вагоны могут быть разные по вместительности), сколько хватит для перевозки всех пассажиров.
            - Отправить поезд - вы отправляете поезд, после чего можете снова создать направление.
            В верхней части программы должна выводиться полная информация о текущем рейсе или его отсутствии.
            */

            Random rand = new Random();
            Station station = new Station();

            while (true)
            {
                if (station.LineBoard.Count > 0)
                {
                    station.InfoLineBoard();
                }
                Console.WriteLine("Введите направление:");
                string enterWay = Console.ReadLine();
                if (enterWay != "")
                {
                    Way way = new Way(enterWay);
                    way.BuyTiket(rand.Next(100, 1000));
                    Console.WriteLine($"{way.WayPassengers} - пассажиров готовы к отправлению");
                    Train train = new Train(way.WayPassengers);
                    train.TrainLeaves();
                    station.AddLineBoard(way);
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}