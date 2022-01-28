using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class SchoolBoy
    {
        // деньги
        private int _money;
        // сколько минут он хочет позаниматься, желаемые минуты
        public int DesiredMinutes { get; private set; }
        // конструктор?
        public SchoolBoy(int money)
        {
            _money = money;
            Random rand = new Random();
            DesiredMinutes = rand.Next(10, 30);
        }
    }
}
