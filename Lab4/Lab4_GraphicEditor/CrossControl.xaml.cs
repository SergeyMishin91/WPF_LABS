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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4_GraphicEditor
{

    public partial class CrossControl : UserControl
    {
        public Path Figure
        {
            get { return (this.Content as Viewbox).Child as Path; }
        }

        public CrossControl()
        {
            InitializeComponent();
        }
    }
}
