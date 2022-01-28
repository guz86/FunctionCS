using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Computer
    {
        // за ПК может сесть школьник (кто то) (место, слот)
        private SchoolBoy _schoolboy;
        // количество минут за компьютером, сколько их осталось
        private int _minutesLeft;
        // у каждого пк есть своя цена за минуту времени
        public int PriceForMinutes { get; private set; }
        // компьютер занят в данный момент или свободен?
        public bool isBusy
        {
            get
            {
                return _minutesLeft > 0;
            }
        }
        // каждый школьник занимает пк на определенное количество
        // минут

        // конструктор?
        public Computer(int priceForMinutes)
        {
            PriceForMinutes = priceForMinutes;
        }
        
        //действия
        // за компьютер можно сесть.
        public void TakeThePlace(SchoolBoy schoolBoy)
        {
            _schoolboy = schoolBoy;
            _minutesLeft = _schoolboy.DesiredMinutes;

        }
        // компьютер можно освободить.
        public void FreeThePlace()
        {
            _schoolboy = null;
        }

        // отчет времени за пк по минутам..

        public void SkipMinutes()
        {
            _minutesLeft--;
        }

        // отображение информации о пк, занят,
        public void ShowInfo()
        {
            if (isBusy)
            {
                Console.WriteLine($"Пк занят, осталось {_minutesLeft}");
            }
            else
            {
                Console.WriteLine($"Пк свободен, цена за минуту {PriceForMinutes }");
            }
        }
        // свободен сколько времени осталось

    }
}
