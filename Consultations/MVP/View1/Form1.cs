using Model.BL;
using Model.Model;
using Presenter;
using System.Reflection;

namespace View1
{
    public partial class Form1 : Form, IMainView
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        public event EventHandler<EmployeeEventArgs> EventAddEmployee;
        public event EventHandler<EmployeeEventArgs> EventDelEmployee;
        public event EventHandler EventLoadView;

        public void Add(Employee employee)
        {
            listBox1.Items.Add(employee);
        }

        public void Del(Employee employee)
        {
            listBox1.Items.Remove(employee);
        }

        public void Loud(IList<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                listBox1.Items.Add(employee);
            } //TODO
        }

        public void Run(IList<Employee> employees)
        {           
            foreach (Employee employee in employees)
            {
                listBox1.Items.Add(employee);
            }
            Application.Run(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventAddEmployee?.Invoke(this,
               new EmployeeEventArgs(
                                       new Employee
                                       {
                                           Name = textBox1.Text,
                                           Age = (int)numericUpDown1.Value
                                       }
                                   )
               );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
