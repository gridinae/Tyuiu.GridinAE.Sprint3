namespace Tyuiu.GridinAE.Sprint3.Task7.V3.Test;
using Tyuiu.GridinAE.Sprint3.Task7.V3.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GetMassFunction()
    {
        Assert.AreEqual(4.34, new DataService().GetMassFunction(-5, 5).First());
    }
}