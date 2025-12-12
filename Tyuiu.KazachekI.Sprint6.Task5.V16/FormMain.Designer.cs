using System.Windows.Forms;
using System.Drawing;

namespace Tyuiu.KazachekI.Sprint6.Task5.V16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask_KI;
        private Label labelTask_KI;
        private TableLayoutPanel mainLayout_KI;
        private GroupBox groupBoxFile_KI;
        private DataGridView dataGridViewValues_KI;
        private PictureBox pictureBoxChart_KI;
        private FlowLayoutPanel panelButtons_KI;
        private Button buttonExecute_KI;
        private Button buttonOpen_KI;
        private Button buttonInfo_KI;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxTask_KI = new GroupBox();
            labelTask_KI = new Label();
            mainLayout_KI = new TableLayoutPanel();
            groupBoxFile_KI = new GroupBox();
            dataGridViewValues_KI = new DataGridView();
            pictureBoxChart_KI = new PictureBox();
            panelButtons_KI = new FlowLayoutPanel();
            buttonExecute_KI = new Button();
            buttonOpen_KI = new Button();
            buttonInfo_KI = new Button();

            groupBoxTask_KI.SuspendLayout();
            mainLayout_KI.SuspendLayout();
            groupBoxFile_KI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewValues_KI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart_KI).BeginInit();
            panelButtons_KI.SuspendLayout();
            SuspendLayout();

            // 
            // groupBoxTask_KI
            // 
            groupBoxTask_KI.Controls.Add(labelTask_KI);
            groupBoxTask_KI.Dock = DockStyle.Top;
            groupBoxTask_KI.Location = new Point(0, 0);
            groupBoxTask_KI.Name = "groupBoxTask_KI";
            groupBoxTask_KI.Size = new Size(1553, 120);
            groupBoxTask_KI.TabIndex = 2;
            groupBoxTask_KI.TabStop = false;
            groupBoxTask_KI.Text = "Условие задачи";

            // 
            // labelTask_KI
            // 
            labelTask_KI.Dock = DockStyle.Fill;
            labelTask_KI.Location = new Point(3, 23);
            labelTask_KI.Name = "labelTask_KI";
            labelTask_KI.Padding = new Padding(10);
            labelTask_KI.Size = new Size(1547, 94);
            labelTask_KI.TabIndex = 0;
            labelTask_KI.Text =
                "Прочитать данные из файла InPutDataFileTask5V16.txt.\n" +
                "Вывести все числа и отдельно положительные (> 0). Построить диаграмму по положительным числам.\n" +
                "Вещественные значения округлить до 3 знаков.";
            labelTask_KI.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // mainLayout_KI
            // 
            mainLayout_KI.ColumnCount = 2;
            mainLayout_KI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout_KI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout_KI.Controls.Add(groupBoxFile_KI, 0, 0);
            mainLayout_KI.Controls.Add(pictureBoxChart_KI, 1, 0);
            mainLayout_KI.Dock = DockStyle.Fill;
            mainLayout_KI.Location = new Point(0, 170);
            mainLayout_KI.Name = "mainLayout_KI";
            mainLayout_KI.RowCount = 1;
            mainLayout_KI.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout_KI.Size = new Size(1553, 430);
            mainLayout_KI.TabIndex = 0;

            // 
            // groupBoxFile_KI
            // 
            groupBoxFile_KI.Controls.Add(dataGridViewValues_KI);
            groupBoxFile_KI.Dock = DockStyle.Fill;
            groupBoxFile_KI.Location = new Point(3, 3);
            groupBoxFile_KI.Name = "groupBoxFile_KI";
            groupBoxFile_KI.Size = new Size(770, 424);
            groupBoxFile_KI.TabIndex = 0;
            groupBoxFile_KI.TabStop = false;
            groupBoxFile_KI.Text = "Содержимое файла";

            // 
            // dataGridViewValues_KI
            // 
            dataGridViewValues_KI.AllowUserToAddRows = false;
            dataGridViewValues_KI.ColumnHeadersHeight = 29;
            dataGridViewValues_KI.Dock = DockStyle.Fill;
            dataGridViewValues_KI.Location = new Point(3, 23);
            dataGridViewValues_KI.Name = "dataGridViewValues_KI";
            dataGridViewValues_KI.ReadOnly = true;
            dataGridViewValues_KI.RowHeadersVisible = false;
            dataGridViewValues_KI.RowHeadersWidth = 51;
            dataGridViewValues_KI.Size = new Size(764, 398);
            dataGridViewValues_KI.TabIndex = 0;

            // 
            // pictureBoxChart_KI
            // 
            pictureBoxChart_KI.BackColor = Color.White;
            pictureBoxChart_KI.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxChart_KI.Dock = DockStyle.Fill;
            pictureBoxChart_KI.Location = new Point(779, 3);
            pictureBoxChart_KI.Name = "pictureBoxChart_KI";
            pictureBoxChart_KI.Size = new Size(771, 424);
            pictureBoxChart_KI.TabIndex = 1;
            pictureBoxChart_KI.TabStop = false;
            pictureBoxChart_KI.Paint += pictureBoxChart_KI_Paint;

            // 
            // panelButtons_KI
            // 
            panelButtons_KI.Controls.Add(buttonExecute_KI);
            panelButtons_KI.Controls.Add(buttonOpen_KI);
            panelButtons_KI.Controls.Add(buttonInfo_KI);
            panelButtons_KI.Dock = DockStyle.Top;
            panelButtons_KI.Location = new Point(0, 120);
            panelButtons_KI.Name = "panelButtons_KI";
            panelButtons_KI.Padding = new Padding(10);
            panelButtons_KI.Size = new Size(1553, 50);
            panelButtons_KI.TabIndex = 1;

            // 
            // buttonExecute_KI
            // 
            buttonExecute_KI.BackColor = Color.LightGreen;
            buttonExecute_KI.FlatStyle = FlatStyle.Flat;
            buttonExecute_KI.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonExecute_KI.Location = new Point(13, 13);
            buttonExecute_KI.Name = "buttonExecute_KI";
            buttonExecute_KI.Size = new Size(120, 35);
            buttonExecute_KI.TabIndex = 0;
            buttonExecute_KI.Text = "Выполнить";
            buttonExecute_KI.UseVisualStyleBackColor = false;
            buttonExecute_KI.Click += buttonExecute_KI_Click;

            // 
            // buttonOpen_KI
            // 
            buttonOpen_KI.BackColor = Color.LightBlue;
            buttonOpen_KI.FlatStyle = FlatStyle.Flat;
            buttonOpen_KI.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonOpen_KI.Location = new Point(139, 13);
            buttonOpen_KI.Name = "buttonOpen_KI";
            buttonOpen_KI.Size = new Size(120, 35);
            buttonOpen_KI.TabIndex = 1;
            buttonOpen_KI.Text = "Открыть";
            buttonOpen_KI.UseVisualStyleBackColor = false;
            buttonOpen_KI.Click += buttonOpen_KI_Click;

            // 
            // buttonInfo_KI
            // 
            buttonInfo_KI.BackColor = Color.DeepSkyBlue;
            buttonInfo_KI.FlatStyle = FlatStyle.Flat;
            buttonInfo_KI.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonInfo_KI.Location = new Point(265, 13);
            buttonInfo_KI.Name = "buttonInfo_KI";
            buttonInfo_KI.Size = new Size(120, 35);
            buttonInfo_KI.TabIndex = 2;
            buttonInfo_KI.Text = "Справка";
            buttonInfo_KI.UseVisualStyleBackColor = false;
            buttonInfo_KI.Click += buttonInfo_KI_Click;

            // 
            // FormMain
            // 
            ClientSize = new Size(1553, 600);
            Controls.Add(mainLayout_KI);
            Controls.Add(panelButtons_KI);
            Controls.Add(groupBoxTask_KI);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 16 | Казачек И.";

            groupBoxTask_KI.ResumeLayout(false);
            mainLayout_KI.ResumeLayout(false);
            groupBoxFile_KI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewValues_KI).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart_KI).EndInit();
            panelButtons_KI.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
