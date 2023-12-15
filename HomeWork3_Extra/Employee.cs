namespace HomeWork3_Extra
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public bool IsBusy { get; } = false;
        public virtual void OfficialDuties()
        {

            Console.Write($"Должностные обязанности: ");

        }

    }
}
