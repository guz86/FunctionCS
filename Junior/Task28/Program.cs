namespace Task28
{
    class Program
    {
        static void Main()
        {
            /* Супермаркет
                 Написать программу администрирования супермаркетом.В супермаркете есть очередь клиентов.У
                 каждого клиента в корзине есть товары, также у клиентов есть деньги.Клиент, когда подходит на
                 кассу, получает итоговую сумму покупки и старается её оплатить.Если оплатить клиент не может, то он
                 рандомный товар из корзины выкидывает до тех пор, пока его денег не хватит для оплаты.Клиентов
                 можно делать ограниченное число на старте программы.
            */

            Random random = new Random();
            Queue<Client> queueClients = new Queue<Client>();
            queueClients.Enqueue(new Client(
                new List<Product> {new Product(300),new Product(300),new Product(300),new Product(300), new Product(300), new Product(200), new Product(300)}, 300));

            queueClients.Enqueue(new Client(
                new List<Product> {new Product(300),
                    new Product(300),
                    new Product(300),
                    new Product(300), 
                    new Product(300), 
                    new Product(200), 
                    new Product(300)}, 
                300));

            Client client = queueClients.Dequeue();
            client.Pay();
        }
    }
}