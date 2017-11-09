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
using System.Reflection;

namespace Lab4_GraphicEditor
{

    public partial class SettingsWindow : Window
    {
        private double _lineThickness = 0;

        public double LineThickness
        {
            get { return _lineThickness; }
            set { _lineThickness = value; }
        }

        public Brush BackgroundColor
        {
            get { return (Brush)(cmbBackgroundColor.SelectedItem as PropertyInfo).GetValue(null, null); }
        }

        public Brush LineColor
        {
            get { return (Brush)(cmbLineColor.SelectedItem as PropertyInfo).GetValue(null, null); }
        }

        public SettingsWindow()
        {
            InitializeComponent();
        }

        public SettingsWindow(double lineThickness, Brush backgroundColor, Brush lineColor)
        {
            InitializeComponent();
            _lineThickness = lineThickness;
            txtLineThickness.Text = lineThickness.ToString();
            foreach (PropertyInfo propertyInfo in cmbBackgroundColor.Items)
            {
                Brush brush = (Brush)propertyInfo.GetValue(null, null);
                if (brush == backgroundColor)
                    cmbBackgroundColor.SelectedItem = propertyInfo;
                if (brush == lineColor)
                    cmbLineColor.SelectedItem = propertyInfo;
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation.GetHasError(txtLineThickness))
                this.DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
