namespace HomeWork3_Extra
{
    public class Operator : Employee
    {
        public override void OfficialDuties()
        {
            base.OfficialDuties();
            Console.WriteLine("Оператор");
        }
    }
}