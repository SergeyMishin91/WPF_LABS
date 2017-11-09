//3-ий вариант

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ConsoleApplication3
{
    internal class MainWindow : Window
    {
        private double result;

        double senseX { get; set; }
        double senseY { get; set; }
        double senseZ { get; set; }

        Canvas canvas = new Canvas();

        Button getResult = new Button() { Content = "Получить результат", Width = 130, Height = 20 };
        Button clear = new Button() { Content = "Очистить поля", Width = 150, Height = 20 };

        Label enterX = new Label() { Content = "x = " };
        Label enterY = new Label() { Content = "y = " };
        Label enterZ = new Label() { Content = "z = " };

        TextBox textBoxShowX = new TextBox() { Width = 100, Height = 20 };
        TextBox textBoxShowY = new TextBox() { Width = 100, Height = 20 };
        TextBox textBoxShowZ = new TextBox() { Width = 100, Height = 20 };
        TextBox textBoxShowResult = new TextBox() { Width = 100, Height = 20 };

        public MainWindow()
        {
            this.Content = canvas;

            #region showing textbox sense показать значения 
            canvas.Children.Add(textBoxShowX);
            Canvas.SetTop(textBoxShowX, 3);
            Canvas.SetLeft(textBoxShowX, 100);

            canvas.Children.Add(textBoxShowY);
            Canvas.SetTop(textBoxShowY, 33);
            Canvas.SetLeft(textBoxShowY, 100);

            canvas.Children.Add(textBoxShowZ);
            Canvas.SetTop(textBoxShowZ, 63);
            Canvas.SetLeft(textBoxShowZ, 100);

            canvas.Children.Add(textBoxShowResult);
            Canvas.SetTop(textBoxShowResult, 93);
            Canvas.SetLeft(textBoxShowResult, 200);
            #endregion

            #region showing lables sense
            canvas.Children.Add(enterX);
            Canvas.SetTop(enterX, 0);
            Canvas.SetLeft(enterX, 70);

            canvas.Children.Add(enterY);
            Canvas.SetTop(enterY, 28);
            Canvas.SetLeft(enterY, 70);

            canvas.Children.Add(enterZ);
            Canvas.SetTop(enterZ, 58);
            Canvas.SetLeft(enterZ, 70);
            #endregion

            canvas.Children.Add(getResult);
            Canvas.SetTop(getResult, 93);
            Canvas.SetLeft(getResult, 30);

            canvas.Children.Add(clear);
            Canvas.SetTop(clear, 133);
            Canvas.SetLeft(clear, 60);

            getResult.Click += GetResult_Click;
            clear.Click += Clear_Click;
        }

        private void GetResult_Click(object sender, RoutedEventArgs e)
        {

            senseX = Convert.ToDouble(textBoxShowX.Text);
            senseY = Convert.ToDouble(textBoxShowY.Text);
            senseZ = Convert.ToDouble(textBoxShowZ.Text);

            result = FunctionResult(senseX, senseY, senseZ);
            textBoxShowResult.Text = Convert.ToString(result);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            senseX = 0;
            senseY = 0;
            senseZ = 0;
            result = 0;

            textBoxShowX.Text = Convert.ToString(null);
            textBoxShowY.Text = Convert.ToString(null);
            textBoxShowZ.Text = Convert.ToString(null);
            textBoxShowResult.Text = Convert.ToString(null);
        }

        private double FunctionResult(double x, double y, double z)
        {
            double funcResult;
            funcResult = ((1 + Math.Pow(Math.Sin(x + y), 2)) / Math.Abs(x - (2 * y / 1 + (Math.Pow(x, 2) * Math.Pow(y, 2))))) * Math.Pow(x, Math.Abs(y)) +
              Math.Pow((Math.Cos(Math.Atan(1/z))), 2);           
            return funcResult;
        }
    }
}