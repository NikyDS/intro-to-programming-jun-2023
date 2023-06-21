namespace CSharpStuff;
public class Utilities
{
    public static FormattedName FormatName(string firstName, string lastName)
    {
        var fullName = $"{lastName}, {firstName}";
        //var response = new FormattedName();
        //response.FullName = fullName;
        //response.NumberOfLetters = fullName.Length;
        var response = new FormattedName
        {
            FullName = fullName,
            NumberOfLetters = fullName.Length,
        };
        return response; 
     }
}

//public record FormattedName(string fullName, int NumberOfLetters);

public record class FormattedName
{
    public string FullName { get; init; } = "";
    public int NumberOfLetters { get; init; }

 }

