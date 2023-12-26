using BL;
using System.Windows;

namespace Repositories
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowBL bL;
        public MainWindow()
        {
            InitializeComponent();

            bL = new MainWindowBL();
            bL.Employees.CollectionChanged += Employees_CollectionChanged;

            EmployeeListBox.ItemsSource = bL.Employees;
        }

        private void Employees_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            EmployeeListBox.ItemsSource = bL.Employees;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bL.Add("New employee");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bL.Del(EmployeeListBox.SelectedItem);
        }
    }
}