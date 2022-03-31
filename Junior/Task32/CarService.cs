namespace Task32;

public class CarService
{
    public int Money { get; set; }
    
    public void Start()
    {
        Storage storage = new Storage(10);
        ShowStorage(storage);
    }

    public void ShowStorage(Storage storage)
    {
        storage.ShowInfoPart();
    }
}

