using System;
using System.Windows.Forms;

namespace SeedGen
{
    class Program
    {
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(args));
        }
    }
}
