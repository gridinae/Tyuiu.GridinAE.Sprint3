namespace Tyuiu.GridinAE.Sprint3.Task2.V10.Test;
using Tyuiu.GridinAE.Sprint3.Task2.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetMultiplySeries()
    {
        DataService ds = new();
        Assert.AreEqual(7.5, ds.GetMultiplySeries(1, 1, 13));
    }
}