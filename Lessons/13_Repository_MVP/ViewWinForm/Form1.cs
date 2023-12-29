using Model.BL;
using Model.Model;
using Presenter;

namespace ViewWinForm
{
    public partial class Form1 : Form, IMainView
    {
        public Form1()
        {
            InitializeComponent();
            IMainModel model = new MainModel();
            MainPresenter presenter = new MainPresenter(model, this);
            EventLoadView?.Invoke(this, new EventArgs());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public event EventHandler<EmployeeEventArgs> EventAddEmployee;
        public event EventHandler<EmployeeEventArgs> EventDelEmployee;
        public event EventHandler EventLoadView;

        public void Add(Employee employee)
        {
            listBox1.Items.Add(employee);
        }

        public void Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void LoadList(IList<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                listBox1.Items.Add(emp);
            }

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
    }
}
