using System;
using System.Windows.Forms;

namespace Tyuiu.KazachekI.Sprint6.Task0.V29
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
