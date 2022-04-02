namespace Task37;

public class Can
{
    public string Name { get; }
    public DateTime YearProduction { get; }
    public int ExpirationDate { get; }
    
    public Can(string name, DateTime yearProduction, int expirationDate)
    {
        Name = name;
        YearProduction = yearProduction;
        ExpirationDate = expirationDate;
    }
}