namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            // READINT
            // Написать функцию, которая запрашивает число у пользователя
            // (с помощью метода Console.ReadLine() ) и пытается сконвертировать
            // его в тип int (с помощью int.TryParse())
            // Если конвертация не удалась у пользователя запрашивается
            // число повторно до тех пор, пока не будет введено верно.
            // После ввода, который удалось преобразовать в число, число возвращается.
            //     P.S Задача решается с помощью циклов
            // P.S Также в TryParse используется модификатор параметра out

            EnterDigit();
        }

        //ver1
        static void EnterDigit()
        {
            bool parse = false;
            while (!parse)
            {
                Console.Write("Введите число\t");
                parse = int.TryParse(Console.ReadLine(), out int enter);
                if (parse)
                {
                    Console.WriteLine(enter);
                }
            }
        }
    }
}