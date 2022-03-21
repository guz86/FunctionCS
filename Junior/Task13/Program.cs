namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Функции
                Кадровый учёт
                Будет 2 массива: 1) фио 2) должность.
                Описать функцию заполнения массивов досье, функцию форматированного вывода, функцию поиска по фамилии и функцию удаления досье.
                Функция расширяет уже имеющийся массив на 1 и дописывает туда новое значение.
                Программа должна быть с меню, которое содержит пункты:
            1) добавить досье
            2) вывести все досье (в одну строку через “-” фио и должность с порядковым номером в начале)
            3) удалить досье
            4) поиск по фамилии
            5) выход*/

            //ver1

            string[] FIO = new string[0];
            string[] job = new string[0];
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(
                    "(1) добавить досье (2) вывести все досье (3) удалить досье (4) поиск по фамилии (5) выход");
                bool checkEnter = int.TryParse(Console.ReadLine(), out int enter);
                if (!checkEnter)
                {
                    Console.WriteLine("Вы ввели, что то не то, нажмите любую клавишу");
                }

                switch (@enter)
                {
                    case 1:
                        AddFile(ref FIO, ref job);
                        break;
                    case 2:
                        ViewFile(FIO, job);
                        break;
                    case 3:
                        DeleteFile(ref FIO, ref job);
                        break;
                    case 4:
                        FindFile(FIO, job);
                        break;
                    case 5:
                        Console.WriteLine("Выходим");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Выберите от 1 до 5");
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void AddFile(ref string[] FIO, ref string[] job)
        {
            Console.Write("Введите ФИО\t");
            string namePerson = Console.ReadLine();
            string[] FIOTemp = new string[FIO.Length + 1];
            for (int i = 0; i < FIO.Length; i++)
            {
                FIOTemp[i] = FIO[i];
            }

            FIOTemp[^1] = namePerson;
            FIO = FIOTemp;

            Console.Write("Введите Должность\t");
            string jobPerson = Console.ReadLine();
            string[] jobTemp = new string[job.Length + 1];
            for (int i = 0; i < job.Length; i++)
            {
                jobTemp[i] = job[i];
            }

            jobTemp[^1] = jobPerson;
            job = jobTemp;
            Console.WriteLine($" {FIO[^1]} {job[^1]} добавлен");
        }

        static void ViewFile(string[] FIO, string[] job)
        {
            // 1. ФИО - Должность
            for (int i = 0; i < FIO.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {FIO[i]} - {job[i]}");
            }
        }

        static void DeleteFile(ref string[] FIO, ref string[] job)
        {
            ViewFile(FIO, job);
            Console.WriteLine("Введите номер какого досье вы желаете удалить?");
            bool checkEnter = int.TryParse(Console.ReadLine(), out int idDelFile);
            if (checkEnter && (idDelFile - 1) < FIO.Length)
            {
                string[] jobTemp = new string[job.Length - 1];
                for (int i = 0; i < jobTemp.Length; i++)
                {
                    if (i != (idDelFile - 1))
                    {
                        jobTemp[i] = job[i];
                    }
                }

                Console.WriteLine($"Должность {job[idDelFile - 1]} удалено");
                job = jobTemp;

                string[] FIOTemp = new string[FIO.Length - 1];
                for (int i = 0; i < FIOTemp.Length; i++)
                {
                    if (i != (idDelFile - 1))
                    {
                        FIOTemp[i] = FIO[i];
                    }
                }

                Console.WriteLine($"ФИО {FIO[idDelFile - 1]} удалено");
                FIO = FIOTemp;
            }
        }

        static void FindFile(string[] FIO, string[] job)
        {
            Console.WriteLine("Введите Фамилию");
            string lastname = Console.ReadLine();
            for (int i = 0; i < FIO.Length; i++)
            {
                if (FIO[i].Contains(lastname))
                {
                    Console.WriteLine($"Это сотрудник: {i + 1}. {FIO[i]} - {job[i]}");
                }
            }
        }
    }
}