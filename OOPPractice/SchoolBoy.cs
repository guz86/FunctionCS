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
        // сколько денег мы должны заплатить за пк
        private int _moneyToPay;
        // сколько минут он хочет позаниматься, желаемые минуты
        public int DesiredMinutes { get; private set; }
        // конструктор?
        public SchoolBoy(int money, Random rand)
        {
            _money = money;
            //Random rand = new Random();
            DesiredMinutes = rand.Next(10, 30);
        }

        // как взять деньги, проверяем платежеспособность 
        // принимаем данные о Пк и по ним судим, хватит ли школьнику денег
        
        // хватает ли денег у школьника для оплаты
        public bool CheckSolvency(Computer computer)
        {
            // вычисляем сколько надо, сумма к оплате 
            _moneyToPay = computer.PriceForMinutes * DesiredMinutes;
            if (_money >= _moneyToPay)
            {
                return true;
            }
            else
            {
                // обнуляем рассчитанную сумму к оплате
                _moneyToPay = 0;
                return false;
            }
        }

        // мы в момент оплаты берем ровно столько сколько требуется для оплаты
        public int ToPay()
        {
            _money -= _moneyToPay;
            return _money;
        }
    }
}
