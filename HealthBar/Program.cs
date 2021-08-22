using System;

namespace HealthBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 5, maxHealth = 10;
            DrawBar(health, maxHealth, ConsoleColor.DarkGreen);
        }
        static void DrawBar(int value, int maxValue, ConsoleColor color)
        {
            // запомним обычный цвет консоли
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += ' ';
            }

            // позиция, цвет и вывод бара
            Console.SetCursorPosition(0, 0);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            // возвращаем цвет
            Console.BackgroundColor = defaultColor;

            // отрисовываем незаполненную часть
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + ']');

        }
    }
}
