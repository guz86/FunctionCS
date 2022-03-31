namespace Task33;

public class Criminal
{
    public string Fio { get; private set; }
    public bool State { get; private set; }
    public int Growth { get; private set; }
    public int Weight { get; private set; }
    public string Nation { get; private set; }

    public Criminal(string fio, bool state, int growth, int weight, string nation)
    {
        Fio = fio;
        State = state;
        Growth = growth;
        Weight = weight;
        Nation = nation;
    }
}