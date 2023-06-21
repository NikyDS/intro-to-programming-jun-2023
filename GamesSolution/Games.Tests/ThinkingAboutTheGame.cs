namespace Games.Tests;
public class ThinkingAboutTheGame
{
    [Fact]
    public void DuplicateNamesAreNotAllowed()
    {
        //Given
        var game = new BowlingGame();

        //When
        game.AddPlayer("Jim", 120);
        game.AddPlayer("Sue", 200);

        //Then
        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer("Jim", 200));
        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer("jim", 200));
        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer(" jim ", 200));
    }
}
