namespace Task35
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
            int input = 0;
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
                Console.WriteLine("1)Отсортировать всех больных по фио " + "2)Отсортировать всех больных по возрасту" +
                                  "3)Вывести больных с определенным заболеванием" +
                                  "4) Вывести больных");
                int.TryParse(Console.ReadLine(), out input);
                if (input != 0)
                {
                    switch (input)
                    {
                        case 1:
                            SortByFioSick(sicks);
                            break;
                        case 2:
                            SortByOldSick(sicks);
                            break;
                        case 3:
                            ShowSpecificDiseaseSick(sicks);
                            break;
                        case 4:
                            ShowSick(sicks);
                            break;
                        default:
                            break;
                    }
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void SortByFioSick(List<Sick> sicks)
        {
            sicks = sicks.OrderBy(sick => sick.Fio).ToList();
            ShowSick(sicks);
        }

        private static void SortByOldSick(List<Sick> sicks)
        {
            sicks = sicks.OrderBy(sick => sick.Old).ToList();
            ShowSick(sicks);
        }

        private static void ShowSpecificDiseaseSick(List<Sick> sicks)
        {
            string inputDisease = Console.ReadLine();
            var specificDisease = sicks.Where(sick => sick.Disease == inputDisease).ToList();
            ShowSick(specificDisease);
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