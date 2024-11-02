namespace Tyuiu.GridinAE.Sprint3.Task3.V25.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task3V25
{
    public int GetMinCharCount(string value, char item)
    {
        int m = 0;
        int k = 0;
        char? old_char = null;

        foreach (char c in value)
        {
            m = Math.Max(m, k);
            if (c == old_char && c == item)
                k++;
            else
                k = 0;
            old_char = c;
        }
        return m;
    }
}
