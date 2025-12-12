using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task4.V14
{
    partial class FormMain
    {
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private PictureBox pictureBoxTask;
        private GroupBox groupBoxChart;
        private PictureBox pictureBoxChart;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Button buttonCalc;
        private Button buttonSave;
        private Button buttonInfo;

        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            pictureBoxTask = new PictureBox();
            groupBoxChart = new GroupBox();
            pictureBoxChart = new PictureBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            buttonCalc = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();

            // groupBoxTask
            groupBoxTask.Text = "Условие задачи";
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Height = 150;

            textBoxTask.Multiline = true;
            textBoxTask.ReadOnly = true;
            textBoxTask.ScrollBars = ScrollBars.Vertical;
            textBoxTask.Dock = DockStyle.Top;
            textBoxTask.Height = 50;
            textBoxTask.Text = "Дан массив для вычисления f(x).\r\nФормула: f(x) = x + 2 + x/(cos(x)+1)";

            pictureBoxTask.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTask.Dock = DockStyle.Fill;

            groupBoxTask.Controls.Add(pictureBoxTask);
            groupBoxTask.Controls.Add(textBoxTask);

            // groupBoxChart
            groupBoxChart.Text = "График";
            groupBoxChart.Dock = DockStyle.Right;
            groupBoxChart.Width = 500;

            pictureBoxChart.Dock = DockStyle.Fill;
            pictureBoxChart.BackColor = Color.White;
            pictureBoxChart.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxChart.Paint += pictureBoxChart_Paint;

            groupBoxChart.Controls.Add(pictureBoxChart);

            // groupBoxResult
            groupBoxResult.Text = "Содержимое файла";
            groupBoxResult.Dock = DockStyle.Fill;

            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Multiline = true;
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;

            groupBoxResult.Controls.Add(textBoxResult);

            // Buttons
            buttonCalc.Text = "Выполнить";
            buttonCalc.BackColor = Color.LightGreen;
            buttonCalc.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonCalc.Dock = DockStyle.Left;
            buttonCalc.Width = 150;
            buttonCalc.Click += buttonCalc_Click;

            buttonSave.Text = "Сохранить";
            buttonSave.BackColor = Color.LightSalmon;
            buttonSave.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Width = 150;
            buttonSave.Click += buttonSave_Click;

            buttonInfo.Text = "Инфо";
            buttonInfo.BackColor = Color.LightSkyBlue;
            buttonInfo.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonInfo.Dock = DockStyle.Right;
            buttonInfo.Width = 150;
            buttonInfo.Click += buttonInfo_Click;

            Panel panelButtons = new Panel();
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Height = 50;
            panelButtons.Controls.Add(buttonCalc);
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Controls.Add(buttonInfo);

            // Form
            ClientSize = new Size(1000, 600);
            Text = "Спринт 6 | Таск 4 | Вариант 14 | Казачек И.";
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.CenterScreen;

            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxChart);
            Controls.Add(groupBoxTask);
            Controls.Add(panelButtons);
        }
    }
}
