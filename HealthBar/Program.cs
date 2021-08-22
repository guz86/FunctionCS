using System;

namespace HealthBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 5, maxHealth = 10;
            int mana = 3, maxMana = 10;

            while (true)
            {

                DrawBar(health, maxHealth, ConsoleColor.DarkRed, 0);
                DrawBar(mana, maxMana, ConsoleColor.DarkBlue, 1);

                Console.Write("\nИзменим жизни на ");
                health += Convert.ToInt32(Console.ReadLine());
                Console.Write("Изменим ману на ");
                mana += Convert.ToInt32(Console.ReadLine());
                

                Console.ReadKey();

                Console.Clear();
            }


        }
        static void DrawBar(int value, int maxValue, ConsoleColor color, int position)
        {
            // запомним обычный цвет консоли
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += ' ';
            }

            // позиция, цвет и вывод бара
            Console.SetCursorPosition(0, position);
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
