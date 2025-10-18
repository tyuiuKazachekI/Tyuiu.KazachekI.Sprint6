using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task4.V14
{
    partial class FormMain
    {
        private PictureBox pictureBoxCondition;
        private TextBox textBoxResult;
        private Button buttonCalc;

        private void InitializeComponent()
        {
            pictureBoxCondition = new PictureBox();
            textBoxResult = new TextBox();
            buttonCalc = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.ImageLocation = "C:\\Users\\Иван\\source\\repos\\Tyuiu.KazachekI.Sprint6\\img\\task4.png";
            pictureBoxCondition.Location = new Point(20, 20);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(400, 80);
            pictureBoxCondition.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCondition.TabIndex = 0;
            pictureBoxCondition.TabStop = false;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(20, 120);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(400, 150);
            textBoxResult.TabIndex = 1;
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(20, 280);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(100, 30);
            buttonCalc.TabIndex = 2;
            buttonCalc.Text = "Вычислить";
            buttonCalc.Click += buttonCalc_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(450, 330);
            Controls.Add(pictureBoxCondition);
            Controls.Add(textBoxResult);
            Controls.Add(buttonCalc);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 4 | Вариант 14";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
