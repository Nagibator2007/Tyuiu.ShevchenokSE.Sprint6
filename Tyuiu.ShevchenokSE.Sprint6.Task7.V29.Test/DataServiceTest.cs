using Tyuiu.ShevchenokSE.Sprint6.Task7.V29.Lib;
namespace Tyuiu.ShevchenokSE.Sprint6.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            string path = @"C:\Users\sergejbabidzonov\source\repos\Tyuiu.ShevchenokSE.Sprint6\Tyuiu.ShevchenokSE.Sprint6.Task7.V29\bin\Debug\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}