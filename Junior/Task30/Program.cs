using System.Threading.Channels;

namespace Task30
{
    class Program
    {
        static void Main()
        {
            /*
             Аквариум
             Есть аквариум, в котором плавают рыбы.В этом аквариуме может быть максимум определенное кол-во рыб.Рыб
             можно добавить в аквариум или рыб можно достать из аквариума.(программу делать в цикле для того,
             чтобы рыбы могли “жить”)
             Все рыбы отображаются списком, у рыб также есть возраст.За 1 итерацию рыбы стареют
             на определенное кол - во жизней и могут умереть.Рыб также вывести в консоль, чтобы можно
             было мониторить показатели.
            */
            Aquarium aquarium = new Aquarium();
            
            while (true)
            {
                aquarium.ShowFish();
                int.TryParse(Console.ReadLine(), out int enter);

                switch (enter)
                {
                    case 1:
                        aquarium.AddFish();
                        break;
                    case 2:
                        aquarium.RemoveFish();
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }

                aquarium.GetsOldAllFish();
                Console.WriteLine("Прошел еще один день.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}