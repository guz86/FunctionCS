using System;

namespace SimpleCode
{
    class Program
    {

        static void PrintString()
        {
            Console.Write("Введите символ: ");
            string symbol = Console.ReadLine(); 
            Console.Write("Введите количество: ");
            // не должно быть отрицательных uint
            uint count = Convert.ToUInt32(Console.ReadLine());
            string result = "";
            
            for (int i = 0; i < count; i++)
            {
                result += symbol;
            }
            Console.WriteLine(result);
        }

        static int FindIndex(int element, int [] userArray)
        {
            int indexElement = 0;

            for (int i = 0; i < userArray.Length; i++)
            {
                
                if (element == userArray[i] )
                {
                    indexElement = i;
                    break;
                }
            }

            return indexElement;
        }



        static void Main(string[] args)
        {
            // ДЗ. Метод выводит на экран строку. Символы из которых состоит строка и их количество вводятся пользователем.
            PrintString();

            // ДЗ. Написать метод для поиска индекса элемента массива (тип элементов -int), метод должен вернуть индекс первого найденного элемента, если он будет найден.
            int[] myArray = { 1, 2, 3, 1, 4, 5, 7, 7, 8, 2, 1, 4 };
            Console.WriteLine("Индекс цифры 5 - " + FindIndex(5, myArray));
            Console.WriteLine("Индекс цифры 1 - " + FindIndex(1, myArray));
            Console.WriteLine("Индекс цифры 4 - " + FindIndex(4, myArray));

        }


    }
}
