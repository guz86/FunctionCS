namespace part2
{
    class Task5
    {
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
            
            int inputMenu;
            string name = "";
            string password = "";
            int windowSizeWidth;
            int windowSizeHeight;

            windowSizeWidth = 180;
            windowSizeHeight = 30;

            while (true)
            {
                Console.WriteLine("SetName(1)|ChangeConsoleColor(2)|SetPass(3)|WriteName(4)|WindowSize(5)|Title(6)|whatWinSize(7)|Beep(8)|RColor(9)|Exit(10)");
                inputMenu = Convert.ToInt32(Console.ReadLine());


                switch (inputMenu)
                {
                    case 1:
                        Console.Write("Введите имя: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Имя задано, нажмите любую клавишу..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Цвет фона изменен, нажмите любую клавишу..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Установите пароль: ");
                        password = Console.ReadLine();
                        Console.WriteLine("Пароль задан, нажмите любую клавишу..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("Введите пароль: ");
                        if (Console.ReadLine() == password)
                        {
                            Console.WriteLine("Добро пожаловать, " + name + " Нажмите любую клавишу");
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case 5:
                        // Console.WindowWidth = 50;
                        // Console.WindowHeight = 30;
                        Console.Write("Введите ширину окна, например 120: ");
                        windowSizeWidth = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите высоту окна, например 30: ");
                        windowSizeHeight = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        Console.WindowWidth = windowSizeWidth;
                        Console.WindowHeight = windowSizeHeight;
                        break;
                    case 6:
                        Console.Write("Задайте название для окна: ");
                        Console.Title = Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Текущие размеры окна: "+Console.WindowHeight+ " на "+ Console.WindowWidth);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Beep();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    case 10:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Не верная команда");
                        Console.Clear();
                        break;
                }
                if (inputMenu == 10)
                {
                    break;
                }

            }

            
            

        }
    }


}
