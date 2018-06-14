using System;
public class ASum
{

    public static long findNb(long m)
    {
        int i = 0;
        for (; m > 0; i++)
        {
            m = m - (long)Math.Pow(1 + i, 3);
        }
        return m == 0 ? i : -1;
    }

}