using System;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task4.V14.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        private DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int start = -5;
                int stop = 5;
                double[] values = ds.GetMassFunction(start, stop);

                textBoxResult.Clear();
                for (int i = 0; i < values.Length; i++)
                {
                    textBoxResult.AppendText($"x = {start + i}, f(x) = {values[i]}\r\n");
                }

                ds.SaveToFile(values, "OutPutFileTask4V14.txt");

                MessageBox.Show("Вычисления выполнены и сохранены в OutPutFileTask4V14.txt", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
