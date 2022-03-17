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

            string name;
            char symbol;

            Console.Write("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ:  ");
            symbol = Convert.ToChar(Console.ReadLine());


            for (int i = 0; i < name.Length + 4; i++)
            {
                Console.Write(symbol);
            }

            Console.Write("\n" + symbol + " " + name + " " + symbol + "\n");

            for (int i = 0; i < name.Length + 4; i++)
            {
                Console.Write(symbol);
            }

            Console.Write("\n");
        }
    }
}