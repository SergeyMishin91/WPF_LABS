using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //uc1Game.ClickShip += Uc1Game_ClickShip;
            //uc1Game.ClickTorpedo += uc1Game_ClickTorpedo;
            //uc1Game.MoveTorpedoAndPeriscope += Uc1Game_MoveTorpedoAndPeriscope;


            //uc1Game.ClickShip += (s, e) => { Title = e.X.ToString(); };
        }

        private void Uc1Game_MoveTorpedoAndPeriscope(object sender, WpfControlLibraryGame.PositionEventArgs e)
        {
            //
            string x = Convert.ToString(e.X);
            MessageBox.Show("Torpedo left position = " + x);
        }

        private void Uc1Game_ClickShip(object sender, WpfControlLibraryGame.PositionEventArgs e)
        {
            string x = Convert.ToString(e.X);
            string y = Convert.ToString(e.Y);
            MessageBox.Show("Ship position are: x = " + x + " y = " + y);
        }

        private void uc1Game_ClickTorpedo(object sender, WpfControlLibraryGame.PositionEventArgs e)
        {
            string x = Convert.ToString(e.X);
            string y = Convert.ToString(e.Y);
            MessageBox.Show("Torpedo position are: x = " + x + " y = " + y);
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            uc1Game.ProcessKey(e.Key);
        }
    }
}
