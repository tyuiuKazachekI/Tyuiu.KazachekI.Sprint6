using System;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task0.V29.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task0.V29
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
                int x = int.Parse(textBoxX.Text);
                double y = ds.Calculate(x);
                textBoxResult.Text = $"Результат при x = {x}: {y:F3}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число для x", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСТНб-25-1 Казачек И.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
