using Tyuiu.GridinAE.Sprint3.Task4.V29.Lib;
namespace Tyuiu.GridinAE.Sprint3.Task4.V29.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        Assert.AreEqual(0, new DataService().Calculate(-5, 5));
    }
}