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
                int xStart = -5;
                int xStop = 5;

                var vals = ds.GetMassFunction(xStart, xStop);

                var sb = new StringBuilder();

                sb.AppendLine("****************************");
                sb.AppendLine("*   x    |     f(x)        *");
                sb.AppendLine("****************************");

                for (int i = 0; i < vals.Length; i++)
                {
                    int x = xStart + i;
                    sb.AppendLine($"*  {x,4}  |  {vals[i],10:F2}  *");
                }

                sb.AppendLine("****************************");

                textBoxResult_KI.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 1 выполнен студентом группы ИСТНб-25-1 Казачек И.",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
