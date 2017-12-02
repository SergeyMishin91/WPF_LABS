using System.Collections.ObjectModel;
using System.Windows;

namespace Lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Doctor> Doctors;

        public MainWindow()
        {
            Doctors = new ObservableCollection<Doctor>();
            InitializeComponent();
            lBox.DataContext = Doctors;
        }

        void FillData()
        {
            Doctors.Clear();
            foreach (var item in Doctor.GetAllDoctors())
            {
                Doctors.Add(item);
            }
        }

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            FillData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var doctor = new Doctor()
            {
                FirstName = "Имя",
                LastName = "Фамилия",
                Specialization = "Специализация",
                VisitCost = 0,
                Experience = 0,
                ID = 6
            };
            doctor.Insert();
            FillData();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var doctor = (Doctor)lBox.SelectedItem;
            doctor.FirstName = "Измененное имя";
            doctor.Update();
            FillData();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var id = ((Doctor)lBox.SelectedItem).ID;
            Doctor.Delete(id);
            FillData();
        }
    }
}
