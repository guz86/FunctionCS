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

            // Generate queueClients
            Random random = new Random();

            int countClients = random.Next(10);
            Queue<Client> queueClients = new Queue<Client>();

            /*queueClients.Enqueue(new Client(
                new List<Product> {new Product(300),new Product(300),new Product(300),new Product(300), new Product(300), new Product(200), new Product(300)}, 300));

            queueClients.Enqueue(new Client(
                new List<Product> {new Product(300),
                    new Product(300),
                    new Product(300),
                    new Product(300), 
                    new Product(300), 
                    new Product(200), 
                    new Product(300)}, 
                300));*/

            while (countClients > 0)
            {
                // generate products
                int countProduct = random.Next(10);
                List<Product> products = new List<Product>();
                products = new List<Product>();
                while (countProduct > 0)
                {
                    products.Add(new Product(random.Next(10, 500)));
                    countProduct--;
                }
                queueClients.Enqueue(new Client(products, random.Next(1000, 1500)));
                countClients--;
            }

            // Dequeue clients
            Console.WriteLine($"Количество клиентов в очереди: {queueClients.Count}\n");
            
            Client client;
            
            while (queueClients.Count > 0)
            {
                client = queueClients.Dequeue();
                client.Pay();
            }

            if (queueClients.Count == 0) Console.WriteLine("Очередь закончилась");
        }
    }
}