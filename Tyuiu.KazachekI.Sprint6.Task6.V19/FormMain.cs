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
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt|All Files|*.*";
            ofd.Title = "Âûבונטעו פאיכ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string text = ds.CollectTextFromFile(ofd.FileName);
                textBoxIn.Text = text;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            string input = textBoxIn.Text;
            string output = ds.GetWordsWithL(input);
            textBoxOut.Text = output;
        }
    }
}
