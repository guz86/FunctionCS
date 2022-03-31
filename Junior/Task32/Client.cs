namespace Task32;

public class Client
{
    public int Money { get; set; }
    public int Id { get; set; }
    
    public Client(int money)
    {
        Money = money;
        Id = 0;
    }
}