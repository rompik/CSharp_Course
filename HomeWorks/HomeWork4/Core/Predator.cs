namespace HomeWork4.Core
{
    public class Predator : Animal
    {
        public override string Meals { get; set; }

        public Predator()
        {
            this.Meals = "мясо";
        }
    }
}
