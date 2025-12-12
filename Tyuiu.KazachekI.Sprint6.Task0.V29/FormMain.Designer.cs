using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task0.V29
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBoxTask_KI;
        private PictureBox picFormula_KI;
        private Label labelTask_KI;
        private GroupBox groupBoxOutput_KI;
        private TextBox textBoxResult;
        private Label labelX;
        private TextBox textBoxX;
        private Button buttonExecute;
        private Button buttonInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxTask_KI = new GroupBox();
            picFormula_KI = new PictureBox();
            labelTask_KI = new Label();
            groupBoxOutput_KI = new GroupBox();
            textBoxResult = new TextBox();
            labelX = new Label();
            textBoxX = new TextBox();
            buttonExecute = new Button();
            buttonInfo = new Button();

            ((System.ComponentModel.ISupportInitialize)picFormula_KI).BeginInit();
            SuspendLayout();

            groupBoxTask_KI.Controls.Add(picFormula_KI);
            groupBoxTask_KI.Controls.Add(labelTask_KI);
            groupBoxTask_KI.Location = new Point(10, 10);
            groupBoxTask_KI.Size = new Size(500, 130);
            groupBoxTask_KI.Text = "Условие задачи";

            picFormula_KI.ImageLocation = "C:\\Users\\Иван\\source\\repos\\Tyuiu.KazachekI.Sprint6\\img\\task0.png";
            picFormula_KI.Location = new Point(10, 20);
            picFormula_KI.Size = new Size(480, 50);
            picFormula_KI.SizeMode = PictureBoxSizeMode.Zoom;

            labelTask_KI.Location = new Point(10, 80);
            labelTask_KI.Size = new Size(480, 40);
            labelTask_KI.Text = "Вычислить значение функции по формуле при x = 3.";
            labelTask_KI.AutoEllipsis = true;

            groupBoxOutput_KI.Controls.Add(textBoxResult);
            groupBoxOutput_KI.Location = new Point(10, 150);
            groupBoxOutput_KI.Size = new Size(500, 100);
            groupBoxOutput_KI.Text = "Вывод данных";

            textBoxResult.Location = new Point(10, 20);
            textBoxResult.Size = new Size(480, 70);
            textBoxResult.ReadOnly = true;
            textBoxResult.Multiline = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;

            labelX.Location = new Point(10, 260);
            labelX.Size = new Size(100, 27);
            labelX.Text = "Введите x:";

            textBoxX.Location = new Point(110, 257);
            textBoxX.Size = new Size(100, 27);

            buttonExecute.Location = new Point(220, 255);
            buttonExecute.Size = new Size(120, 30);
            buttonExecute.Text = "Выполнить";
            buttonExecute.Click += buttonExecute_Click;

            buttonInfo.Location = new Point(350, 255);
            buttonInfo.Size = new Size(40, 30);
            buttonInfo.Text = "?";
            buttonInfo.Click += buttonInfo_Click;

            ClientSize = new Size(525, 300);
            Controls.Add(groupBoxTask_KI);
            Controls.Add(groupBoxOutput_KI);
            Controls.Add(labelX);
            Controls.Add(textBoxX);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 0 | Казачек И. | Вариант 29";

            ((System.ComponentModel.ISupportInitialize)picFormula_KI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
