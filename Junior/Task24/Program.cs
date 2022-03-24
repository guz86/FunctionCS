namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            MyPlayers generatePlayers = new MyPlayers(5, players);
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
                            generatePlayers.AddPlayer(players);
                            break;
                        case 2:
                            generatePlayers.BanPlayer(players);
                            break;
                        case 3:
                            generatePlayers.NoBanPlayer(players);
                            break;
                        case 4:
                            generatePlayers.DelPlayer(players);
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
    }
}