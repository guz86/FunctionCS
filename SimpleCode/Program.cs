using System;

namespace SimpleCode
{
    class Program
    {

        static void PrintString(char symbol, uint count)
        {

            // string result = "";
            
            for (int i = 0; i < count; i++)
            {
                //result += symbol;
                Console.Write(symbol);
            }
            // Console.WriteLine(result);
             Console.WriteLine();
        }

        static int FindIndex(int [] userArray, int element )
        {
            //int indexElement = -1;

            for (int i = 0; i < userArray.Length; i++)
            {
                
                if (element == userArray[i] )
                {
                    //indexElement = i;
                    //break;
                    return i;
                }
            }

            return -1;
        }



        static void Main(string[] args)
        {
            // ДЗ. Метод выводит на экран строку. Символы из которых состоит строка и их количество вводятся пользователем.
            Console.Write("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.Write("\nВведите количество: ");
            // не должно быть отрицательных uint
            uint count = Convert.ToUInt32(Console.ReadLine());
            PrintString(symbol, count);

            // ДЗ. Написать метод для поиска индекса элемента массива (тип элементов -int), метод должен вернуть индекс первого найденного элемента, если он будет найден.
            int[] myArray = { 1, 2, 3, 1, 4, 5, 7, 7, 8, 2, 1, 4 };
            Console.WriteLine("Индекс цифры 5 - " + FindIndex( myArray, 5));
            // должен возвращать отрицйательное число
            Console.WriteLine("Индекс цифры 99 - " + FindIndex( myArray, 99));
            Console.WriteLine("Индекс цифры 4 - " + FindIndex(myArray, 4));

        }


    }
}
