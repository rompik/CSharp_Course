namespace HomeWork4.Core
{
    public class Herbo : Animal
    {
        Random rmd = new Random();

        public int Kindness { get; }
        public override string Meals { get; set; }

        public Herbo()
        {
            this.Kindness = rmd.Next(0, 100);
            this.Meals = "мясо";

        }
    }
}
