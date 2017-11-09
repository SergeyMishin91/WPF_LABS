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

namespace WpfApplication4
{
    using Model;
    using Repository;
    using DAL;
    using System.IO;
    using WpfApplication4;

    public partial class WindowAddDoctor : Window
    {
        public WindowAddDoctor()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            Doctor NewDoctor = new Doctor();
            WindowError WinErr = new WindowError();
            try
            {
                NewDoctor.DoctorFirstName = TextBoxAddName.Text.ToString();
                NewDoctor.DoctorSecondName = TextBoxAddSurname.Text.ToString();
                NewDoctor.DoctorCvalification = TextBoxAddCvalification.Text.ToString();
                NewDoctor.DoctorWorkExperience = byte.Parse(TextBoxAddWorkExperience.Text.ToString());
                NewDoctor.VisitCost = double.Parse(TextBoxAddVisitCost.Text.ToString());
            }
            catch (Exception)
            {
                if ((TextBoxAddName.Text.Equals("")) && 
                    TextBoxAddSurname.Text == "" &&
                    TextBoxAddCvalification.Text == "" &&
                    TextBoxAddWorkExperience.Text == "" &&
                    TextBoxAddVisitCost.Text == "")
                {
                    WinErr.ShowDialog();
                    return;
                }
                WinErr.ShowDialog();
                ClearFields();
                return;
            }

            StreamWriter file = new StreamWriter("Doctors.txt", true, Encoding.Default);
            file.WriteLine(NewDoctor.ToFile());                 
            file.Close();

            this.Close();
        }

        private void ButtonClearFields_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            TextBoxAddName.Text = "";
            TextBoxAddSurname.Text = "";
            TextBoxAddCvalification.Text = "";
            TextBoxAddWorkExperience.Text = "";
            TextBoxAddVisitCost.Text = "";
        }
    }
}
