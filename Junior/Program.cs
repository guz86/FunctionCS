﻿using System;

namespace Junior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");

            WriteError("Ошибка. Нет интернета.");

            Console.WriteLine("Не может быть");
            // в функцию из программы передается аргумент "Оплати интернет"
            WriteError("Оплати интернет");

            // функция с
            Sum();


        }
        // передаем параметр в функцию , что хотим получить string text
        // void пустота
        static void WriteError(string text)
        {
            // запомним в переменную текущий цвет текста в консли
            ConsoleColor defaulColor = Console.ForegroundColor;
            // сообщение выводится красным
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(text);

            // возвращаем текущий цвет
            Console.ForegroundColor = defaulColor;
        }
        // параметры х у
        static int Sum(int x, int y)
        {
            int sum;
            sum = x + y;
            return sum;   

        }
       

    }
}
