namespace Tyuiu.GridinAE.Sprint3.Task0.V27.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task0V27
{
    public double GetSumSeries(int value, int startValue, int stopValue)
    {
        double sumSeries = 0;
        for (int k = startValue; k <= stopValue; k++)
            sumSeries += Math.Pow(4 / Math.Pow(k, value), 2);
        return Math.Round(sumSeries, 3);
    }
}
