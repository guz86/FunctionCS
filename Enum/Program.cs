using System;
using System.Collections.Generic;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //электронный учет игр
            List<Game> gameCollection = new List<Game>();

            // вручную
            //gameCollection.Add(new Game("Black", "Strategy"));
            //gameCollection.Add(new Game("Witcher", "RPG"));
            //gameCollection.Add(new Game("Civilization", "Strategy"));
            //gameCollection.Add(new Game("Wisp's", "Action"));


            // чтобы каждый раз не писать повторяющиеся жанры

            gameCollection.Add(new Game("Black", Genre.Strategy));
            gameCollection.Add(new Game("Witcher", Genre.RPG));
            gameCollection.Add(new Game("Civilization", Genre.Strategy));
            gameCollection.Add(new Game("Wisp's", Genre.Action));

          

        }
    }
}
