namespace Task32;

public class CarService
{
    private Random _random;
    public int Money { get; set; }

    public void Start()
    {
        Storage storage = new Storage(10);
        ShowStorage(storage);

        // очередь клиентов
        _random = new Random();
        Queue<Client> clients = new Queue<Client>();


        for (int i = 0; i < 50; i++)
        {
            Client newClient = new Client(_random.Next(100, 200));
            newClient.Id = storage.IdPart()[_random.Next(storage.IdPart().Length)];
            clients.Enqueue(newClient);
        }

        Console.WriteLine("Клиенты:");
        foreach (var client in clients)
        {
            Console.WriteLine($"{client.Id} {client.Money}");
        }

        while (clients.Count > 0)
        {
            Client newClient = clients.Dequeue();
            bool findPart = false;
            for (int i = 0; i < storage.IdPart().Length; i++)
            {
                if (storage.IdPart()[i] == newClient.Id)
                {
                    Console.WriteLine($"Для клиента нашлась деталь {newClient.Id}");
                    storage.RepairPart(storage.IdPart()[i]);
                    findPart = true;
                    Console.WriteLine("Осуществляем ремонт/замену");
                    Console.WriteLine("Берем с клиента деньги");
                    break;
                }
            }
            
            if (!findPart)
            {
                Console.WriteLine($"Для клиента нет детали {newClient.Id}");
            }
        }

        Console.WriteLine("\nПосле рабочего дня\n");
        
        ShowStorage(storage);
    }

    public void ShowStorage(Storage storage)
    {
        storage.ShowInfoPart();
    }
}