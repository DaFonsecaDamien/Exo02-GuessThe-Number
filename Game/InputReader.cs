namespace Game;

public class InputReader
{
    public int ReadInput()
    {
        var readLine = Console.ReadLine();
        if (int.TryParse(readLine, out var result))
        {
            return result;
        }
        throw new ArgumentException($"your input was '{readLine}', please enter a valid integer.");
    }
}