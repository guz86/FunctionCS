namespace Task25;

public class Player
{
    public int Money { get; private set; }
    
    public List<Product> myProduct { get; private set; }

    public Player(int money)
    {
        Money = money;
        myProduct = new List<Product>();
    }

    public void BuyChooseProduct(Product product)
    {
        
        myProduct.Add(product);
        Money -= product.Cost;
    }
    public void ShowPlayerProduct()
    {
        Console.WriteLine("Продукты в пакете:");
        foreach (var product in myProduct)
        {
            Console.Write($"{product.Name}");
            Console.WriteLine();
        }
        Console.WriteLine($"В кошельке: {Money}");
    }
}