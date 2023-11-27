namespace HomeWork3
{
    internal class PostOffice
    {
        private readonly List<Employee> employees = new List<Employee>();
        public void Poll()
        {

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name);
                Console.WriteLine(Convert.ToString(e.IsBusy));
                Console.WriteLine(e.OfficialDuties);
            }
        }
    }
}
