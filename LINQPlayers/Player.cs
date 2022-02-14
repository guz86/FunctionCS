using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPlayers
{
    class Player
    {
        public string Login { get; private set; }

        public int Level { get; private set; }
        public Player(string login, int level)
        {
            Login = login;
            Level = level;
        }
    }
}
