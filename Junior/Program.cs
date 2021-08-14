using System;

namespace Junior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");

            WriteError();

            Console.WriteLine("Не может быть");

            WriteError();



        }
        static void WriteError()
        {
            // запомним в переменную текущий цвет текста в консли
            ConsoleColor defaulColor = Console.ForegroundColor;
            // сообщение выводится красным
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Ошибка. Нет интернета.");

            // возвращаем текущий цвет
            Console.ForegroundColor = defaulColor;
        }
    }
}
