using Tyuiu.ShevchenokSE.Sprint6.Task5.V15.Lib;
namespace Tyuiu.ShevchenokSE.Sprint6.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.ShevchenokSE.Sprint6\DataSprint6\InPutDataFileTask5V15.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}