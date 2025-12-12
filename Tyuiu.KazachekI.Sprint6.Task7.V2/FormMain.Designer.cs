using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task7.V2
{
    partial class FormMain
    {
        private Button buttonLoad;
        private Button buttonProcess;
        private Button buttonSave;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private Label labelIn;
        private Label labelOut;

        private void InitializeComponent()
        {
            this.buttonLoad = new Button();
            this.buttonProcess = new Button();
            this.buttonSave = new Button();
            this.dataGridViewIn = new DataGridView();
            this.dataGridViewOut = new DataGridView();
            this.labelIn = new Label();
            this.labelOut = new Label();

            // buttonLoad
            this.buttonLoad.Text = "Загрузить CSV";
            this.buttonLoad.Location = new System.Drawing.Point(20, 20);
            this.buttonLoad.Size = new System.Drawing.Size(140, 30);
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);

            // buttonProcess
            this.buttonProcess.Text = "Обработать";
            this.buttonProcess.Location = new System.Drawing.Point(180, 20);
            this.buttonProcess.Size = new System.Drawing.Size(120, 30);
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);

            // buttonSave
            this.buttonSave.Text = "Сохранить CSV";
            this.buttonSave.Location = new System.Drawing.Point(320, 20);
            this.buttonSave.Size = new System.Drawing.Size(140, 30);
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // dataGridViewIn
            this.dataGridViewIn.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewIn.Size = new System.Drawing.Size(440, 160);

            // dataGridViewOut
            this.dataGridViewOut.Location = new System.Drawing.Point(20, 280);
            this.dataGridViewOut.Size = new System.Drawing.Size(440, 160);

            // labelIn
            this.labelIn.Text = "Исходная матрица";
            this.labelIn.Location = new System.Drawing.Point(20, 60);

            // labelOut
            this.labelOut.Text = "Результат";
            this.labelOut.Location = new System.Drawing.Point(20, 260);

            // FormMain
            this.ClientSize = new System.Drawing.Size(490, 470);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewIn);
            this.Controls.Add(this.dataGridViewOut);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelOut);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 2 | Казачек И.";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}
