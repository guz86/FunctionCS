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
             int count = Convert.ToInt32(Console.ReadLine());
            string result = "";
            
            for (int i = 1; i < count; i++)
            {
                result += symbol;
            }
            Console.WriteLine(result);
        }




        static void Main(string[] args)
        {
            // ДЗ. Метод выводит на экран строку. Символы из которых состоит строка и их количество вводятся пользователем.
            PrintString();
        }


    }
}
