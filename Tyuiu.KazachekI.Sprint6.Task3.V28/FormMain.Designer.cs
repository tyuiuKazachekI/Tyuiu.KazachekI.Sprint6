using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task3.V28
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBoxTask_IK;
        private TextBox textBoxTask_IK;
        private GroupBox groupBoxResult_IK;
        private DataGridView dataGridViewResult;
        private Button buttonReplace;
        private Button buttonInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxTask_IK = new GroupBox();
            textBoxTask_IK = new TextBox();
            groupBoxResult_IK = new GroupBox();
            dataGridViewResult = new DataGridView();
            buttonReplace = new Button();
            buttonInfo = new Button();
            groupBoxTask_IK.SuspendLayout();
            groupBoxResult_IK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_IK
            // 
            groupBoxTask_IK.Controls.Add(textBoxTask_IK);
            groupBoxTask_IK.Location = new Point(20, 20);
            groupBoxTask_IK.Name = "groupBoxTask_IK";
            groupBoxTask_IK.Size = new Size(550, 120);
            groupBoxTask_IK.TabIndex = 0;
            groupBoxTask_IK.TabStop = false;
            groupBoxTask_IK.Text = "Условие задачи";
            // 
            // textBoxTask_IK
            // 
            textBoxTask_IK.Dock = DockStyle.Fill;
            textBoxTask_IK.Location = new Point(3, 23);
            textBoxTask_IK.Multiline = true;
            textBoxTask_IK.Name = "textBoxTask_IK";
            textBoxTask_IK.ReadOnly = true;
            textBoxTask_IK.ScrollBars = ScrollBars.Vertical;
            textBoxTask_IK.Size = new Size(544, 94);
            textBoxTask_IK.TabIndex = 0;
            textBoxTask_IK.Text = "Дан массив 5 на 5 элементов.\r\nЗаменить четные значения в четвертой строке на 0.\r\nРезультат вывести в DataGridView.";
            // 
            // groupBoxResult_IK
            // 
            groupBoxResult_IK.Controls.Add(dataGridViewResult);
            groupBoxResult_IK.Location = new Point(20, 160);
            groupBoxResult_IK.Name = "groupBoxResult_IK";
            groupBoxResult_IK.Size = new Size(550, 300);
            groupBoxResult_IK.TabIndex = 1;
            groupBoxResult_IK.TabStop = false;
            groupBoxResult_IK.Text = "Таблица результата";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.ColumnHeadersHeight = 29;
            dataGridViewResult.Dock = DockStyle.Fill;
            dataGridViewResult.Location = new Point(3, 23);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(544, 274);
            dataGridViewResult.TabIndex = 0;
            // 
            // buttonReplace
            // 
            buttonReplace.BackColor = Color.LightGreen;
            buttonReplace.Font = new Font("Arial", 11F, FontStyle.Bold);
            buttonReplace.Location = new Point(23, 480);
            buttonReplace.Name = "buttonReplace";
            buttonReplace.Size = new Size(140, 35);
            buttonReplace.TabIndex = 2;
            buttonReplace.Text = "Заменить";
            buttonReplace.UseVisualStyleBackColor = false;
            buttonReplace.Click += buttonReplace_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.LightSkyBlue;
            buttonInfo.Font = new Font("Arial", 11F, FontStyle.Bold);
            buttonInfo.Location = new Point(430, 480);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(140, 35);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(600, 540);
            Controls.Add(groupBoxTask_IK);
            Controls.Add(groupBoxResult_IK);
            Controls.Add(buttonReplace);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 28 | Казачек И.";
            groupBoxTask_IK.ResumeLayout(false);
            groupBoxTask_IK.PerformLayout();
            groupBoxResult_IK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }
    }
}
