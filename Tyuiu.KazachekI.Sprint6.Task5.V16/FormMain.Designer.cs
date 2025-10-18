using System.Windows.Forms;
using System.Drawing;

namespace Tyuiu.KazachekI.Sprint6.Task5.V16
{
    partial class FormMain
    {
        private Button buttonLoad;
        private DataGridView dataGridViewAll;
        private DataGridView dataGridViewPositive;
        private PictureBox pictureBoxChart;
        private Label labelAll;
        private Label labelPositive;

        private void InitializeComponent()
        {
            this.buttonLoad = new Button();
            this.dataGridViewAll = new DataGridView();
            this.dataGridViewPositive = new DataGridView();
            this.pictureBoxChart = new PictureBox();
            this.labelAll = new Label();
            this.labelPositive = new Label();

            // buttonLoad
            this.buttonLoad.Text = "Загрузить данные";
            this.buttonLoad.Location = new Point(20, 20);
            this.buttonLoad.Size = new Size(160, 30);
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);

            // dataGridViewAll
            this.dataGridViewAll.Location = new Point(20, 80);
            this.dataGridViewAll.Size = new Size(260, 250);
            this.dataGridViewAll.ColumnCount = 1;
            this.dataGridViewAll.Columns[0].HeaderText = "Положительные числа";

            // dataGridViewPositive
            this.dataGridViewPositive.Location = new Point(300, 80);
            this.dataGridViewPositive.Size = new Size(260, 250);
            this.dataGridViewPositive.ColumnCount = 1;
            this.dataGridViewPositive.Columns[0].HeaderText = "Положительные числа";

            // labelAll
            this.labelAll.Location = new Point(20, 60);
            this.labelAll.Text = "Все положительные";

            // labelPositive
            this.labelPositive.Location = new Point(300, 60);
            this.labelPositive.Text = "Положительные";

            // pictureBoxChart
            this.pictureBoxChart.Location = new Point(580, 60);
            this.pictureBoxChart.Size = new Size(400, 270);
            this.pictureBoxChart.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxChart.Paint += new PaintEventHandler(this.pictureBoxChart_Paint);

            // FormMain
            this.ClientSize = new Size(1000, 370);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.dataGridViewPositive);
            this.Controls.Add(this.pictureBoxChart);
            this.Controls.Add(this.labelAll);
            this.Controls.Add(this.labelPositive);
            this.Text = "Спринт #6 | Task 5 | Вариант 16";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}
