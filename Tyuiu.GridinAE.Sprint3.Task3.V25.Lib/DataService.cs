namespace Tyuiu.GridinAE.Sprint3.Task3.V25.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task3V25
{
    public int GetMinCharCount(string value, char item)
    {
        int k = 0;
        foreach(char c in value)
        {
            if (c == item)
                k++;
        }
        return k;
    }
}
