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



        }
    }
}
