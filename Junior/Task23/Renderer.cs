namespace Task23;

public class Renderer
{
    public void Draw(int x, int y, char ch = '$')
    {
        Console.SetCursorPosition(x, y);
        Console.Write(ch);
    }
}