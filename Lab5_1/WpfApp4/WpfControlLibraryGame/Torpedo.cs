using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibraryGame
{
    class Torpedo
    {
        public double TorpedoSpeed { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double TorpedoStartPositionX { get; set; }
        public double TorpedoStartPositionY { get; set; }

        public Torpedo() { }
        public Torpedo(double pointX, double pointY)
        {
            pointX = X;
            pointY = Y;
        }

    }
}
