using Model.DAL;
using Model.Model;

namespace Model.BL
{
    public class MainModel : IMainModel
    {
        public IRepository<Employee> _repository { get; } = new FakeRepository<Employee>();

        public event EventHandler<EmployeeEventArgs> EventAddEmployee;

        public event EventHandler<EmployeeEventArgs> EventDelEmployee;
        public void AddEmployee(Employee employee)
        {
            _repository.Add(employee);
            EventAddEmployee?.Invoke(this, new EmployeeEventArgs(employee));
        }

        public void DeleteEmployee(Employee employee)
        {
            _repository.Delete(employee);
            EventDelEmployee?.Invoke(this, new EmployeeEventArgs(employee));
        }

        public IList<Employee> GetEmployees()
        {
            return _repository.GetAll().ToList();
        }
    }
}
