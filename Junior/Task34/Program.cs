namespace Task34
{
    class Program
    {
        static void Main()
        {
            /*
            Амнистия
                В нашей великой стране Арстоцка произошла амнистия! Всех людей, заключенных
                за преступление "Антиправительственное", следует исключить из списка заключенных.Есть список
                заключенных, каждый заключенный состоит из полей:
            ФИО, преступление.Вывести список до амнистии и после.
            */

            // список заключенных
            List<Prisoner> prisoners = new List<Prisoner>
            {
                new Prisoner("Иванов", "Антиправительственное"),
                new Prisoner("Петров", "Уголовное"),
                new Prisoner("Сидоров", "Антиправительственное"),
                new Prisoner("Жернов", "Административное"),
                new Prisoner("Котов", "Антиправительственное"),
                new Prisoner("Понкратов-Черный", "Терроризм"),
            };

            OutputPrisoners(prisoners);
            OutputPrisoners(Amnesty(prisoners));
        }

        private static void OutputPrisoners(List<Prisoner> prisoners)
        {
            foreach (var prisoner in prisoners)
            {
                Console.WriteLine($"{prisoner.Fio} - {prisoner.Сrime}");
            }

            Console.WriteLine();
        }

        private static List<Prisoner> Amnesty(List<Prisoner> prisoners)
        {
            var amnestyPrisoners = prisoners.Where(prisoner => prisoner.Сrime != "Антиправительственное").ToList();
            return amnestyPrisoners;
        }
    }
}