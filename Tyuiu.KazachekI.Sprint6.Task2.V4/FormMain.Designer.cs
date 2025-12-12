using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task2.V4
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBox_Formula_IK;
        private PictureBox pictureBoxFormula_IK;

        private GroupBox groupBox_Table_IK;
        private DataGridView dataGridViewResult_IK;

        private GroupBox groupBox_Chart_IK;
        private PictureBox pictureBoxChart_IK;

        private Button buttonExecute_IK;
        private Button buttonInfo_IK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox_Formula_IK = new GroupBox();
            pictureBoxFormula_IK = new PictureBox();

            groupBox_Table_IK = new GroupBox();
            dataGridViewResult_IK = new DataGridView();

            groupBox_Chart_IK = new GroupBox();
            pictureBoxChart_IK = new PictureBox();

            buttonExecute_IK = new Button();
            buttonInfo_IK = new Button();

            SuspendLayout();

            // === Условие задачи ===
            groupBox_Formula_IK.Text = "Условие задачи";
            groupBox_Formula_IK.Location = new Point(10, 10);
            groupBox_Formula_IK.Size = new Size(480, 240);

            pictureBoxFormula_IK.ImageLocation = @"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint6\img\task2.png";
            pictureBoxFormula_IK.Dock = DockStyle.Fill;
            pictureBoxFormula_IK.SizeMode = PictureBoxSizeMode.Zoom;

            groupBox_Formula_IK.Controls.Add(pictureBoxFormula_IK);

            // === Таблица данных ===
            groupBox_Table_IK.Text = "Таблица значений";
            groupBox_Table_IK.Location = new Point(10, 260);
            groupBox_Table_IK.Size = new Size(480, 320);

            dataGridViewResult_IK.Dock = DockStyle.Fill;
            dataGridViewResult_IK.ReadOnly = true;
            dataGridViewResult_IK.AllowUserToAddRows = false;
            dataGridViewResult_IK.RowHeadersVisible = false;
            dataGridViewResult_IK.ColumnCount = 2;
            dataGridViewResult_IK.Columns[0].Name = "X";
            dataGridViewResult_IK.Columns[1].Name = "f(X)";
            dataGridViewResult_IK.Columns[0].Width = 80;
            dataGridViewResult_IK.Columns[1].Width = 150;

            groupBox_Table_IK.Controls.Add(dataGridViewResult_IK);

            // === График ===
            groupBox_Chart_IK.Text = "График функции";
            groupBox_Chart_IK.Location = new Point(500, 10);
            groupBox_Chart_IK.Size = new Size(780, 570);

            pictureBoxChart_IK.Dock = DockStyle.Fill;
            pictureBoxChart_IK.BackColor = Color.White;
            pictureBoxChart_IK.Paint += pictureBoxChart_IK_Paint;

            groupBox_Chart_IK.Controls.Add(pictureBoxChart_IK);

            // === Кнопки ===
            buttonExecute_IK.Text = "Выполнить";
            buttonExecute_IK.BackColor = Color.LightGreen;
            buttonExecute_IK.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonExecute_IK.Size = new Size(180, 35);
            buttonExecute_IK.Location = new Point(500, 590);
            buttonExecute_IK.Click += buttonExecute_Click;

            buttonInfo_IK.Text = "Справка";
            buttonInfo_IK.BackColor = Color.LightSkyBlue;
            buttonInfo_IK.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonInfo_IK.Size = new Size(180, 35);
            buttonInfo_IK.Location = new Point(700, 590);
            buttonInfo_IK.Click += buttonInfo_Click;

            // === Форма ===
            ClientSize = new Size(1300, 650);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 4 | Казачек И.";

            Controls.Add(groupBox_Formula_IK);
            Controls.Add(groupBox_Table_IK);
            Controls.Add(groupBox_Chart_IK);
            Controls.Add(buttonExecute_IK);
            Controls.Add(buttonInfo_IK);

            ResumeLayout(false);
        }
    }
}
