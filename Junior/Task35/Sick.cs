namespace Task35;

public class Sick
{
    public string Fio { get; }
    public int Old { get; }
    public string Disease { get; }

    public Sick(string fio, int old, string disease)
    {
        Fio = fio;
        Old = old;
        Disease = disease;
    }
}