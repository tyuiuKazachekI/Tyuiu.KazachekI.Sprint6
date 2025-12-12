using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task7.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask;
        private GroupBox groupBoxIn;
        private GroupBox groupBoxOut;

        private FlowLayoutPanel panelButtons;

        private Button buttonLoad;
        private Button buttonProcess;
        private Button buttonSave;
        private Button buttonInfo;

        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;

        private Label labelFileInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            groupBoxTask = new GroupBox();
            Label labelTask = new Label();

            panelButtons = new FlowLayoutPanel();
            buttonLoad = new Button();
            buttonProcess = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();

            groupBoxIn = new GroupBox();
            dataGridViewIn = new DataGridView();

            groupBoxOut = new GroupBox();
            dataGridViewOut = new DataGridView();

            labelFileInfo = new Label();

            SuspendLayout();

            //
            // groupBoxTask
            //
            groupBoxTask.Text = "Условие задачи";
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Height = 80;

            labelTask.Text = "Загрузить CSV → заменить чётные элементы во 2-й строке на 555.";
            labelTask.Dock = DockStyle.Fill;
            labelTask.Padding = new Padding(10);

            groupBoxTask.Controls.Add(labelTask);

            //
            // Панель кнопок
            //
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Height = 60;
            panelButtons.Padding = new Padding(10);
            panelButtons.FlowDirection = FlowDirection.LeftToRight;

            //
            // buttonLoad
            //
            buttonLoad.Size = new Size(42, 42);
            buttonLoad.BackgroundImage = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint6\img\folder_add.png");
            buttonLoad.BackgroundImageLayout = ImageLayout.Stretch;
            buttonLoad.Click += buttonLoad_Click;

            //
            // buttonProcess
            //
            buttonProcess.Size = new Size(42, 42);
            buttonProcess.BackgroundImage = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint6\img\page_white_go.png");
            buttonProcess.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProcess.Enabled = false;
            buttonProcess.Click += buttonProcess_Click;

            //
            // buttonSave
            //
            buttonSave.Size = new Size(42, 42);
            buttonSave.BackgroundImage = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint6\img\save.png");
            buttonSave.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave.Enabled = false;
            buttonSave.Click += buttonSave_Click;

            //
            // buttonInfo
            //
            buttonInfo.Size = new Size(42, 42);
            buttonInfo.BackgroundImage = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint6\img\help.png");
            buttonInfo.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInfo.Click += buttonInfo_Click;

            panelButtons.Controls.Add(buttonLoad);
            panelButtons.Controls.Add(buttonProcess);
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Controls.Add(buttonInfo);

            //
            // groupBoxIn
            //
            groupBoxIn.Text = "Исходная матрица";
            groupBoxIn.Dock = DockStyle.Left;
            groupBoxIn.Width = 480;

            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.RowHeadersWidth = 50;
            dataGridViewIn.AllowUserToAddRows = false;
            dataGridViewIn.AllowUserToDeleteRows = false;

            groupBoxIn.Controls.Add(dataGridViewIn);

            //
            // groupBoxOut
            //
            groupBoxOut.Text = "Обработанная матрица";
            groupBoxOut.Dock = DockStyle.Fill;

            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.RowHeadersWidth = 50;
            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.AllowUserToDeleteRows = false;

            groupBoxOut.Controls.Add(dataGridViewOut);

            //
            // labelFileInfo
            //
            labelFileInfo.AutoSize = true;
            labelFileInfo.ForeColor = Color.DarkBlue;
            labelFileInfo.Location = new Point(20, 150);
            labelFileInfo.Text = "Файл не выбран";

            //
            // FormMain
            //
            ClientSize = new Size(1100, 650);
            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxIn);
            Controls.Add(labelFileInfo);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxTask);

            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(1000, 600);
            Text = "Спринт 6 | Task 7 | Вариант 2 | Казачек И.";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
