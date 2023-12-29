namespace HomeWork3_Extra
{
    public class Postman : Employee
    {
        public override void OfficialDuties()
        {
            base.OfficialDuties();
            Console.WriteLine("Почтальон");
        }
    }
}