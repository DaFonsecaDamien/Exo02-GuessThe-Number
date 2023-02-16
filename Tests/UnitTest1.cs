using Game;

namespace Tests;
public class UnitTest1
{
    [Fact]
    public void fix_test_to_make_this_test_pass_Sample()
    {
        var game = new GuessTheNumberGame( 
            new NumberGenerator(),
            new InputReader(),
            new OutputWriter(),
            new NumberComparer());
        game.Title = "Change me!";
        Check.That(game.Title).IsEqualTo("Change me!"); 
    }
}