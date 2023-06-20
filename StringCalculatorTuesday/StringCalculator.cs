
namespace StringCalculator;

public class StringCalculator
{
    int _sum;
    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return _sum = 0;
        }else if(numbers.Length == 1)
        {
            return _sum = int.Parse(numbers);
        }
        else
        {
            string[] multipleNumbers = numbers.Split(',','\n');
            foreach(string number in multipleNumbers)
            {
                _sum += int.Parse(number);
            }
            return _sum;

        }
    }
}
