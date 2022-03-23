namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            // ООП
            //     Работа с классами
            // Создать класс игрока, с полями, содержащими информацию об игроке
            // и методом, который выводит информацию на экран.
            //     В классе обязательно должен быть конструктор
            Player player = new Player("Alexey", 100);
            player.PlayerInfo();
        }
    }
}