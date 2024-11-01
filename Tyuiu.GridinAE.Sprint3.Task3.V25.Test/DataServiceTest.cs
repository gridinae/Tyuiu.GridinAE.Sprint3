namespace Tyuiu.GridinAE.Sprint3.Task3.V25.Test;
using Tyuiu.GridinAE.Sprint3.Task3.V25.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetMinCharCount()
    {
        Assert.AreEqual(6, new DataService().GetMinCharCount("kjhgfuu gujut dtuu", 'u'));
    }
}