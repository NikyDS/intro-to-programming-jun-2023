
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1",1)]
    [InlineData("2",2)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result); 
    }

    [Theory]
    [InlineData("1,2",3)]
    [InlineData("4,5", 9)]
    public void DoubleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);

    }

    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("4,5,3", 12)]
    public void MultipleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);

    }

    [Theory]
    [InlineData("1\n2,3", 6)]
    [InlineData("4\n5\n3", 12)]
    public void NewLineDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);

    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//:\n4:5:3", 12)]
    public void NewDelimeterDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);

    }
}
