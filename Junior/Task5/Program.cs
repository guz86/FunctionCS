namespace part2
{
    class Task5
    {
        public static void KeyClear()
        {
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            // Консольное меню
            // При помощи всего, что вы изучили, создать приложение, которое может обрабатывать команды.
            // Т.е.вы создаете меню, ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
            // Примеры команд(требуется 4 - 6 команд, придумать самим):
            // SetName – установить имя;
            // ChangeConsoleColor - изменить цвет консоли;
            // SetPassword – установить пароль;
            // WriteName – вывести имя(после ввода пароля);
            // Esc – выход из программы.
            // Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды.

            // console_ver1

            //int inputMenu;
            string name = "";
            string password = "";

            // windowSizeWidth = 180;
            // windowSizeHeight = 30;

            while (true)
            {
                Console.WriteLine(
                    "SetName(1)|ChangeConsoleColor(2)|SetPass(3)|WriteName(4)|WindowSize(5)|Title(6)|whatWinSize(7)|Beep(8)|RColor(9)|Exit(10)");
                //inputMenu = Convert.ToInt32(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out int inputMenu);

                switch (inputMenu)
                {
                    case 1:
                        Console.Write("Введите имя: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Имя задано, нажмите любую клавишу..");
                        KeyClear();
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Цвет фона изменен, нажмите любую клавишу..");
                        KeyClear();
                        break;
                    case 3:
                        Console.Write("Установите пароль: ");
                        password = Console.ReadLine();
                        Console.WriteLine("Пароль задан, нажмите любую клавишу..");
                        KeyClear();
                        break;
                    case 4:
                        Console.Write("Введите пароль: ");
                        if (Console.ReadLine() == password)
                        {
                            Console.WriteLine("Добро пожаловать, " + name + " Нажмите любую клавишу");
                        }

                        KeyClear();
                        break;
                    case 5:
                        Console.Write("Введите ширину окна, например 120: ");
                        //windowSizeWidth = Convert.ToInt32(Console.ReadLine());
                        bool SizeWidthExist = int.TryParse(Console.ReadLine(), out int windowSizeWidth);
                        Console.Write("Введите высоту окна, например 30: ");
                        bool SizeHeightExist = int.TryParse(Console.ReadLine(), out int windowSizeHeight);

                        if (SizeWidthExist && SizeHeightExist)
                        {
                            Console.WindowWidth = windowSizeWidth;
                            Console.WindowHeight = windowSizeHeight;
                        }
                        KeyClear();
                        break;
                    case 6:
                        Console.Write("Задайте название для окна: ");
                        Console.Title = Console.ReadLine();
                        KeyClear();
                        break;
                    case 7:
                        Console.WriteLine(
                            "Текущие размеры окна: " + Console.WindowHeight + " на " + Console.WindowWidth);
                        KeyClear();
                        break;
                    case 8:
                        Console.Beep();
                        KeyClear();
                        break;
                    case 9:
                        Console.ResetColor();
                        KeyClear();
                        break;
                    case 10:
                        KeyClear();
                        break;
                    default:
                        Console.WriteLine("Не верная команда");
                        KeyClear();
                        break;
                }

                if (inputMenu == 10)
                {
                    break;
                }
            }
            
            // Последовательность
            // Нужно написать программу(используя циклы, обязательно пояснить выбор вашего цикла),
            // чтобы она выводила следующую последовательность 7 14 21 28 35 42 49 56 63 70 77 84 91 98

            // есть четкие границы цикл for
            /*
            int sequence = 0;
            for (int i = 0; i < 14; i++)
            {
                sequence += 7;
                // Console.WriteLine(sequence);
                Console.Write(sequence + " ");
            }
            */
        }
    }
}