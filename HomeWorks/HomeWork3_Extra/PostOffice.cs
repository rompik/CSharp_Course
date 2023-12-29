namespace HomeWork3_Extra
{
    internal class PostOffice
    {
        private readonly List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }

        public void Poll()
        {

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name);
                Console.WriteLine(Convert.ToString(e.IsBusy));
                e.OfficialDuties();
            }
        }
    }
}

//public class PostOffice
//{
//private List<Employee> employees = new List<Employee>();


//public void Poll()
//{
//if (employees != null)
//{
//foreach (Employee e in employees)
//{
//Console.WriteLine("");
//Console.WriteLine($"ФИО:{e.Name}");
//Console.WriteLine($"    Должность: {e.OfficialDuties()}");

//if (e.OfficialDuties() == "Почтальон")
//{
//Postman a = (Postman)e;
//Console.WriteLine($"    Занят: {a.IsBusy}");
//}
//else
//{
//Console.WriteLine($"    Занят: {e.IsBusy}");
//}
//}
//}
//else { Console.WriteLine("Список сотрудников пуст"); }
//}
//}