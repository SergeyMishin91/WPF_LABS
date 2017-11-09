using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_WF
{
    internal class MainForm : Form
    {
        Label labelX = new Label() { Top = 30, Left = 20, Width = 25, Text = "X = " };
        Label labelY = new Label() { Top = 60, Left = 20, Width = 25, Text = "Y = " };
        Label labelZ = new Label() { Top = 90, Left = 20, Width = 25, Text = "Z = " };

        TextBox tbX = new TextBox() { Top = 30, Left = 50 };
        TextBox tbY = new TextBox() { Top = 60, Left = 50 };
        TextBox tbZ = new TextBox() { Top = 90, Left = 50 };

        Button button = new Button() { Top = 120, Left = 20, Text = "Вычислить" };
        TextBox tbResult = new TextBox() { Top = 160, Left = 20, ReadOnly = true, Multiline = true, Width = 200, Height = 100 };

        public MainForm()
        {
            InitComponent();
        }

        private void InitComponent()
        {
            Controls.AddRange(new[] { labelX, labelY, labelZ });
            Controls.AddRange(new[] { tbX, tbY, tbZ });
            Controls.Add(button);
            Controls.Add(tbResult);
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            double x = double.Parse(tbX.Text);
            double y = double.Parse(tbY.Text);
            double z = double.Parse(tbZ.Text);
            double result = FunctionResult(x, y, z);
            tbResult.Text = Convert.ToString(result);
        }

        private double FunctionResult(double x,double y,double z)
        {
            double funcresult = ((1 + Math.Pow(Math.Sin(x + y), 2)) / Math.Abs(x - (2 * y / 1 + (Math.Pow(x, 2) * Math.Pow(y, 2))))) * Math.Pow(x, Math.Abs(y)) +
              Math.Pow((Math.Cos(Math.Atan(1 / z))), 2);
            return funcresult;
        }
    }
}