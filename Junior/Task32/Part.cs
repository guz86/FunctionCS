namespace Task32;

public class Part
{

    public int Id { get; set; }
    public int Cost { get; set; }
    public int Count { get; set; }
    public int WorkPrice { get; set; }

    public Part(int id, int cost, int count, int workPrice)
    {
        Id = id;
        Cost = cost;
        Count = count;
        WorkPrice = workPrice;
    }
}
