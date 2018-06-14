using System;
using System.Linq;

public class Kata
{
    public static string BreakCamelCase(string str)
    {
        foreach (var c in str)
        {
            if (char.IsUpper(c) == true)
            {
                if (str[str.IndexOf(c) - 1].Equals(' '))
                {
                    continue;
                }
                str = str.Replace(($"{c}"), ($" {c}"));
            }
        }
        return str;
    }
}
