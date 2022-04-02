namespace Task37
{
    class Program
    {
        static void Main()
        {
            /*
            Определение просрочки
            Есть набор тушенки.У тушенки есть название, год производства и срок годности.Написать запрос для
            получения всех просроченных банок тушенки.Чтобы не заморачиваться, можете думать, что считаем только
            года, без месяцев.
            */
            List<Can> cans = new List<Can>()
            {
                new Can("Банка Тушенки", new DateTime(2009, 1, 1), 4),
                new Can("Банка Тушенки", new DateTime(2019, 1, 1), 5),
                new Can("Банка Тушенки", new DateTime(2021, 1, 1), 2),
                new Can("Банка Тушенки", new DateTime(2001, 1, 1), 3),
                new Can("Банка Тушенки", new DateTime(2020, 1, 1), 1)
            };


            Console.WriteLine("Просроченная тушенка:");
            foreach (var can in ExpirationCan(cans))
            {
                Console.WriteLine($"{can.Name}\t{can.YearProduction},{can.ExpirationDate}");
            }
        }

        static public List<Can> ExpirationCan(List<Can> cans)
        {
            DateTime currentTime = DateTime.Now;
            return cans.Where(can => (can.YearProduction.Year + can.ExpirationDate) < currentTime.Year).ToList();
        }
    }
}