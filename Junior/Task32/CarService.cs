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
        
            
        for (int i = 0; i < 100; i++)
        {
            Client newClient = new Client(_random.Next(100, 200));
            newClient.Id = storage.IdPart()[_random.Next(storage.IdPart().Length)];
            clients.Enqueue(newClient);

        }
        
        foreach (var client in clients)
        {
            Console.WriteLine($"{client.Id} {client.Money}");
        }
    }

    public void ShowStorage(Storage storage)
    {
        storage.ShowInfoPart();
    }
    
   
}