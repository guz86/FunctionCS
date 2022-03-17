namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод имени
            // Вывести имя в прямоугольник из символа, который введет сам пользователь.
            // Вы запрашиваете имя, после запрашиваете символ, а после отрисовываете в консоль его имя в прямоугольнике из его символов.
            // Пример:
            // Alexey
            // %
            //
            // %%%%%%
            // % Alexey %
            // %%%%%%
            //
            // Примечание:
            // Длину строки можно всегда узнать через свойство Length
            // string someString = “Hello”;
            // Console.WriteLine(someString.Length); //5

            Console.Write("Введите имя:\t");
            string name = Console.ReadLine();
            bool emptyName = (name == "");
            if (emptyName) Console.WriteLine("Вы не ввели Имя");

            Console.Write("Введите символ:\t");
            bool sucсessChar = char.TryParse(Console.ReadLine(), out char symbol);

            if (!emptyName && sucсessChar)
            {
                for (int i = 0; i < name.Length + 4; i++)
                {
                    Console.Write(symbol);
                }

                //Console.Write("\n" + symbol + " " + name + " " + symbol + "\n");
                Console.Write($"\n{symbol} {name} {symbol}\n");

                for (int i = 0; i < name.Length + 4; i++)
                {
                    Console.Write(symbol);
                }
            }
        }
    }
}