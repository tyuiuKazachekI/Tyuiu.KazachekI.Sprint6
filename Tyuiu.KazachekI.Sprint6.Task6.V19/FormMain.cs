using System;
using System.Windows.Forms;
using Tyuiu.KazachekI.Sprint6.Task6.V19.Lib;

namespace Tyuiu.KazachekI.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {
        private DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxIn.Text = System.IO.File.ReadAllText(ofd.FileName);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIn.Text)) return;

            string tempPath = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllText(tempPath, textBoxIn.Text);

            string result = ds.CollectTextFromFile(tempPath);
            textBoxOut.Text = result;
        }
    }
}
