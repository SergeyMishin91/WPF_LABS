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

namespace WpfApplication4
{
    using Model;
    using Repository;
    using DAL;
    using System.ComponentModel;

    public partial class MainWindow : Window
    {
        private IHospitalRepository repository;
        public MainWindow()
        {
            InitializeComponent();
            repository = new HospitalRepository();
            UpdateListBox1();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Doctor selectedDoctor = listBox1.SelectedItem as Doctor;

            if (selectedDoctor != null)
            {
                label2.Content = $"{selectedDoctor.VisitCost} бел.руб.";
                label3.Content = $"{selectedDoctor.DoctorWorkExperience} лет";
            }
        }

        private void DoctorAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowAddDoctor winAddDoctor = new WindowAddDoctor();
            winAddDoctor.ShowDialog();

            UpdateListBox1();
        }

        public void UpdateListBox1()
        {
            repository = new HospitalRepository();
            listBox1.Items.Clear();
            foreach (Doctor doctor in repository.GetAll())
            {
                listBox1.Items.Add(doctor);
            }
        }

        private void RadioButton_CheckedSecondName(object sender, RoutedEventArgs e)
        {
            listBox1.Items.SortDescriptions.Clear();
            listBox1.Items.SortDescriptions.Add(new SortDescription("DoctorSecondName", ListSortDirection.Ascending)); 
            //+ListSortDirection.Descending
        }

        private void RadioButton_CheckedExperience(object sender, RoutedEventArgs e)
        {
            listBox1.Items.SortDescriptions.Clear();
            listBox1.Items.SortDescriptions.Add(new SortDescription("DoctorWorkExperience", ListSortDirection.Ascending));
        }

        private void RadioButton_CheckedCost(object sender, RoutedEventArgs e)
        {
            listBox1.Items.SortDescriptions.Clear();
            listBox1.Items.SortDescriptions.Add(new SortDescription("VisitCost", ListSortDirection.Ascending));
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
