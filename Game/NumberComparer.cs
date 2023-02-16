namespace Game;

public class NumberComparer
{
    public string CompareNumbers(int expected, int actual)
    {
        if (actual == expected)
        {
            return "equal";
        }
        else if (actual < expected)
        {
            return "smaller";
        }
        else
        {
            return "greater";
        }
    }
}