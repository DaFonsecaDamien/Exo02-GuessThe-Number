using Game;


var game = new GuessTheNumberGame( 
    new NumberGenerator(),
    new InputReader(),
    new OutputWriter(),
    new NumberComparer()); 
game.Play();
Console.WriteLine("Press any key to exit..."); 
Console.ReadKey();
