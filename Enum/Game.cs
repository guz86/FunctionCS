using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumJ
{
    class Game
    {
        private string _title;
        private Genre _genre;

        public Game(string title, Genre ganre)
        {
            _title = title;
            _genre = ganre;
        }

        public void Showinfo()
        {
            Console.WriteLine($"Name Game: {_title}, Genre: {_genre}");
        }

    }
}
