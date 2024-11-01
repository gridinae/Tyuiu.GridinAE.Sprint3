namespace Tyuiu.GridinAE.Sprint3.Task1.V12.Test;
using Tyuiu.GridinAE.Sprint3.Task1.V12.Lib;

[TestClass]
public class DataServicetTest
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        DataService ds = new();
        Assert.AreEqual(1.001, ds.GetSumSeries(5, 1, 10));
    }
}