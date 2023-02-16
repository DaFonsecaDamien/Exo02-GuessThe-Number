namespace Game;

public class NumberGenerator
{
    private Random _generator;

    public NumberGenerator()
    {
        _generator = new Random();
    }

    public int GenerateNumber(int maxNumber)
    {
        return _generator.Next(1, maxNumber);
    }
}