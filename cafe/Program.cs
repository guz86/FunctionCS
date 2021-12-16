using System;

namespace cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Table tableOne = new Table(1,10);
            // tableOne.MaxPlace = 10;
            //Table tableTwo = new Table(2, 20);

            // массив столов
            Table[] tables = {new Table(1, 10) , new Table(2, 20), new Table(3, 25) };

            // вывод
            bool isOpen = true;

            while (isOpen)
            {
                //Console.WriteLine($"{tableOne.NumberTable}, {tableOne.MaxPlace}, {tableOne.FreePlace}");
                //Console.WriteLine($"{tableTwo.NumberTable}, {tableTwo.MaxPlace}, {tableTwo.FreePlace}");

                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].InfoTable();
                }


                Console.Write("Введите номер стола: ");
                int numberTableUser = Convert.ToInt32(Console.ReadLine())-1;
                Console.Write("Введите количество необходимых мест: ");
                int countTableUser = Convert.ToInt32(Console.ReadLine());


                // tables[numberTableUser].Reserved(countTableUser);
                bool isReserve = tables[numberTableUser].Reserved(countTableUser);
                if (isReserve)
                {
                    Console.WriteLine($"Забронировано за {numberTableUser+1} столом, {countTableUser} мест!");
                }
                else
                {
                    Console.WriteLine($"Нет {countTableUser} мест за {numberTableUser + 1} столом!");
                }

                Console.ReadKey();
                Console.Clear();
            }


        }
    }

    class Table
    {
        private int _rumberTable;
        private int _freePlace;
        private int _maxPlace;

        // конструктор для заполнения
        public Table(int number, int maxplace)
        {
            _rumberTable = number;
            _maxPlace = maxplace;
            //все места свободные при создании стола
            _freePlace = maxplace;
        }

        // вывод информации о столе
        public void InfoTable()
        {
            Console.WriteLine($"Номер стола: {_rumberTable}, Мест за столом: {_maxPlace}, Свободных мест: {_freePlace}");
        }

        // резервирование стола
        public bool Reserved(int countTableUser)
        {
            bool isReserved;
            // проверка есть ли свободные места за столом
            isReserved = _freePlace >= countTableUser;

            if (isReserved)
            {
                // из свободных мест забераем количество забронированных.
                _freePlace -= countTableUser;
                return isReserved;
            }
            else
            {
                return isReserved;
            }


        }

    }


}
