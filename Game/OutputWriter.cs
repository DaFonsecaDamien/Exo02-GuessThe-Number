namespace Game;

public class OutputWriter
{
    public void Write(string message)
    {
        Console.WriteLine(message);
    }
    
    public void WriteTitle(string title)
    {
        Write("-===========================-");
        Write($"=== {title} ===");
        Write("-===========================-");
    }
    
    public void WriteGuessTheNumber(int maxNumber)
    {
        Write($"Guess the number (between 1 and {maxNumber}):");
    }
    
    public void WriteYouFoundIt(int attempts)
    {
        Write($"You found it after {attempts} tries!");
    }
    
    public void WriteWrong(int attemptsLeft, int maxAttempts, string comparison)
    {
        Write($"Wrong! Your number is {comparison} than the correct one. {attemptsLeft}/{maxAttempts} tries left.");
    }
    
    public void WriteYouLost(int maxAttempts, int expectedNumber)
    {
        Write($"You lost after {maxAttempts} tries. The expected number was {expectedNumber}.");
    }
    
    public void WriteTryAgain()
    {
        Write("----------------------------------------------------");
        Write("Do you want to try again with a new number (yes/no)?");
    }
    
    public void WriteThanksForPlaying()
    {
        Write("== Thanks for playing! ==");
    }
}