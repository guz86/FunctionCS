using System.Threading.Channels;

namespace Task25;

public class Shop
{
    private int money;
    private string[] namesProduct =
    {
        "Кружка", "Тарелка", "Сковорода", "Чайник", "Моющее средство", "Вилка", "Ложка"
    };
    
    public List<Product> ShopProduct { get; private set; }

    
    
    public Shop(int products)
    {
        Random rand = new Random();
        ShopProduct = new List<Product>(products);
        
        for (int i = 0; i < products; i++)
        {
            string name = namesProduct[i];
            int cost = rand.Next(1, 100);
            Product product = new Product(name, cost);
            ShopProduct.Add(product);
        }
    }

    public void ShowProduct()
    {
        Console.WriteLine("В магазине есть следующие товары:");
        foreach (var product in ShopProduct)
        {
            Console.Write($"Цена: {product.Cost} \t {product.Name}");
            Console.WriteLine();
        }
    }
    
    public void BuyProduct(Player player)
    {
        ShowProduct();
        Console.WriteLine("Введите название товара, который, хотите купить");
        string wantBuyProduct = Console.ReadLine();
        Product deleteProduct = new Product("", 0);
        foreach (var buyProduct in ShopProduct)
        {
            if (buyProduct.Cost < player.Money &&
                wantBuyProduct.ToLower() == buyProduct.Name.ToLower())
            {
                player.BuyChooseProduct(buyProduct);
                money += buyProduct.Cost;
                Console.WriteLine($"Вы купили {buyProduct.Name} за {buyProduct.Cost}");
                deleteProduct = buyProduct;
            }
        }
        ShopProduct.Remove(deleteProduct);
    }
}