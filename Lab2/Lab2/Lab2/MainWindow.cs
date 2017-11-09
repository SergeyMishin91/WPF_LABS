using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Lab2
{
    internal class MainWindow : Window
    {
        private static int buttonWidth = 50;
        private static int buttonHeight = 50;

        private bool isCalculated = false;

        Canvas canvas = new Canvas();

        TextBox textBoxScreen = new TextBox() { Width = 230, Height = 40 };

        private const int rbMargin = 10;
        private const int windowWidth = 276;
        private const int windowHeight = 350;

        private RadioButton rbDegrees = new RadioButton() { Content = "Градусы", Margin = new Thickness(rbMargin), IsChecked = true };
        private RadioButton rbRadians = new RadioButton() { Content = "Радианы", Margin = new Thickness(95, rbMargin, 0, rbMargin) };
        private RadioButton rbGrads = new RadioButton() { Content = "Грады", Margin = new Thickness(175, rbMargin, 0, rbMargin) };

        #region Buttons in first line кнопки первого ряда
        Button buttonSqrt = new Button { Content = "Sqrt", Width = buttonWidth, Height = buttonHeight };
        Button buttonSin = new Button { Content = "Sin", Width = buttonWidth, Height = buttonHeight };
        Button buttonCos = new Button { Content = "Cos", Width = buttonWidth, Height = buttonHeight };
        Button buttonTg = new Button { Content = "Tg", Width = buttonWidth, Height = buttonHeight };
        #endregion

        #region Buttons in second line кнопки второго ряда
        Button buttonCE = new Button { Content = "CE", Width = buttonWidth, Height = buttonHeight };
        Button buttonOFF = new Button { Content = "OFF", Width = buttonWidth, Height = buttonHeight };
        Button buttonDelete = new Button { Content = "Del", Width = buttonWidth, Height = buttonHeight };
        Button buttonDivide = new Button { Content = "/", Width = buttonWidth, Height = buttonHeight };
        #endregion

        #region Buttons in third line кнопки третьего ряда
        Button buttonSeven = new Button { Content = "7", Width = buttonWidth, Height = buttonHeight };
        Button buttonEight = new Button { Content = "8", Width = buttonWidth, Height = buttonHeight };
        Button buttonNine = new Button { Content = "9", Width = buttonWidth, Height = buttonHeight };
        Button buttonMultiplicate = new Button { Content = "*", Width = buttonWidth, Height = buttonHeight };
        #endregion

        #region Buttons in fourth line кнопки четвертого ряда
        Button buttonFour = new Button { Content = "4", Width = buttonWidth, Height = buttonHeight };
        Button buttonFive = new Button { Content = "5", Width = buttonWidth, Height = buttonHeight };
        Button buttonSix = new Button { Content = "6", Width = buttonWidth, Height = buttonHeight };
        Button buttonMinus = new Button { Content = "-", Width = buttonWidth, Height = buttonHeight };
        #endregion

        #region Buttons in fifth line кнопки пятого ряда
        Button buttonOne = new Button { Content = "1", Width = buttonWidth, Height = buttonHeight };
        Button buttonTwo = new Button { Content = "2", Width = buttonWidth, Height = buttonHeight };
        Button buttonThree = new Button { Content = "3", Width = buttonWidth, Height = buttonHeight };
        Button buttonPlus = new Button { Content = "+", Width = buttonWidth, Height = buttonHeight };
        #endregion

        #region Buttons in sixth line кнопки шестого ряда
        Button buttonPlusMinus = new Button { Content = "+/-", Width = buttonWidth, Height = buttonHeight };
        Button buttonZero = new Button { Content = "0", Width = buttonWidth, Height = buttonHeight };
        Button buttonPoint = new Button { Content = ",", Width = buttonWidth, Height = buttonHeight };
        Button buttonResult = new Button { Content = "=", Width = buttonWidth, Height = buttonHeight };
        #endregion

        public MainWindow()
        {
            this.Content = canvas;

            #region show textbox screen Экран калькулятора
            canvas.Children.Add(textBoxScreen);
            Canvas.SetTop(textBoxScreen, 3);
            Canvas.SetLeft(textBoxScreen, 15);
            #endregion

            #region show buttons in first line
            canvas.Children.Add(buttonSqrt);
            Canvas.SetTop(buttonSqrt, 70);
            Canvas.SetLeft(buttonSqrt, 15);

            canvas.Children.Add(buttonSin);
            Canvas.SetTop(buttonSin, 70);
            Canvas.SetLeft(buttonSin, 75);

            canvas.Children.Add(buttonCos);
            Canvas.SetTop(buttonCos, 70);
            Canvas.SetLeft(buttonCos, 135);

            canvas.Children.Add(buttonTg);
            Canvas.SetTop(buttonTg, 70);
            Canvas.SetLeft(buttonTg, 195);
            #endregion

            #region show buttons in second line
            canvas.Children.Add(buttonCE);
            Canvas.SetTop(buttonCE, 125);
            Canvas.SetLeft(buttonCE, 15);

            canvas.Children.Add(buttonOFF);
            Canvas.SetTop(buttonOFF, 125);
            Canvas.SetLeft(buttonOFF, 75);

            canvas.Children.Add(buttonDelete);
            Canvas.SetTop(buttonDelete, 125);
            Canvas.SetLeft(buttonDelete, 135);

            canvas.Children.Add(buttonDivide);
            Canvas.SetTop(buttonDivide, 125);
            Canvas.SetLeft(buttonDivide, 195);
            #endregion

            #region show buttons in third line
            canvas.Children.Add(buttonSeven);
            Canvas.SetTop(buttonSeven, 180);
            Canvas.SetLeft(buttonSeven, 15);

            canvas.Children.Add(buttonEight);
            Canvas.SetTop(buttonEight, 180);
            Canvas.SetLeft(buttonEight, 75);

            canvas.Children.Add(buttonNine);
            Canvas.SetTop(buttonNine, 180);
            Canvas.SetLeft(buttonNine, 135);

            canvas.Children.Add(buttonMultiplicate);
            Canvas.SetTop(buttonMultiplicate, 180);
            Canvas.SetLeft(buttonMultiplicate, 195);
            #endregion

            #region show buttons in fourth line
            canvas.Children.Add(buttonFour);
            Canvas.SetTop(buttonFour, 235);
            Canvas.SetLeft(buttonFour, 15);

            canvas.Children.Add(buttonFive);
            Canvas.SetTop(buttonFive, 235);
            Canvas.SetLeft(buttonFive, 75);

            canvas.Children.Add(buttonSix);
            Canvas.SetTop(buttonSix, 235);
            Canvas.SetLeft(buttonSix, 135);

            canvas.Children.Add(buttonMinus);
            Canvas.SetTop(buttonMinus, 235);
            Canvas.SetLeft(buttonMinus, 195);
            #endregion

            #region show buttons in fifth line
            canvas.Children.Add(buttonOne);
            Canvas.SetTop(buttonOne, 290);
            Canvas.SetLeft(buttonOne, 15);

            canvas.Children.Add(buttonTwo);
            Canvas.SetTop(buttonTwo, 290);
            Canvas.SetLeft(buttonTwo, 75);

            canvas.Children.Add(buttonThree);
            Canvas.SetTop(buttonThree, 290);
            Canvas.SetLeft(buttonThree, 135);

            canvas.Children.Add(buttonPlus);
            Canvas.SetTop(buttonPlus, 290);
            Canvas.SetLeft(buttonPlus, 195);
            #endregion

            #region show buttons in sixth line
            canvas.Children.Add(buttonPlusMinus);
            Canvas.SetTop(buttonPlusMinus, 345);
            Canvas.SetLeft(buttonPlusMinus, 15);

            canvas.Children.Add(buttonZero);
            Canvas.SetTop(buttonZero, 345);
            Canvas.SetLeft(buttonZero, 75);

            canvas.Children.Add(buttonPoint);
            Canvas.SetTop(buttonPoint, 345);
            Canvas.SetLeft(buttonPoint, 135);

            canvas.Children.Add(buttonResult);
            Canvas.SetTop(buttonResult, 345);
            Canvas.SetLeft(buttonResult, 195);
            #endregion

            canvas.Children.Add(rbDegrees);
            Canvas.SetTop(rbDegrees, 40);
            Canvas.SetLeft(rbDegrees, 10);

            canvas.Children.Add(rbRadians);
            Canvas.SetTop(rbRadians, 40);
            Canvas.SetLeft(rbRadians, 5);

            canvas.Children.Add(rbGrads);
            Canvas.SetTop(rbGrads, 40);
            Canvas.SetLeft(rbGrads, 5);

            #region show buttons action
            buttonCE.Click += ButtonCE_Click;
            buttonOFF.Click += ButtonOFF_Click;
            buttonResult.Click += ButtonResult_Click;
            buttonDelete.Click += ButtonDelete_Click;

            Button[] masButtonsNumbers = new Button[] { buttonZero, buttonOne, buttonTwo, buttonThree,
                buttonFour, buttonFive, buttonSix, buttonSeven, buttonEight, buttonNine, buttonMinus, buttonMultiplicate,
            buttonPlus, buttonDivide, buttonPoint};

            foreach (Button btn in masButtonsNumbers)
            {
                btn.Click += Button_Click_NumberAndAction;
            }

            buttonSqrt.Click += ButtonSqrt_Click;
            buttonSin.Click += ButtonSin_Click;
            buttonCos.Click += ButtonCos_Click;
            buttonTg.Click += ButtonTg_Click;
            buttonPlusMinus.Click += ButtonPlusMinus_Click;
            rbDegrees.Click += RbDegrees_Click;
            rbRadians.Click += RbRadians_Click;
            rbGrads.Click += RbGrads_Click;
            #endregion
        }

        private void RbDegrees_Click(object sender, RoutedEventArgs e)
        {
            double number = double.Parse(textBoxScreen.Text);
            double radians = GetRadians(number);
            textBoxScreen.Text = Math.Cos(radians).ToString(Thread.CurrentThread.CurrentUICulture);
            isCalculated = true;
        }

        private void RbRadians_Click(object sender, RoutedEventArgs e)
        {
            double number = double.Parse(textBoxScreen.Text);
            double radians = GetRadians(number);
            textBoxScreen.Text = Math.Sin(radians).ToString(Thread.CurrentThread.CurrentUICulture);
            isCalculated = true;
        }

        private void RbGrads_Click(object sender, RoutedEventArgs e)
        {
            double number = double.Parse(textBoxScreen.Text);
            double radians = GetRadians(number);
            textBoxScreen.Text = Math.Tan(radians).ToString(Thread.CurrentThread.CurrentUICulture);
            isCalculated = true;
        }

        private void ButtonPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (isCalculated)
                textBoxScreen.Text = "";
            if (textBoxScreen.Text.Length == 0)
                return;
            if (!textBoxScreen.Text.Contains("-"))
                textBoxScreen.Text = "-" + textBoxScreen.Text;
            else
                textBoxScreen.Text = textBoxScreen.Text.Replace("-", "");
        }

        private void ButtonSqrt_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    double sqrt = Convert.ToDouble(textBoxScreen.Text);
                    double sqrt1 = Math.Sqrt(sqrt);
                    textBoxScreen.Text = Convert.ToString(sqrt1);
                }
                catch (Exception exc)
                {
                    textBoxScreen.Text = exc.Message;
                }

            }
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                textBoxScreen.Text = exc.Message;
            }
        }
        private void ButtonOFF_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            textBoxScreen.Text = Convert.ToString(null);
        }
        private void Button_Click_NumberAndAction(object sender, RoutedEventArgs e)
        {
            // rect, x = 10, y = 20, width = 33, height....

            Button b = (Button)sender;
            string tmp = b.Content.ToString();

            #region страдание фигней с лишними запятыми и нулями на экране
            string[] arrayOperations = new string[] {"+", "-", "/", "*" };
            int iOp = 0;

            foreach (string operation in arrayOperations)
            {
                if (textBoxScreen.Text.Contains(operation))
                {
                    iOp = textBoxScreen.Text.IndexOf(operation);
                }
            }
            while (true)
            {
                if ((textBoxScreen.Text == "" && tmp.Contains(",")) || 
                    (textBoxScreen.Text == "0" && tmp.Contains("0")))
                    return;
                else
                    textBoxScreen.Text += b.Content.ToString();
                break;
            }
            string prevScreenText = textBoxScreen.Text.Substring(0, textBoxScreen.Text.Length-1);

            string number2 = textBoxScreen.Text.Substring(iOp + 1, textBoxScreen.Text.Length - iOp - 1);

            while (true)
            {
                if (((number2 == ",") && (iOp != 0)) ||
                    (number2 == "00") ||
                    number2.Contains (",,"))
                    textBoxScreen.Text = prevScreenText;
                break;
            }
            #endregion

        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxScreen.Text.Length > 0)
            {
                textBoxScreen.Text = textBoxScreen.Text.Substring(0, textBoxScreen.Text.Length - 1);
            }
        }

        private void ButtonSin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double sin = Convert.ToDouble(textBoxScreen.Text);
                double sin1 = Math.Sin(Math.PI * sin / 180);
                textBoxScreen.Text = Convert.ToString(sin1);

            }
            catch (Exception exc)
            {
                textBoxScreen.Text = exc.Message;
            }


        }
        private void ButtonCos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double cos = Convert.ToDouble(textBoxScreen.Text);
                double cos1 = Math.Cos(Math.PI * cos / 180);
                textBoxScreen.Text = Convert.ToString(cos1);

            }
            catch (Exception exc)
            {
                textBoxScreen.Text = exc.Message;
            }


        }
        private void ButtonTg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double tg = Convert.ToDouble(textBoxScreen.Text);
                if (tg == 90) { textBoxScreen.Text = "Недопустимый ввод"; }
                else
                {
                    double tg1 = Math.Tan(Math.PI * tg / 180);
                    textBoxScreen.Text = Convert.ToString(tg1);

                }
            }
            catch (Exception exc)
            {
                textBoxScreen.Text = exc.Message;
            }

        }

        private double GetRadians(double value)
        {
            double retval = value;
            if (rbDegrees.IsChecked.HasValue && rbDegrees.IsChecked.Value)
            {
                retval = value * Math.PI / 180;
            }
            else if (rbGrads.IsChecked.HasValue && rbGrads.IsChecked.Value)
            {
                retval = value * Math.PI / 200;
            }
            return retval;
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (textBoxScreen.Text.Contains("+"))
            {
                iOp = textBoxScreen.Text.IndexOf("+");
            }
            else if (textBoxScreen.Text.Contains("-"))
            {
                iOp = textBoxScreen.Text.IndexOf("-");
            }
            else if (textBoxScreen.Text.Contains("*"))
            {
                iOp = textBoxScreen.Text.IndexOf("*");
            }
            else if (textBoxScreen.Text.Contains("/"))
            {
                iOp = textBoxScreen.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            op = textBoxScreen.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(textBoxScreen.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(textBoxScreen.Text.Substring(iOp + 1, textBoxScreen.Text.Length - iOp - 1));

            if (op == "+")
            {
                textBoxScreen.Text = Convert.ToString(op1 + op2);
            }
            else if (op == "-")
            {
                textBoxScreen.Text = Convert.ToString(op1 - op2);
            }
            else if (op == "*")
            {
                textBoxScreen.Text = Convert.ToString(op1 * op2);
            }
            else if (op == "/")
            {
                if (op2 != 0)
                    textBoxScreen.Text = Convert.ToString(op1 / op2);
                else
                    textBoxScreen.Text = "Ошибка! Деление на ноль";
            }
        }
    }
}