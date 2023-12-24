using Model;
using System.Collections.ObjectModel;

namespace BL.DAL
{
    public class MemoryEmployeeRepository : IRepository
    {
        private ObservableCollection<Employee> values => new ObservableCollection<Employee>()
            {
                new Employee { Name = "Ivanov"},
                new Employee { Name = "Petrov" },
                new Employee { Name = "Suvorov" }
            };

        public void Add(Employee obj)
        {
            values.Add(obj);
        }

        public void Delete(Employee obj)
        {
            values.Remove(obj);
        }

        public ObservableCollection<Employee> GetAll()
        {
            return values;
        }
    }
}