using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShevchenokSE.Sprint6.Task5.V15.Lib
{
    public class DataService : ISprint6Task5V15
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index++] = Convert.ToDouble(line);
                }
            }
            numsArray = numsArray.Where(val => 2 <= val && val <= 7).ToArray();
            return numsArray;
        }
    }
}