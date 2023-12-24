using BL.DAL;
using Model;
using System.Collections.ObjectModel;

namespace BL
{
    public class MainWindowBL
    {
        MemoryEmployeeRepository repository;
        public ObservableCollection<Employee> Employees { get; set; }

        public MainWindowBL()
        {
            repository = new MemoryEmployeeRepository();
            Employees = repository.GetAll();
        }

        public void Add(string Name)
        {
            Employee employee = new Employee { Name = Name };
            Employees.Add(employee);
            repository.Add(employee);
        }

        public void Del(object emp)
        {
            Employee employee = (Employee)emp;
            Employees.Remove(employee);
            //repository.Remove(employee);
        }

    }
}
