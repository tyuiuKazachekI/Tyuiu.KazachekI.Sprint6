using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task1.V14
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask_KI;
        private PictureBox pictureTask_KI;

        private GroupBox groupBoxOutput_KI;
        private TextBox textBoxResult_KI;

        private Button btnRun_KI;
        private Button btnInfo_KI;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            groupBoxTask_KI = new GroupBox();
            pictureTask_KI = new PictureBox();

            groupBoxOutput_KI = new GroupBox();
            textBoxResult_KI = new TextBox();

            btnRun_KI = new Button();
            btnInfo_KI = new Button();

            SuspendLayout();

            ClientSize = new Size(900, 520);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Казачек И.";

            groupBoxTask_KI.Text = "Условие";
            groupBoxTask_KI.Location = new Point(10, 10);
            groupBoxTask_KI.Size = new Size(430, 500);

            pictureTask_KI.Dock = DockStyle.Fill;
            pictureTask_KI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTask_KI.Image = Image.FromFile(@"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint6\img\task1.png");

            groupBoxTask_KI.Controls.Add(pictureTask_KI);

            groupBoxOutput_KI.Text = "Вывод данных";
            groupBoxOutput_KI.Location = new Point(450, 10);
            groupBoxOutput_KI.Size = new Size(430, 400);

            textBoxResult_KI.Multiline = true;
            textBoxResult_KI.ReadOnly = true;
            textBoxResult_KI.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KI.Font = new Font("Consolas", 11f);
            textBoxResult_KI.Dock = DockStyle.Fill;

            groupBoxOutput_KI.Controls.Add(textBoxResult_KI);

            btnRun_KI.Text = "Выполнить";
            btnRun_KI.Size = new Size(200, 45);
            btnRun_KI.Location = new Point(660, 430);
            btnRun_KI.BackColor = Color.LightGreen;
            btnRun_KI.Click += buttonExecute_Click;

            btnInfo_KI.Text = "Справка";
            btnInfo_KI.Size = new Size(150, 45);
            btnInfo_KI.Location = new Point(450, 430);
            btnInfo_KI.Click += buttonInfo_Click;

            Controls.Add(groupBoxTask_KI);
            Controls.Add(groupBoxOutput_KI);
            Controls.Add(btnRun_KI);
            Controls.Add(btnInfo_KI);

            ResumeLayout(false);
        }
    }
}
