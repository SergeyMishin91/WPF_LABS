using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab4_GraphicEditor
{
    /// <summary>
    /// Interaction logic for BlackSquare.xaml
    /// </summary>
    public partial class BlackSquare : UserControl
    {
        public Rectangle Square
        {
            get { return (this.Content as Viewbox).Child as Rectangle; }
        }

        public BlackSquare()
        {
            InitializeComponent();
        }
    }
}
