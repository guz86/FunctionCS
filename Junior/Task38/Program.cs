﻿namespace Task38
{
    class Program
    {
        static void Main()
        {
            /*
            Отчёт о вооружении 
                Существует класс солдата.В нём есть поля:
                    имя, вооружение, звание, срок службы(в месяцах).
            Написать запрос, при помощи которого получить набор данных состоящий из имени и звания.Вывести
            все полученные данные в консоль.
            (Не менее 5 записей)
            Объединение войск
            Есть 2 списка в солдатами.Всех бойцов из отряда 1, у которых фамилия начинается на букву
            Б, требуется перевести в отряд 2.
            */
            List<Soldier> soldiers = new List<Soldier>()
            {
                new Soldier("Иван", "Ружье", "Сержант", 12),
                new Soldier("Василий", "Гранатомет", "Лейтинант", 12),
                new Soldier("Борис", "Нож", "Майор", 12),
                new Soldier("Саня", "Ружье", "Полковник", 12),
                new Soldier("Виталик", "Автомат", "Сержант", 12),
            };

            List<Soldier> soldiers2 = new List<Soldier>()
            {
                new Soldier("Василий", "Нож", "Полковник", 12),
                new Soldier("Иван", "Гранатомет", "Лейтинант", 12)
            };
            
            // не вывод а новый набор
            //1
            var soldiersNameRank = soldiers.Select(soldier => (soldier.Name, soldier.Rank)).ToList();
            
            Console.WriteLine("SoldiersNameRank");
            foreach (var soldier in soldiersNameRank)
            {
                Console.WriteLine($"{soldier.Name}\t {soldier.Rank}");
            }
            //2
            var soldiersNameRank2 = soldiers.Select(soldier => new  {Info = soldier.Name +" > "+ soldier.Rank}).ToList();
            
            Console.WriteLine("soldiersNameRank2");
            foreach (var soldier in soldiersNameRank2)
            {
                Console.WriteLine($"{soldier.Info}");
            }
            //3
            var soldiersNameRank3 = soldiers.Select(soldier => new
            {
                soldier.Name,
                soldier.Rank
            }).ToList();
            Console.WriteLine("soldiersNameRank3");
            foreach (var soldier in soldiersNameRank3)
            {
                Console.WriteLine($"{soldier.Name} / {soldier.Rank}");
            }

            Console.WriteLine();
            //1
            soldiers2 = Regroupment2(soldiers, soldiers2);
            soldiers = Regroupment1(soldiers, soldiers2);
            SoldiersNameRank(soldiers);
            SoldiersNameRank(soldiers2);
            //2
            var soldiers3 = Regroupment2(soldiers, soldiers2);
            soldiers = soldiers.Except(soldiers3).ToList();
            soldiers2.AddRange(soldiers3);
        }

        private static void SoldiersNameRank(List<Soldier> soldiers)
        {
            foreach (var soldier in soldiers)
            {
                Console.WriteLine($"{soldier.Name}\t {soldier.Rank}");
            }

            Console.WriteLine();
        }

        private static List<Soldier> Regroupment2(List<Soldier> listSolders, List<Soldier> listSolders2)
        {
            List<Soldier> listStartSymbol =
                listSolders.Where(listSolder => listSolder.Name.ToUpper().StartsWith("Б")).ToList();

            listSolders2 = listSolders2.Union(listStartSymbol).ToList();

            return listSolders2;
        }

        private static List<Soldier> Regroupment1(List<Soldier> listSolders, List<Soldier> listSolders2)
        {
            List<Soldier> listStartSymbol =
                listSolders.Where(listSolder => listSolder.Name.ToUpper().StartsWith("Б")).ToList();

            listSolders = listSolders.Except(listStartSymbol).ToList();

            return listSolders;
        }
    }
}