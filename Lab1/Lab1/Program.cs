using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls; //библиотека для создания кнопок

namespace ConsoleApplication3
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MainWindow win = new MainWindow() { Width = 400, Height = 220 };
            Application app = new Application();
            app.Run(win);
        }
    }
}

