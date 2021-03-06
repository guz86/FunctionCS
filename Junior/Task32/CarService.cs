namespace Task32;

public class CarService
{
    private Random _random = new Random();
    private int _countPenalty;
    private int _countForceMajeur;
    private int _sumForceMajeur;
    private Queue<Client> _clients = new Queue<Client>();
    
    public int Money { get; private set; }

    
    public void Start()
    {
        Storage storage = new Storage(10);
        ShowStorage(storage);
        // очередь клиентов
        _clients = ClientQueue(storage, 50);
        // обслуживание
        Service(storage);
        Console.WriteLine("\nПосле рабочего дня\n");
        ShowStorage(storage);
    }
    
    private Queue<Client> ClientQueue(Storage storage, int count)
    {
        Queue<Client> newClients = new Queue<Client>();

        for (int i = 0; i < count; i++)
        {
            Client newClient = new Client(_random.Next(10000, 20000));
            newClient.Id = storage.IdPart()[_random.Next(storage.IdPart().Length)];
            newClients.Enqueue(newClient);
        }

        return newClients;
    }

    private void Service(Storage storage)
    {
        while (_clients.Count > 0)
        {
            Client newClient = _clients.Dequeue();
            Console.WriteLine($"\nПри осмотре авто, выяснилось что требуется поменять деталь с ID: {newClient.Id}");
            Console.WriteLine("Проверяем склад...");
            bool findPart = false;
            int sumWorkPart = 0;
            for (int i = 0; i < storage.IdPart().Length; i++)
            {
                if (storage.IdPart()[i] == newClient.Id)
                {
                    sumWorkPart = storage.CostPart(newClient.Id) + storage.WorkPricePart(newClient.Id);
                    Console.WriteLine($"Для клиента нашлась деталь {newClient.Id}");
                    Console.WriteLine($"Требуется заплатить за деталь {storage.CostPart(newClient.Id)}" +
                                      $" и за ремонт {storage.WorkPricePart(newClient.Id)} в сумме {sumWorkPart}");
                    findPart = true;
                    break;
                }
            }

            if (findPart)
            {
                Console.WriteLine("Проверяем есть хватит ли у клиента средств на ремонт");
                if (newClient.Money > sumWorkPart)
                {
                    Console.WriteLine("Осуществляем ремонт/замену");
                    storage.RepairPart(newClient.Id);
                    Console.WriteLine($"Клиент заплатил " +
                                      $"{sumWorkPart}");
                    PayClient(newClient);
                    ForceMajeur(newClient, sumWorkPart);
                }
                else
                {
                    Console.WriteLine("У клиента не достаточно средств, Всего Хорошего");
                }
            }

            if (!findPart)
            {
                Console.WriteLine($"Для клиента нет детали {newClient.Id}");
                PenaltyPart(newClient);
            }
        }
    }

    public void ShowStorage(Storage storage)
    {
        Console.WriteLine($"Касса: {Money}");
        Console.WriteLine($"Штрафов {_countPenalty}, на сумму {_countPenalty * 500}");
        Console.WriteLine($"Форсмажоров {_countForceMajeur}, на сумму {_sumForceMajeur}");
        storage.ShowInfoPart();
    }


    public void PayClient(Client client)
    {
        Money += client.Money;
    }

    public void PenaltyPart(Client client)
    {
        Money -= 500;
        Console.WriteLine("Клиент получает компенсацию в 500");
        _countPenalty++;
    }

    public void ForceMajeur(Client client, int sum)
    {
        if (_random.Next(20) == 0)
        {
            Console.WriteLine($"Упс... не верная диагностика, клиент получает компенсацию {sum}");
            Money -= sum;
            _countForceMajeur++;
            _sumForceMajeur += sum;
        }
    }
}