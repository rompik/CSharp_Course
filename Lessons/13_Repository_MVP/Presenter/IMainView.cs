using Model.BL;
using Model.Model;

namespace Presenter
{
    public interface IMainView
    {
        event EventHandler<EmployeeEventArgs> EventAddEmployee;
        event EventHandler<EmployeeEventArgs> EventDelEmployee;
        event EventHandler EventLoadView;

        void Add(Employee employee);
        void Delete(Employee employee);
        void LoadList(IList<Employee> employees);
    }
}
