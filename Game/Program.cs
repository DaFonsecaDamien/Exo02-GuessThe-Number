using Game;


var game = new GuessTheNumberGame( 
    new NumberGenerator(),
    new InputReader(),
    new OutputWriter(),
    new NumberComparer()); 
game.Play();
