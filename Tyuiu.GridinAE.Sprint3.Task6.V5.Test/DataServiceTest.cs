namespace Tyuiu.GridinAE.Sprint3.Task6.V5.Test;
using Tyuiu.GridinAE.Sprint3.Task6.V5.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void GetSumTheDivisors()
    {
        Assert.AreEqual(94, new DataService().GetSumTheDivisors(15, 22));
    }
}