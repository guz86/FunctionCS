using System;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // компьютерный клуб, туда приходят школьники и менеджер рассаживает их
            // каждый сидит определенное количество минут. // баланс и учет времени за пк
            // компьютерный клуб, компьютер, школьник - 3 класса которые будут взаимодействовать

            ComputerClub computerClub = new ComputerClub(10);
            // открываем
            computerClub.Work();



        }
    }
}
