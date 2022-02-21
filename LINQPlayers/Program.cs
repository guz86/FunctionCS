using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPlayers
{
    class Program
    {
        static void Main(string[] args)
        {
            // выборка игроков из массива у кого уровень силы больше 200

            //List<Player> players = new List<Player>();
            List<Player> players = new List<Player> { 
                new Player("Ivan", 300),
                new Player("Aleksey", 200),
                new Player("Maks", 100),
                new Player("Roman", 120),
                new Player("Pavel", 330),
                new Player("Evgeniy", 220)
            };
            // без LINQ

            // массив для добавления
            List<Player> playersFiltered = new List<Player>();

            foreach (var player in players)
            {
                if (player.Level > 200)
                {
                    Console.WriteLine(player.Login + "\t"+ player.Level);
                    playersFiltered.Add(player);
                }
            }
            Console.WriteLine("-----");
            // С помощью LINQ

            // возвращается последовательность IEnumerable
            var playersFilteredLINQ = from Player player in players
                                      where player.Level > 200
                                      select player;
            foreach (var player in playersFilteredLINQ)
            {
                Console.WriteLine(player.Login + "\t" + player.Level);
            }

            Console.WriteLine("-----");
            // только логины
            var playersFilteredLINQLogins = from Player player in players
                                      where player.Level > 200
                                      select player.Login;
            foreach (var Login in playersFilteredLINQLogins)
            {
                Console.WriteLine(Login);
            }
            Console.WriteLine();
            // методы расширения в linq

            var pFilteredLINQ = players.Where(player => player.Level > 200);

            foreach (var player in pFilteredLINQ)
            {
                Console.WriteLine(player.Login);
            }

            Console.WriteLine();
            var pFilteredLINQLogin = players.Where(player => player.Login.ToUpper().StartsWith("P"));

            foreach (var player in pFilteredLINQLogin)
            {
                Console.WriteLine(player.Login);
            }


            Console.WriteLine();
            // сортировка
            var pFilteredLINQSort = players.Where(player => player.Level > 200).OrderBy(player => player.Level);
            foreach (var player in pFilteredLINQSort)
            {
                Console.WriteLine(player.Login+"\t"+player.Level);
            }

            Console.WriteLine();
            // минимум и максимум
            int maxLevel = players.Max(player => player.Level);
            Console.WriteLine(maxLevel);

            List<int> numbers = new List<int> { 1, 22, 33, 44, 55, 654, 2, 4 };
            //int maxNumber = numbers.Max(number => number);
            int maxNumber = numbers.Max();
            Console.WriteLine(maxNumber);


            Console.WriteLine();



            // проекции
            // создаем объект анонимного типа
            var newPlayers = from Player player in players
                             select new
                             {
                                 //поля
                                 Name = player.Login,
                                 DateOfBirth = "сегодня"
                             };

            foreach (var player in newPlayers)
            {
                Console.WriteLine(player.Name+ "\t" + player.DateOfBirth);
            }

            Console.WriteLine();

            // при помощи методов расширения
            var newPlayersEx = players.Select(player => new
            {
                //поля
                Name = player.Login,
                DateOfBirth = "сегодня"
            });


            foreach (var player in newPlayersEx)
            {
                Console.WriteLine(player.Name + "\t" + player.DateOfBirth);
            }
        }
    }
}
