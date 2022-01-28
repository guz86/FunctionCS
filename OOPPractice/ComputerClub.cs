using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class ComputerClub
    {

        // список компьютеров
        private List<Computer> _computers = new List<Computer>();
        // очередь из школьников
        private Queue<SchoolBoy> _schoolBoys = new Queue<SchoolBoy>();

        // у клуба должны быть деньги на счету
        private int _money = 0;

        // заполнить компьютерный клуб компьютерами, конструктор?
        public ComputerClub(int computerCount)
        {
            Random rand = new Random();
            // по количеству пк computerCount генерируем компьютеры в клубе
            for (int i = 0; i < computerCount; i++)
            {
                _computers.Add(new Computer(rand.Next(5,15)));
            }
            // добавляем очередь школьников
            CreateNewSchoolboy(30);
        }

        // клуб будет работать пока есть очередь из школьников
        // добавим метод для создания очереди школьников
        private void CreateNewSchoolboy(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                _schoolBoys.Enqueue(new SchoolBoy(rand.Next(100,250), rand));
            }
        }

        // вывод информации о всех пк
        // через for у пк есть порядковый номер, нужен счетчик вывода
        public void ShowAllComputers()
        {
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write(i+" ");
                _computers[i].ShowInfo();

            }
        }

        // Отнимаем у каждого Пк по минуте
        public void SkipMunute()
        {
            foreach (var computer in _computers)
            {
                computer.SkipMinutes();
            }
        }

        // основной цикл программы
        // работаем пока есть очередь из школьников
        public void Work()
        {
            while (_schoolBoys.Count > 0)
            {
                // что делаем?
                Console.WriteLine($"На балансе клуба {_money} рублей");
                // берем из очереди школьника
                SchoolBoy schoolBoy = _schoolBoys.Dequeue();
                Console.WriteLine($"Школьник хочет купить {schoolBoy.DesiredMinutes} минут");
                Console.WriteLine("-----------------------");
                // список пк
                ShowAllComputers();
                Console.WriteLine();
                Console.Write($"Вы предлегаете ему по под номером: ");
                int computerNumber = Convert.ToInt32(Console.ReadLine());
                if (computerNumber>=0 && computerNumber < _computers.Count)
                {
                    if (_computers[computerNumber].isBusy)
                    {
                        Console.WriteLine("Этот пк занят, школьник ушел");
                    }
                    else
                    {
                        if (schoolBoy.CheckSolvency(_computers[computerNumber]))
                        {
                            Console.WriteLine("Школьник сел за пк");
                            // берем оплату
                            _money += schoolBoy.ToPay();
                            // школьник садится
                            _computers[computerNumber].TakeThePlace(schoolBoy);
                        }
                        else
                        {
                            Console.WriteLine("У школьника не хватает денег, он ушел");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Пк под этим номером нет");
                }

                Console.WriteLine("Для перехода к следующему посетителю нажмите любую клавишу. ");
                Console.ReadKey();
                Console.Clear();
                SkipMunute();
            }

        }



    }
}
