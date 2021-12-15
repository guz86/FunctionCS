using System;

namespace cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Table tableOne = new Table(1,10);
            // tableOne.MaxPlace = 10;
            Table tableTwo = new Table(2, 20);


            // вывод
            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine($"{tableOne.NumberTable}, {tableOne.MaxPlace}, {tableOne.FreePlace}");
                Console.WriteLine($"{tableTwo.NumberTable}, {tableTwo.MaxPlace}, {tableTwo.FreePlace}");

                Console.ReadKey();
            }


        }
    }

    class Table
    {
        public int NumberTable;
        public int FreePlace;
        public int MaxPlace;

        // конструктор для заполнения
        public Table(int number, int maxplace)
        {
            NumberTable = number;
            MaxPlace = maxplace;
            //все места свободные при создании стола
            FreePlace = maxplace;
        }

    }


}
