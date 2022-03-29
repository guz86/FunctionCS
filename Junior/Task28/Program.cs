namespace Task28
{
    class Program
    {
        static void Main()
        {
            Shop shop = new Shop();
            shop.GenerateClients();
            shop.DequeueClients();
        }
    }
}