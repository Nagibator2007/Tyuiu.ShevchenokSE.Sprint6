using Tyuiu.ShevchenokSE.Sprint6.Task7.V29.Lib;
namespace Tyuiu.ShevchenokSE.Sprint6.Task7.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SAH.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
            saveFileDialogMatrix_SAH.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
        }
        static string OpenFilePath;
        DataService ds = new DataService();
        static int rows;
        static int columns;

        private void buttonSave_SAH_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SAH.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SAH.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SAH.ShowDialog();

            string path = saveFileDialogMatrix_SAH.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridOutPut_SSE.RowCount;
            int columns = dataGridOutPut_SSE.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridOutPut_SSE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridOutPut_SSE.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_SAH_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(OpenFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridOutPut_SSE.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            dataGridOutPut_SSE.Enabled = true;
        }

        public static int[,] LoadFromFileDta(string FilePath)
        {
            string fileDta = File.ReadAllText(FilePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_SAH_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SAH.ShowDialog();
            OpenFilePath = openFileDialogTask_SAH.FileName;

            int[,] arrayValues = LoadFromFileDta(OpenFilePath);
            dataGridInput_SSE.ColumnCount = columns;
            dataGridInput_SSE.RowCount = rows;
            dataGridOutPut_SSE.ColumnCount = columns;
            dataGridOutPut_SSE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridInput_SSE.Columns[i].Width = 25;
                dataGridOutPut_SSE.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridInput_SSE.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(OpenFilePath);
            buttonDone_SSE.Enabled = true;

        }

        private void buttonHelp_SAH_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridInput_SSE.ColumnCount = 50;
            dataGridOutPut_SSE.ColumnCount = 50;
            dataGridInput_SSE.RowCount = 50;
            dataGridOutPut_SSE.RowCount = 50;
            for (int i = 0; i < 50; i++)
            {
                dataGridInput_SSE.Columns[i].Width = 25;
                dataGridOutPut_SSE.Columns[i].Width = 25;
            }
        }

        private void groupBoxUslovie_SSE_Enter(object sender, EventArgs e)
        {

        }
    }
}
