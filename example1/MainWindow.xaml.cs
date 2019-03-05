using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace example1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public MainWindow()
        {
            InitializeComponent();
        }

        //startup code
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //string[] names = { "Tom", "Dick", "Harry" };

            Employee e1 = new Employee() { Name = "Tom", JoinDate = new DateTime(2018, 01, 01), WeeklyWage = 500m };
            Employee e2 = new Employee() { Name = "Dick", JoinDate = new DateTime(2018, 01, 01), WeeklyWage = 500m };
            Employee e3 = new Employee() { Name = "Harry", JoinDate = new DateTime(2018, 01, 01), WeeklyWage = 500m };

            //List<Employee> employees = new List<Employee>();

            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);

            lbxEmployees.ItemsSource = employees;
            tblkTotalWages.Text = GetTotalWages().ToString();
        }

        //add new employee
        private void BtnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            //Employee emp = new Employee() { Name = "Mary", JoinDate = DateTime.Now, WeeklyWage = 500m };

            //employees.Add(emp);

            //lbxEmployees.ItemsSource = null;
            //lbxEmployees.ItemsSource = employees;

            //read info from screen
            string name = tbxName.Text;
            decimal wages = Convert.ToDecimal(tbxWages.Text);
            DateTime joinDate = dpJoinDate.SelectedDate.Value;

            //create object with info
            Employee newEmployee = new Employee() { Name = name, JoinDate = joinDate, WeeklyWage = wages };

            //add to collection
            employees.Add(newEmployee);
            tblkTotalWages.Text = GetTotalWages().ToString();


        }

        private decimal GetTotalWages()
        {
            decimal total = 0;

            foreach (Employee e in employees)
            {
                total += e.WeeklyWage;
            }

            return total;
        }
    }
}
