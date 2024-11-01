namespace Tyuiu.GridinAE.Sprint3.Task1.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task1V12
{
    public double GetSumSeries(int value, int startValue, int stopValue)
    {
        double sum = 0;
        int k = startValue;
        while (k <= stopValue)
        {
            sum += Math.Pow(1 / Math.Pow(k, value), 2);
            k++;
        }
        return Math.Round(sum, 3);
    }
}
