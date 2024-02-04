using Model.BL;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IMainView
    {
        event EventHandler<EmployeeEventArgs> EventAddEmployee;
        event EventHandler<EmployeeEventArgs> EventDelEmployee;
        event EventHandler EventLoadView;
        void Run(IList<Employee> employees);


        void Add(Employee employee);
        void Del(Employee employee);
        void Loud(IList<Employee> employees);
    }
}
