namespace Task26;

public class Way
{
    // создать направление
    // продать билеты

    public string WayInformation { get; }
    public int WayPassengers { get; private set; }

    public Way(string wayInfo)
    {
        WayInformation = wayInfo;
    }

    public void BuyTiket(int passangers)
    {
        WayPassengers = passangers;
    }
}