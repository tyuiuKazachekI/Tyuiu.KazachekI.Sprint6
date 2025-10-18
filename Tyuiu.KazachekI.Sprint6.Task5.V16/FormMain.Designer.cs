using System.Windows.Forms;

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

            // 
            // buttonLoad
            // 
            this.buttonLoad.Text = "Загрузить данные";
            this.buttonLoad.Location = new System.Drawing.Point(20, 20);
            this.buttonLoad.Size = new System.Drawing.Size(160, 30);
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);

            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewAll.Size = new System.Drawing.Size(260, 250);
            this.dataGridViewAll.ColumnCount = 1;
            this.dataGridViewAll.Columns[0].HeaderText = "Все числа";
            this.dataGridViewAll.RowHeadersVisible = false;
            this.dataGridViewAll.AllowUserToAddRows = false;

            // 
            // dataGridViewPositive
            // 
            this.dataGridViewPositive.Location = new System.Drawing.Point(300, 80);
            this.dataGridViewPositive.Size = new System.Drawing.Size(260, 250);
            this.dataGridViewPositive.ColumnCount = 1;
            this.dataGridViewPositive.Columns[0].HeaderText = "Положительные";
            this.dataGridViewPositive.RowHeadersVisible = false;
            this.dataGridViewPositive.AllowUserToAddRows = false;

            // 
            // labelAll
            // 
            this.labelAll.Location = new System.Drawing.Point(20, 60);
            this.labelAll.Text = "Все значения:";

            // 
            // labelPositive
            // 
            this.labelPositive.Location = new System.Drawing.Point(300, 60);
            this.labelPositive.Text = "Положительные значения:";

            // 
            // pictureBoxChart
            // 
            this.pictureBoxChart.Location = new System.Drawing.Point(580, 60);
            this.pictureBoxChart.Size = new System.Drawing.Size(400, 270);
            this.pictureBoxChart.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxChart.Paint += new PaintEventHandler(this.pictureBoxChart_Paint);

            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(1000, 370);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.dataGridViewPositive);
            this.Controls.Add(this.pictureBoxChart);
            this.Controls.Add(this.labelAll);
            this.Controls.Add(this.labelPositive);
            this.Text = "Спринт #6 | Task 5 | Вариант 16 | Казачек И.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}
