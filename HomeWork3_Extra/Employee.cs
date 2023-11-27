namespace HomeWork3
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public bool IsBusy { get; } = false;
        public virtual void OfficialDuties() { }

    }
}
