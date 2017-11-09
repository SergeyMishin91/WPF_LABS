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
using System.Windows.Threading;

namespace WpfControlLibraryGame
{

    public partial class UserControl1 : UserControl
    {
        public event EventHandler<PositionEventArgs> ClickShip;
        public event EventHandler<PositionEventArgs> ClickTorpedo;
        public event EventHandler<PositionEventArgs> MoveTorpedoAndPeriscope;

        //#region StartPosition
        //private void GetStartPosition()
        //{
        //    gameArea.Children.Add(ship);
        //    gameArea.Children.Add(torpedo);
        //    Canvas.SetTop(ship, 147);
        //    Canvas.SetLeft(ship, 1);
        //    Canvas.SetBottom(torpedo, 1);
        //    Canvas.SetLeft(torpedo, 238);

        //}
        //#endregion

        public UserControl1()
        {
            InitializeComponent();
            dtShip.Interval = new TimeSpan(TimeSpan.TicksPerMillisecond * 10);
            dtShip.Tick += Dt_Tick;
            dtTorpedo.Interval = new TimeSpan(TimeSpan.TicksPerMillisecond * 10);
            dtTorpedo.Tick += DtTorpedo_Tick;

        }

        #region ShipInfo
        Ship shipObj = new Ship();
        double shipSpeed = 0.5;
        double t = 0;
        DispatcherTimer dtShip = new DispatcherTimer();

        private void Dt_Tick(object sender, EventArgs e)
        {
            Canvas.SetLeft(ship, shipObj.X);
            shipObj.X = shipSpeed * t;
            shipObj.Y = Canvas.GetBottom(ship);
            t++;

        }

        public void ProcessKey(Key key)
        {
            if (key == Key.Left)
            {
                kernel.X = Canvas.GetLeft(torpedo);
                kernel.Y = Canvas.GetBottom(torpedo);
                this.OnMoveTorpedo(kernel.X, kernel.Y);

                Canvas.SetLeft(torpedo, kernel.X - 5);
            }

            if (key == Key.Right)
            {
                kernel.X = Canvas.GetRight(torpedo);
                kernel.Y = Canvas.GetBottom(torpedo);
                this.OnMoveTorpedo(kernel.X, kernel.Y);

                Canvas.SetLeft(torpedo, kernel.X + 5);
            }
        }
        #endregion

        #region TorpedoInfo
        Torpedo kernel = new Torpedo();
        double torpedoSpeed = 1;
        //double torpedoSpeedShow;
        double t2 = 0;
        double t3 = 0;
        double speedLower = 0;
        DispatcherTimer dtTorpedo = new DispatcherTimer();

        private void DtTorpedo_Tick(object sender, EventArgs e)
        {
            
            Canvas.SetBottom(torpedo, kernel.Y);
            kernel.X = Canvas.GetLeft(torpedo);
            kernel.Y = torpedoSpeed * t2 - (speedLower * t3);
            
            t2++;
            speedLower += 0.1;
            t3 += 0.001;

            Point currentShipPosition = new Point(shipObj.X, shipObj.Y);
            Point currentTorpedoPosition = new Point(kernel.X, kernel.Y);

            if (kernel.Y > 240)
                gameArea.Children.Remove(torpedo);

            if ((shipObj.X<=kernel.X-4)&&(shipObj.X+65>=kernel.X-4)&&(shipObj.Y<=kernel.Y+10)&&(kernel.Y+10<=shipObj.Y+5))
            {
                gameArea.Children.Remove(ship);
                gameArea.Children.Remove(torpedo);
            }
        }
        #endregion

        #region buttons
        private void btnPush_Click(object sender, RoutedEventArgs e)
        {
            t2 = 0;
            dtTorpedo.Start();   
        }

        private void btnAgain_Click(object sender, RoutedEventArgs e)
        {
            //GetStartPosition();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            t = 0;
            dtShip.Start();
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        #endregion

        private void Torpedo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                kernel.X = Canvas.GetLeft(torpedo);
                kernel.Y = Canvas.GetBottom(torpedo);
                this.OnMoveTorpedo(kernel.X, kernel.Y);
                
                Canvas.SetLeft(torpedo, kernel.X - 5);
            }

            if (e.Key == Key.Right)
            {
                kernel.X = Canvas.GetRight(torpedo);
                kernel.Y = Canvas.GetBottom(torpedo);
                this.OnMoveTorpedo(kernel.X, kernel.Y);

                Canvas.SetLeft(torpedo, kernel.X - 5);
            }

        }

        private void OnMoveTorpedo(double x, double y)
        {
            MoveTorpedoAndPeriscope?.Invoke(this, new PositionEventArgs(x, y));
        }

        private void ship_MouseDown(object sender, MouseButtonEventArgs e)
        {
            shipObj.X = e.GetPosition(this).X;
            shipObj.Y = e.GetPosition(this).Y;
            this.OnClickShip(shipObj.X, shipObj.Y);
        }

        protected virtual void OnClickShip(double x, double y)
        {
            ClickShip?.Invoke(this, new PositionEventArgs(x, y));
        }

        private void torpedo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            kernel.X = e.GetPosition(this).X;
            kernel.Y = e.GetPosition(this).Y;
            this.OnClickTorpedo(kernel.X, kernel.Y);
        }

        protected virtual void OnClickTorpedo(double x, double y)
        {
            ClickTorpedo?.Invoke(this, new PositionEventArgs(x, y));
        }
    }
}
