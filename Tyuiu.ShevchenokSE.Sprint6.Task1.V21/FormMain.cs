using Tyuiu.ShevchenokSE.Sprint6.Task0.V29.Lib;

namespace Tyuiu.ShevchenokSE.Sprint6.Task0.V29
{
    public partial class Form_SSE : Form
    {
        public Form_SSE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_2_SSE.Text = new DataService().Calculate(3).ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}