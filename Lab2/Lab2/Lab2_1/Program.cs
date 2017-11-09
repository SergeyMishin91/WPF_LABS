using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lab2_1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MainWindow win = new MainWindow () {Title = "Function calculate", Width = 500, Height = 400 };
            Application app = new Application();
            app.Run(win);
        }
    }
}
