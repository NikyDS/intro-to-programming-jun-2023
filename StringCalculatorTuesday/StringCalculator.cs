
namespace StringCalculator;

public class StringCalculator
{
    int _sum;
    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }else if(numbers.Length == 1)
        {
            return int.Parse(numbers);
        }
        else if (numbers[0] != '/')
        {
            string[] multipleNumbers = numbers.Split(',','\n');
            foreach(string number in multipleNumbers)
            {
                _sum += int.Parse(number);
            }
        }
        else
        {
            string[] multipleNumbers = numbers[4..].Split(numbers[2]);
            foreach (string number in multipleNumbers)
            {
                _sum += int.Parse(number);
            }
        }
        return _sum;
    }
}
