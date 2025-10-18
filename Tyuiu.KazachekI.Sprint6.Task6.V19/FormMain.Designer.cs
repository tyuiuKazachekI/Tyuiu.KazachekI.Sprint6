using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task6.V19
{
    partial class FormMain
    {
        private Button buttonLoad;
        private Button buttonProcess;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private Label labelIn;
        private Label labelOut;

        private void InitializeComponent()
        {
            this.buttonLoad = new Button();
            this.buttonProcess = new Button();
            this.textBoxIn = new TextBox();
            this.textBoxOut = new TextBox();
            this.labelIn = new Label();
            this.labelOut = new Label();

            // 
            // buttonLoad
            // 
            this.buttonLoad.Text = "Загрузить файл";
            this.buttonLoad.Location = new System.Drawing.Point(20, 20);
            this.buttonLoad.Size = new System.Drawing.Size(120, 30);
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);

            // 
            // buttonProcess
            // 
            this.buttonProcess.Text = "Обработать текст";
            this.buttonProcess.Location = new System.Drawing.Point(160, 20);
            this.buttonProcess.Size = new System.Drawing.Size(140, 30);
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);

            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(20, 80);
            this.textBoxIn.Size = new System.Drawing.Size(400, 120);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.ScrollBars = ScrollBars.Vertical;

            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(20, 230);
            this.textBoxOut.Size = new System.Drawing.Size(400, 120);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.ScrollBars = ScrollBars.Vertical;

            // 
            // labelIn
            // 
            this.labelIn.Text = "Содержимое файла";
            this.labelIn.Location = new System.Drawing.Point(20, 60);

            // 
            // labelOut
            // 
            this.labelOut.Text = "Слова с буквой 'l'";
            this.labelOut.Location = new System.Drawing.Point(20, 210);

            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(460, 370);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelOut);
            this.Text = "Спринт 6 | Таск 6 | Вариант 19 | Казачек И.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}
