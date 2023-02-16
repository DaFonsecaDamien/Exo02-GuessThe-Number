namespace Game;

public class GuessTheNumberGame
{
    private const int MaxAttempts = 10;
    private const int MaxNumber = 100;

    private NumberGenerator _numberGenerator;
    private InputReader _inputReader;
    private OutputWriter _outputWriter;
    private NumberComparer _numberComparer;
    public string Title { get; set; } = "GUESS THE NUMBER GAME";

    public GuessTheNumberGame(NumberGenerator numberGenerator, InputReader inputReader, OutputWriter outputWriter, NumberComparer numberComparer)
    {
        _numberGenerator = numberGenerator;
        _inputReader = inputReader;
        _outputWriter = outputWriter;
        _numberComparer = numberComparer;
    }

    public void Play()
    {
        _outputWriter.WriteTitle(Title);

        var continuePlaying = true;

        while (continuePlaying)
        {
            var expectedNumber = _numberGenerator.GenerateNumber(MaxNumber);
            //uncomment during tests: 
            //Console.WriteLine($"debug : the expected number is {number}");

            var userGuess = 0;
            var attempts = 0;

            while (userGuess != expectedNumber && attempts < MaxAttempts)
            {
                _outputWriter.WriteGuessTheNumber(MaxNumber);
                try
                {
                    userGuess = _inputReader.ReadInput();
                }
                catch (ArgumentException ex)
                {
                    _outputWriter.Write(ex.Message + $"{MaxAttempts - attempts}/{MaxAttempts} tries left");
                    continue;
                }

                attempts++;

                if (userGuess == expectedNumber)
                {
                    _outputWriter.WriteYouFoundIt(attempts);
                }
                else
                {
                    var comparison = _numberComparer.CompareNumbers(expectedNumber, userGuess);
                    var attemptsLeft = MaxAttempts - attempts;
                    _outputWriter.WriteWrong(attemptsLeft, MaxAttempts, comparison);
                }
            }

            if (userGuess != expectedNumber)
            {
                _outputWriter.WriteYouLost(MaxAttempts, expectedNumber);
            }
            
            _outputWriter.WriteTryAgain();
            var userResponse = Console.ReadLine();
            continuePlaying = userResponse?.Trim().ToLowerInvariant() == "yes";
        }
        _outputWriter.WriteThanksForPlaying();
    }
}