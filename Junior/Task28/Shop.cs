namespace Task28;

public class Shop
{
    public int CountClients { get; private set; }
    public Queue<Client> QueueClients { get; private set; }

    public void GenerateClients()
    {
        // Generate queueClients
        QueueClients = new Queue<Client>();
        Random random = new Random();
        CountClients = random.Next(5, 10);
        while (CountClients > 0)
        {
            // generate products for clients
            int countProduct = random.Next(1, 10);
            List<Product> products = new List<Product>();
            while (countProduct > 0)
            {
                products.Add(new Product(random.Next(10, 500)));
                countProduct--;
            }

            QueueClients.Enqueue(new Client(products, random.Next(1000, 1500)));
            CountClients--;
        }
    }

    public void DequeueClients()
    {
        // Dequeue clients
        Console.WriteLine($"Количество клиентов в очереди: {QueueClients.Count}\n");

        Client client;

        while (QueueClients.Count > 0)
        {
            client = QueueClients.Dequeue();
            client.Pay();
        }

        if (QueueClients.Count == 0) Console.WriteLine("Очередь закончилась");
    }
}