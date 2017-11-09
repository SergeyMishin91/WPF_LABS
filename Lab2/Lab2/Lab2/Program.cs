using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lab2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MainWindow win = new MainWindow() {Title="WPF Calculator", Width = 280, Height = 450 };
            Application app = new Application();
            app.Run(win);
        }
    }
}
