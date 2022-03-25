namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            // решил остановиться на 7 товарах
            Shop shop = new Shop(7);
            Player player = new Player(999);
            while (true)
            {
                Console.WriteLine(
                    "Что желаете? (1) показать товар | (2) купить товар | (3) посмотреть свои вещи | (0) выйти");
                bool checkEnter = int.TryParse(Console.ReadLine(), out int enter);
                if (checkEnter)
                {
                    switch (@enter)
                    {
                        case 1:
                            shop.ShowProduct();
                            break;
                        case 2:
                            shop.BuyProduct(player);
                            break;
                        case 3:
                            player.ShowPlayerProduct();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Не верная команда");
                            break;
                    }
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}