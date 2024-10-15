namespace Tyuiu.GridinAE.Sprint3.Task0.V27.Test;
using Tyuiu.GridinAE.Sprint3.Task0.V27.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        var dataService = new DataService();

        int n = 3;
        int startValue = 2;
        int stopValue = 5;

        double res = dataService.GetSumSeries(n, startValue, stopValue);
        double wait = 0.277;

        Assert.AreEqual(wait, res);
    }
}