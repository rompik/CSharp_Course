namespace Model.Model
{
    public class Employee : IDomainObject
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {

            return Name;
        }

    }
}
