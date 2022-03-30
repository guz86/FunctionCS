namespace Task30;

public class Fish
{
    public int Old { get; private set; }

    public Fish(int old)
    {
        Old = old;
    }

    public void GetsOld()
    {
        Old--;
    }
}