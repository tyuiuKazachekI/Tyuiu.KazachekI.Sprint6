using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task1.V14.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int start = -5; // диапазон фиксирован
                int stop = 5;

                double[] results = ds.GetMassFunction(start, stop);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < results.Length; i++)
                {
                    sb.AppendLine($"x = {start + i}, f(x) = {results[i]:F2}");
                }

                textBoxResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Sprint6, вариант 14 выполнен студентом Казачек Иван", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
