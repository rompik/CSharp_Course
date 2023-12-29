namespace HomeWork3_Extra
{
    public class Cashier : Employee
    {
        public override void OfficialDuties()
        {
            base.OfficialDuties();
            Console.WriteLine("Кассир");
        }
    }
}
