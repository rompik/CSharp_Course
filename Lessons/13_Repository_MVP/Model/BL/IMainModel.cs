using Model.Model;

namespace Model.BL
{
    public interface IMainModel
    {
        event EventHandler<EmployeeEventArgs> EventAddEmployee;
        event EventHandler<EmployeeEventArgs> EventDelEmployee;

        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        IList<Employee> GetEmployees();

    }
}
