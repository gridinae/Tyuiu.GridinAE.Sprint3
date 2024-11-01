namespace Tyuiu.GridinAE.Sprint3.Task2.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task2V10
{
    public double GetMultiplySeries(int value, int startValue, int stopValue)
    {
        double mult = 1;
        int k = startValue;
        int t = value;
        do
        {
            mult *= Math.Pow(t, k) + (double) 1 / (k + 1);
            k++;
        } while (k <= stopValue);
        return Math.Round(mult, 3);
    }
}
