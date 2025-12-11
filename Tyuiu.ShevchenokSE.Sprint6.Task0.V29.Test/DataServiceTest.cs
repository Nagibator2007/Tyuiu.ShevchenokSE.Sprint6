using Tyuiu.ShevchenokSE.Sprint6.Task0.V29.Lib;
namespace Tyuiu.ShevchenokSE.Sprint6.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcCheck()
        {
            var result = new DataService();
            Assert.AreEqual(0.722, result.Calculate(3));
        }
    }
}