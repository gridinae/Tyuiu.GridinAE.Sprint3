namespace Tyuiu.GridinAE.Sprint3.Task7.V3.Lib;

using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task7V3
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        static double Evaluate(int x)
        {
            double divisor = Math.Sin(x) - 3 + x;
            if (divisor == 0)
                return 0;
            else
                return (3 * x - 1.5) / divisor + 2;
        }

        double[] values = new double[stopValue - startValue + 1];
        for (int i = startValue; i <= stopValue; i++)
        {
            values[i - startValue] = (Math.Round(Evaluate(i), 2));
        }
        return values;
    }
}
