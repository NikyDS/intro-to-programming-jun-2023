using System.Linq;

namespace Greeter
{
    public class GreetingMaker
    {

        public string Greet(params string[] names)
        {
            if (names == null) { return "Hello, Chief!"; }
            var lastName = names[names.Length - 1] + "!";
            if (names.Length > 1)
            {        
                var firstNames = names.Take(names.Length - 1).ToArray();
                var response = $"Hello, {String.Join(", ", firstNames)}" + $" and {lastName}";
                if (names.Length == names.Count(n => n.All(c => char.IsUpper(c))))
                {
                    return response.ToUpper();
                }
                else if (names.Any(n => n.All(c => char.IsUpper(c))))
                { 
                }
                return response;
            }
            else if (names.Any(n => n.All(c => char.IsUpper(c))))
            {
                return $"HELLO, {lastName}";
            }
            return $"Hello, {lastName}";
        }
    }
}