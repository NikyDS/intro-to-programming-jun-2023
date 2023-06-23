using System.Security.Cryptography.X509Certificates;

namespace Greeter.UnitTests;
public class GreetingTest
{
    private readonly GreetingMaker _greeter;
    public GreetingTest()
    {
        _greeter = new GreetingMaker();
    }
    [Theory]
    [InlineData("Windom", "Hello, Windom!")]
    [InlineData("Cooper", "Hello, Cooper!")]
    public void SingleName(string name, string expected)
    {
        string greeting = _greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }
    [Fact]
    public void NullName()
    {
        string greeting = _greeter.Greet( null);

        Assert.Equal("Hello, Chief!", greeting);
    }
    [Theory]
    [InlineData("BOB", "HELLO, BOB!")]
    [InlineData("COOPER", "HELLO, COOPER!")]
    public void ShoutingName(string name, string expected)
    {
        string greeting = _greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }

    [Theory]
    [InlineData("Bob", "Sue", "Hello, Bob and Sue!")]
    [InlineData("Windom", "Cooper", "Hello, Windom and Cooper!")]
    public void TwoNames(string name, string name1, string expected)
    {
        string greeting = _greeter.Greet(name, name1);
        Assert.Equal(expected, greeting);
    }

    [Fact]
    public void MultipleNamesExample()
    {
        string greeting = _greeter.Greet("Cole", "Cooper", "Rosenfield", "Preston", "Milford", "Jeffries");
        Assert.Equal("Hello, Cole, Cooper, Rosenfield, Preston, Milford and Jeffries!", greeting);
    }
    [Fact]
    public void MultipleNames()
    {
        string greeting = _greeter.Greet("Windom", "Preston", "Milford", "Jeffries");
        Assert.Equal("Hello, Windom, Preston, Milford and Jeffries!", greeting);
    }

    [Fact]
    public void ShoutingMultipleNames()
    {
        string greeting = _greeter.Greet("WINDOM", "PRESTON", "MILFORD", "JEFFRIES");
        Assert.Equal("HELLO, WINDOM, PRESTON, MILFORD AND JEFFRIES!", greeting);
    }
    [Fact]
    public void ShoutingSomeNames()
    {
        string greeting = _greeter.Greet("WINDOM", "Preston", "Milford", "Jeffries");
        Assert.Equal("Hello, Preston, Milford, Jeffries AND WINDOM!", greeting);
    }
}
