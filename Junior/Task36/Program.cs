namespace Task36
{
    class Program
    {
        static void Main()
        {
            /*
            Топ игроков сервера
                У нас есть список всех игроков(минимум 10).
                У каждого игрока есть поля:
                имя, уровень, сила.Требуется написать запрос для определения топ 3 игроков по уровню и топ 3 игроков по
                силе, после чего вывести каждый топ.
                2 запроса получится.
            */
            List<Gamer> gamers = new List<Gamer>()
            {
                new Gamer("IvanDrago", 18, 100),
                new Gamer("Senya", 22, 160),
                new Gamer("Sasha", 10, 80),
                new Gamer("Krendel", 78, 100),
                new Gamer("Alex", 55, 200),
                new Gamer("Ogo98", 62, 101)
            };

            ColorTitleString("Top Gamers from Server:", ConsoleColor.DarkYellow);
            ShowTop(Top3Level(gamers), "Топ3 по уровню");
            ShowTop(Top3Power(gamers), "Топ3 по силе");
            
        }

        public static List<Gamer> Top3Level(List<Gamer> gamers)
        {
            return gamers.OrderByDescending(gamer => gamer.Level).Take(3).ToList();
        }

        public static List<Gamer> Top3Power(List<Gamer> gamers)
        {
            return gamers.OrderByDescending(gamer => gamer.Power).Take(3).ToList();
            
        }
        
        public static void ShowTop(List<Gamer> gamers, string header)
        {
            ColorTitleString(header, ConsoleColor.Green);

            foreach (var gamer in gamers)
            {
                gamer.PrintGamer();
            }
        }
        
        public static void ColorTitleString(string title, ConsoleColor color )
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(title);
            Console.ForegroundColor = def;
        }
    }
}