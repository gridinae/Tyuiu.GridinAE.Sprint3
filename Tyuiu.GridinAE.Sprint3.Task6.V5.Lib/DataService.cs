namespace Tyuiu.GridinAE.Sprint3.Task6.V5.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task6V5
{
    public int GetSumTheDivisors(int startValue, int stopValue)
    {
        int sum = 0;
        for (int i = startValue; i <= stopValue; i++)
        {
            sum += i;
            for (int d = 1; d <= Math.Ceiling(i * 0.5); d++)
            {
                if (i % d == 0)
                    sum += d;
            }
        }
        return sum;
    }
}
