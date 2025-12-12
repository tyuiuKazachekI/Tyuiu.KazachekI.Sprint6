namespace Tyuiu.KazachekI.Sprint6.Task2.V4
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox pictureBoxFormula_IK;
        private PictureBox pictureBoxChart_IK;
        private DataGridView dataGridViewResult_IK;
        private Button buttonExecute_IK;
        private Button buttonInfo_IK;

        private DataGridViewTextBoxColumn ColumnX_IK;
        private DataGridViewTextBoxColumn ColumnFX_IK;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxFormula_IK = new PictureBox();
            this.pictureBoxChart_IK = new PictureBox();
            this.dataGridViewResult_IK = new DataGridView();
            this.buttonExecute_IK = new Button();
            this.buttonInfo_IK = new Button();
            this.ColumnX_IK = new DataGridViewTextBoxColumn();
            this.ColumnFX_IK = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_IK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart_IK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IK)).BeginInit();

            this.SuspendLayout();

            // 
            // pictureBoxFormula_IK
            // 
            this.pictureBoxFormula_IK.ImageLocation = "C:\\Users\\Иван\\source\\repos\\Tyuiu.KazachekI.Sprint6\\img\\task2.png";
            this.pictureBoxFormula_IK.Location = new Point(10, 10);
            this.pictureBoxFormula_IK.Name = "pictureBoxFormula_IK";
            this.pictureBoxFormula_IK.Size = new Size(500, 60);
            this.pictureBoxFormula_IK.SizeMode = PictureBoxSizeMode.Zoom;

            // 
            // pictureBoxChart_IK
            // 
            this.pictureBoxChart_IK.Location = new Point(10, 80);
            this.pictureBoxChart_IK.Name = "pictureBoxChart_IK";
            this.pictureBoxChart_IK.Size = new Size(500, 300);
            this.pictureBoxChart_IK.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxChart_IK.Paint += new PaintEventHandler(this.pictureBoxChart_IK_Paint);

            // 
            // dataGridViewResult_IK
            // 
            this.dataGridViewResult_IK.Location = new Point(520, 10);
            this.dataGridViewResult_IK.Name = "dataGridViewResult_IK";
            this.dataGridViewResult_IK.Size = new Size(200, 370);
            this.dataGridViewResult_IK.RowHeadersVisible = false;
            this.dataGridViewResult_IK.AllowUserToAddRows = false;
            this.dataGridViewResult_IK.AllowUserToDeleteRows = false;
            this.dataGridViewResult_IK.Columns.AddRange(new DataGridViewColumn[]
            {
                this.ColumnX_IK,
                this.ColumnFX_IK
            });

            // 
            // ColumnX_IK
            // 
            this.ColumnX_IK.HeaderText = "X";
            this.ColumnX_IK.Width = 50;

            // 
            // ColumnFX_IK
            // 
            this.ColumnFX_IK.HeaderText = "f(x)";
            this.ColumnFX_IK.Width = 120;

            // 
            // buttonExecute_IK
            // 
            this.buttonExecute_IK.Location = new Point(10, 390);
            this.buttonExecute_IK.Name = "buttonExecute_IK";
            this.buttonExecute_IK.Size = new Size(120, 30);
            this.buttonExecute_IK.Text = "Выполнить";
            this.buttonExecute_IK.Click += new EventHandler(this.buttonExecute_Click);

            // 
            // buttonInfo_IK
            // 
            this.buttonInfo_IK.Location = new Point(150, 390);
            this.buttonInfo_IK.Name = "buttonInfo_IK";
            this.buttonInfo_IK.Size = new Size(30, 30);
            this.buttonInfo_IK.Text = "?";
            this.buttonInfo_IK.Click += new EventHandler(this.buttonInfo_Click);

            // 
            // FormMain
            // 
            this.ClientSize = new Size(740, 430);
            this.Controls.Add(this.pictureBoxFormula_IK);
            this.Controls.Add(this.pictureBoxChart_IK);
            this.Controls.Add(this.dataGridViewResult_IK);
            this.Controls.Add(this.buttonExecute_IK);
            this.Controls.Add(this.buttonInfo_IK);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Казачек И. | Вариант 4";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_IK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChart_IK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_IK)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
