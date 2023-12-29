using Model.Model;

namespace Model.BL
{
    public class EmployeeEventArgs : EventArgs
    {
        public Employee Employee { get; set; }
        public EmployeeEventArgs(Employee employee)
        {
            Employee = employee;
        }
    }
}
