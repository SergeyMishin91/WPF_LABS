using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibraryGame
{
    class Ship
    {
        public double ShipSpeed { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double ShipStartPositionX { get; set; }
        public double ShipStartPositionY { get; set; }

        public Ship () { }
        public Ship (double pointX, double pointY)
        {
            pointX = X;
            pointY = Y;
        }

    }
}
