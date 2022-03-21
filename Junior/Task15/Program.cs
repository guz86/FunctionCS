namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            // UIELEMENT
            // Разработайте функцию, которая рисует некий бар (Healthbar, Manabar) в определённой позиции. Она также принимает некий закрашенный процент.
            //     При 40% бар выглядит так:
            // [####______]
            //Draw(40, ConsoleColor.Green);
            Draw2(30, ConsoleColor.Red);
        }

        //ver1
        static void Draw(int position, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.Write("[");
            Console.BackgroundColor = color;
            for (int i = 0; i < position / 10; i++)
            {
                Console.Write("#");
            }

            Console.BackgroundColor = defaultColor;
            for (int i = position / 10; i < (100 / 10); i++)
            {
                Console.Write("_");
            }

            Console.Write("]");
        }

        //ver2
        static void Draw2(int position, ConsoleColor color)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            Console.Write("[");
            string bar = "";
            Console.BackgroundColor = color;
            for (int i = 0; i < position / 10; i++)
            {
                bar += "#";
            }

            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";
            for (int i = position / 10; i < (100 / 10); i++)
            {
                bar += "_";
            }

            Console.Write(bar + "]");
        }
    }
}