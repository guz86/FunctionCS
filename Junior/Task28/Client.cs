namespace Task28;

public class Client
{
    public List<Product> ShoppingCart { get; set; }
    public int Money { get; set; }
    private bool _shortMoney = true;
    private int _sumShopping;
    
    public Client(List<Product> shoppingCart, int money)
    {
        ShoppingCart = shoppingCart;
        Money = money;
    }

    private void CheckMoney()
    {
        while (_shortMoney)
        {
            foreach (var product in ShoppingCart)
            {
                _sumShopping += product.Cost;
            }
            
            if (_sumShopping > Money)
            {
                Console.WriteLine($" Сумма покупки {_sumShopping} и денег у клиента {Money}");
                DropProduct();
            }
            else
            {
                _shortMoney = false;
            }
            
            _sumShopping = 0;
        }
    }

    private void DropProduct()
    {
        if (_shortMoney)
        {
            Random random = new Random();
            int numberProduct = random.Next(0, ShoppingCart.Count);
            ShoppingCart.RemoveAt(numberProduct);
            Console.WriteLine($"Клиент выкинул товар под номером {numberProduct + 1} из {ShoppingCart.Count + 1}");
        }
    }

    public void Pay()
    {
        int countProduct = 0;
        CheckMoney();
        foreach (var product in ShoppingCart)
        {
            countProduct++;
            _sumShopping += product.Cost;
        }

        Money -= _sumShopping;
        Console.WriteLine($"Покупка товаров {countProduct} на сумму {_sumShopping}, совершена. " +
                          $"У клиента осталось {Money}");
    }
}