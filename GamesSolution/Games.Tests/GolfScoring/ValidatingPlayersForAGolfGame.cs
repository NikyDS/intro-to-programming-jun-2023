namespace Games.Tests.GolfScoring;
public class ValidatingPlayersForAGolfGame
{
    [Fact]
    public void DuplicateNamesAreNotAllowed()
    {
        //Given
        var game = new GolfGame();

        //When
        game.AddPlayer("Jim", 120);
        game.AddPlayer("Sue", 200);

        //Then
        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer("Jim", 200));
        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer("jim", 200));
        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer(" jim ", 200));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-72)]
    public void InvalidGolfScores(int invalidScore)
    {
        var game = new GolfGame();
        Assert.Throws<InvalidGolfScoreException>(() => game.AddPlayer("Joe", invalidScore));
    }
}
