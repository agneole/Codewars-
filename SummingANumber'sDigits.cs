using System;
public class Kata
{
    public static int SumDigits(int number)
    {
        number = (number < 0) ? -1 * number : number;
        string numberAsString = number.ToString();
        int sum = 0;
        foreach (char c in numberAsString)
        {
            sum = sum + int.Parse(c.ToString());
        }

        return sum;
    }
}
