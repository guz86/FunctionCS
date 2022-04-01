﻿namespace Task35
{
    class Program
    {
        static void Main()
        {
            /*
            Анархия в больнице
                У вас есть список больных(минимум 10 записей)
            Класс больного состоит из полей: ФИО, возраст, заболевание.
                Требуется написать программу больницы, в которой перед пользователем будет меню со следующими пунктами:
                    1)Отсортировать всех больных по фио
                    2)Отсортировать всех больных по возрасту
                    3)Вывести больных с определенным заболеванием
                (название заболевания вводится пользователем с клавиатуры)
            */
            int input;
            List<Sick> sicks = new List<Sick>()
            {
                new Sick("Иванов", 22, "Ветрянка"),
                new Sick("Петров", 33, "Оспа"),
                new Sick("Сидоров", 44, "Простуда"),
                new Sick("Огнев", 42, "Онкология"),
                new Sick("Смирнов", 25, "Волчанка"),
                new Sick("Александров", 19, "Гайморит"),
            };

            while (true)
            {
                Console.WriteLine("1 Отсортировать всех больных по фио");
                Console.WriteLine("2 Отсортировать всех больных по возрасту");
                Console.WriteLine("3 Вывести больных с определенным заболеванием");
                Console.WriteLine("4 Вывести больных");
                Console.WriteLine("5 Выход");
                int.TryParse(Console.ReadLine(), out input);
                if (input != 0)
                {
                    switch (input)
                    {
                        case 1:
                            ShowSick(SortByFioSick(sicks));
                            break;
                        case 2:
                            ShowSick(SortByOldSick(sicks));
                            break;
                        case 3:
                            ShowSick(SpecificDiseaseSick(sicks));
                            break;
                        case 4:
                            ShowSick(sicks);
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("От 1 до 4");
                            break;
                    }
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static List<Sick> SortByFioSick(List<Sick> sicks)
        {
            return sicks.OrderBy(sick => sick.Fio).ToList();
        }

        private static List<Sick> SortByOldSick(List<Sick> sicks)
        {
            return sicks.OrderBy(sick => sick.Old).ToList();
        }

        private static List<Sick> SpecificDiseaseSick(List<Sick> sicks)
        {
            Console.Write("Введите заболевание:\t");
            string inputDisease = Console.ReadLine();
            if (inputDisease == null) return sicks;

            return sicks.Where(sick => sick.Disease.ToLower() == inputDisease.ToLower()).ToList();
        }

        private static void ShowSick(List<Sick> sicks)
        {
            foreach (var sick in sicks)
            {
                Console.WriteLine($" > {sick.Fio}, {sick.Old}, {sick.Disease}");
            }
        }
    }
}