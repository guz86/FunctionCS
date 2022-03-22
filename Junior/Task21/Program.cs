namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Кадровый учёт продвинутый
            //     В функциях вы выполняли задание "Кадровый учёт"
            // Используя одну из изученных коллекций, вы смогли бы сильно
            //     себе упростить код выполненной программы, ведь у нас данные, это ФИО и позиция.
            //     Поиск в данном задании не нужен.
            // 1) добавить досье
            // 2) вывести все досье (в одну строку через “-” фио и должность)
            // 3) удалить досье
            // 4) выход

            //ver1
            Dictionary<string, string> Person = new Dictionary<string, string>();
            //string[] FIO = new string[0];
            //string[] job = new string[0];
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("(1) добавить досье (2) вывести все досье (3) удалить досье (4) выход");
                bool checkEnter = int.TryParse(Console.ReadLine(), out int enter);
                if (!checkEnter)
                {
                    Console.WriteLine("Вы ввели, что то не то, нажмите любую клавишу");
                }

                switch (@enter)
                {
                    case 1:
                        AddFile(Person);
                        break;
                    case 2:
                        ViewFile(Person);
                        break;
                    case 3:
                        DeleteFile(Person);
                        break;
                    case 4:
                        Console.WriteLine("Выходим");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Выберите от 1 до 4");
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void AddFile(Dictionary<string, string> Person)
        {
            Console.Write("Введите ФИО\t");
            string FIO = Console.ReadLine();
            Console.Write("Введите Должность\t");
            string job = Console.ReadLine();
            if (FIO != "" && job != "")
            {
                Person.Add(FIO, job);
                Console.WriteLine($" {FIO} {job} добавлен");
            }
        }

        static void ViewFile(Dictionary<string, string> Person)
        {
            // 1. ФИО - Должность
            int i = 0;
            foreach (var onePerson in Person)
            {
                i++;
                Console.WriteLine($"{i}. {onePerson.Key} - {onePerson.Value}");
            }
        }

        static void DeleteFile(Dictionary<string, string> Person)
        {
            ViewFile(Person);
            Console.WriteLine("Введите номер какого досье вы желаете удалить?");
            bool checkEnter = int.TryParse(Console.ReadLine(), out int idDelFile);
            int i = 0;
            foreach (var onePerson in Person)
            {
                i++;
                if (i == idDelFile)
                {
                    Person.Remove(onePerson.Key);
                    Console.WriteLine($"{i}. {onePerson.Key}  {onePerson.Value} - удален");
                }
            }
        }
    }
}