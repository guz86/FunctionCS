namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            /* База данных игроков
            Реализовать базу данных игроков и методы для работы с ней.
            У игрока может быть порядковый номер, ник, уровень, флаг – забанен ли он(флаг - bool).
            Реализовать возможность добавления игрока, бана игрока по порядковому номеру, разбана
            игрока по порядковому номеру и удаление игрока.
            Создание самой БД не требуется, задание выполняется инструментами,
            которые вы уже изучили в рамках курса.
            */

            List<Player> players = new List<Player>();
            GeneratePlayer generate = new GeneratePlayer(10, players);
            while (true)
            {
                Console.WriteLine("***** База Игроков *****");
                foreach (var player in players)
                {
                    Console.WriteLine(
                        $"{player.Number}.\tИмя: {player.Name}\tУровень: {player.Level}\tБан: {player.Flag}");
                }

                Console.WriteLine();
                Console.WriteLine(
                    "Выберите действие (1-5): 1 - добавить, 2 - забанить, 3 - разбанить, 4 - удалить, 5 - выход");
                bool checkEnter = int.TryParse(Console.ReadLine(), out int enter);
                if (checkEnter)
                {
                    switch (enter)
                    {
                        case 1:
                            AddPlayer(players);
                            break;
                        case 2:
                            BanPlayer(players);
                            break;
                        case 3:
                            NoBanPlayer(players);
                            break;
                        case 4:
                            DelPlayer(players);
                            break;

                        case 5:
                            return;
                        default:
                            Console.WriteLine("Введите команду от 1 до 5");
                            break;
                    }
                }

                Console.Clear();
            }
        }

        public static void AddPlayer(List<Player> players)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите уровень(1-10):");
            int.TryParse(Console.ReadLine(), out int level);
            Console.WriteLine("Игрок забанен (да/нет):");
            string checkFlag = Console.ReadLine();
            bool flag = false;
            if (checkFlag == "да") flag = true;
            Player player = new Player(players.Count + 1, name, level, flag);
            players.Add(player);
        }

        public static void BanPlayer(List<Player> players)
        {
            Console.WriteLine("Введите номер игрока:");
            int.TryParse(Console.ReadLine(), out int number);
            // foreach (var player in players)
            // {
            //     if (player.Number == number) player.BanPlayer(number);
            // }
            if(number < players.Count) players[number-1].BanPlayer(number-1);
            
        }

        public static void NoBanPlayer(List<Player> players)
        {
            Console.WriteLine("Введите номер игрока:");
            int.TryParse(Console.ReadLine(), out int number);
            // foreach (var player in players)
            // {
            //     if (player.Number == number) player.NoBanPlayer(number);
            // }
            if(number < players.Count) players[number-1].NoBanPlayer(number-1);
        }

        public static void DelPlayer(List<Player> players)
        {
            Console.WriteLine("Введите номер игрока:");
            int.TryParse(Console.ReadLine(), out int number);
            if (number < players.Count) players.RemoveAt(number - 1);

            foreach (var player in players)
            {
                if (player.Number > number - 1) player.CorrectNumber(number - 1);
            }
        }
    }
}